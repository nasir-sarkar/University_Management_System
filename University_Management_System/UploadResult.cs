using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class UploadResult : Form
    {
        private SqlConnection connect;
        private string loggedinTid;
        public UploadResult(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinTid = getSid;
        }

        private void UploadResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet10.Enrollment' table. You can move, or remove it, as needed.
            // this.enrollmentTableAdapter.Fill(this.universityDataSet10.Enrollment);
            LoadResults();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = textBox_Sid.Text.Trim();
                string courseTitle = comboBox_Course.SelectedItem.ToString();
                string section = textBox_Sec.Text.Trim();
                string semester = textBox_Sem.Text.Trim();
                int marks;

                if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(courseTitle) ||
                    string.IsNullOrEmpty(section) || string.IsNullOrEmpty(semester) ||
                    !int.TryParse(textBox_Marks.Text.Trim(), out marks))
                {
                    MessageBox.Show("Please fill in all fields correctly.");
                    return;
                }

                string grade = CalculateGrade(marks);
                connect.Open();

                string checkEnrollmentQuery = "SELECT COUNT(*) FROM Enrollment WHERE Student_ID = @Student_ID AND Title = @Title";
                using (SqlCommand checkEnrollmentCmd = new SqlCommand(checkEnrollmentQuery, connect))
                {
                    checkEnrollmentCmd.Parameters.AddWithValue("@Student_ID", studentID);
                    checkEnrollmentCmd.Parameters.AddWithValue("@Title", courseTitle);

                    int enrolledCount = (int)checkEnrollmentCmd.ExecuteScalar();
                    if (enrolledCount == 0)
                    {
                        MessageBox.Show("Wrong Student ID. This student is not enrolled in the selected course.", "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string checkQuery = "SELECT COUNT(*) FROM Enrollment WHERE Student_ID = @Student_ID AND Title = @Title AND Section = @Section AND Semester = @Semester AND Teacher_ID = @Teacher_ID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@Student_ID", studentID);
                    checkCmd.Parameters.AddWithValue("@Title", courseTitle);
                    checkCmd.Parameters.AddWithValue("@Section", section);
                    checkCmd.Parameters.AddWithValue("@Semester", semester);
                    checkCmd.Parameters.AddWithValue("@Teacher_ID", loggedinTid);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("You are not a teacher of this course.");
                        return;
                    }
                }

                string updateQuery = "UPDATE Enrollment SET Grade = @Grade WHERE Student_ID = @Student_ID AND Title = @Title AND Section = @Section AND Semester = @Semester";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connect))
                {
                    updateCmd.Parameters.AddWithValue("@Grade", grade);
                    updateCmd.Parameters.AddWithValue("@Student_ID", studentID);
                    updateCmd.Parameters.AddWithValue("@Title", courseTitle);
                    updateCmd.Parameters.AddWithValue("@Section", section);
                    updateCmd.Parameters.AddWithValue("@Semester", semester);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Grade updated successfully.");
                        UpdateCGPA(studentID);
                        UpdateCreditCompleted(studentID);
                    }
                    else
                    {
                        MessageBox.Show("Error updating grade.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            LoadResults();
        }


        private string CalculateGrade(int marks)
        {
            if (marks >= 90) return "A+";
            if (marks >= 85) return "A";
            if (marks >= 80) return "B+";
            if (marks >= 75) return "B";
            if (marks >= 70) return "C+";
            if (marks >= 65) return "C";
            if (marks >= 60) return "D+";
            if (marks >= 50) return "D";
            return "F";
        }


        private void UpdateCGPA(string studentID)
        {
            try
            {
                string getGradesQuery = "SELECT Grade, Credit FROM Enrollment WHERE Student_ID = @Student_ID AND Grade IS NOT NULL";

                using (SqlCommand cmd = new SqlCommand(getGradesQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", studentID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No valid grades found for CGPA calculation.");
                        return;
                    }

                    Dictionary<string, double> gradePoints = new Dictionary<string, double>()
                    {
                    {"A+", 4.00}, {"A", 3.75}, {"B+", 3.50}, {"B", 3.25},
                    {"C+", 3.00}, {"C", 2.75}, {"D+", 2.50}, {"D", 2.25}, {"F", 0.00}
                    };

                    double totalCredits = 0;
                    double totalPoints = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        string grade = row["Grade"].ToString();
                        double credit = Convert.ToDouble(row["Credit"]);

                        if (gradePoints.ContainsKey(grade))
                        {
                            totalPoints += gradePoints[grade] * credit;
                            totalCredits += credit;
                        }
                    }

                    if (totalCredits == 0) return;

                    double CGPA = totalPoints / totalCredits;

                    string updateCGPAQuery = "UPDATE Student SET CGPA = @CGPA WHERE Student_ID = @Student_ID";

                    using (SqlCommand updateCmd = new SqlCommand(updateCGPAQuery, connect))
                    {
                        updateCmd.Parameters.AddWithValue("@CGPA", Math.Round(CGPA, 2));
                        updateCmd.Parameters.AddWithValue("@Student_ID", studentID);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating CGPA: " + ex.Message);
            }
        }


        private void UpdateCreditCompleted(string studentID)
        {
            try
            {
                string getCreditsQuery = "SELECT SUM(CAST(Credit AS INT)) FROM Enrollment WHERE Student_ID = @Student_ID AND Grade IS NOT NULL AND Grade <> 'F'";

                using (SqlCommand cmd = new SqlCommand(getCreditsQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", studentID);

                    object result = cmd.ExecuteScalar();
                    int totalCompletedCredits = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    string updateCreditQuery = "UPDATE Student SET Credit_Completed = @Credit_Completed WHERE Student_ID = @Student_ID";
                    using (SqlCommand updateCmd = new SqlCommand(updateCreditQuery, connect))
                    {
                        updateCmd.Parameters.AddWithValue("@Credit_Completed", totalCompletedCredits);
                        updateCmd.Parameters.AddWithValue("@Student_ID", studentID);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Credit Completed: " + ex.Message);
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Teacher a = new Teacher(loggedinTid);
            a.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_Sid.Clear();
            comboBox_Course.SelectedIndex = -1;
            textBox_Sec.Clear();
            textBox_Sem.Clear();
            textBox_Marks.Clear();
        }


        private void LoadResults()
        {
            try
            {
                string query = "SELECT * FROM Enrollment WHERE Teacher_ID = @Teacher_ID";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Teacher_ID", loggedinTid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading results: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_Sid.Text = row.Cells["Student_ID"].Value.ToString();
                comboBox_Course.Text = row.Cells["Title"].Value.ToString();
                textBox_Sec.Text = row.Cells["Section"].Value.ToString();
                textBox_Sem.Text = row.Cells["Semester"].Value.ToString();
            }
        }

        private void picBox_Refresh_Click(object sender, EventArgs e)
        {
            LoadResults();
        }

        private void btn_see_Click(object sender, EventArgs e)
        {
            try
            {
                string semester = textBoxSem.Text.Trim();

                if (string.IsNullOrEmpty(semester))
                {
                    MessageBox.Show("Please enter a semester.");
                    return;
                }

                string query = "SELECT * FROM Enrollment WHERE Semester = @Semester AND Teacher_ID = @Teacher_ID";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    cmd.Parameters.AddWithValue("@Teacher_ID", loggedinTid);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the given semester.");
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching results: " + ex.Message);
            }
        }

        private void textBoxSem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

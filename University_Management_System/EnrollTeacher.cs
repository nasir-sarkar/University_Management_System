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
    public partial class EnrollTeacher : Form
    {
        private SqlConnection connect;
        private string loggedinAid;
        public EnrollTeacher(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinAid = getID;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(loggedinAid);
            a.Show();
            this.Hide();
        }

        private void textBox_Tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Sec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            string teacherId = textBox_Tid.Text.Trim();
            string courseTitle = comboBox_Course.Text.Trim();
            string section = textBox_Sec.Text.Trim();
            string semester = textBox_Sem.Text.Trim();

            if (string.IsNullOrEmpty(teacherId) || string.IsNullOrEmpty(courseTitle) || string.IsNullOrEmpty(section) || string.IsNullOrEmpty(semester))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryTeacher = "SELECT COUNT(*) FROM Teacher WHERE Teacher_ID = @Teacher_ID";
            string queryCourse = "SELECT COUNT(*) FROM Courses WHERE Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryEnrollment = "SELECT COUNT(*) FROM Enrollment WHERE Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryUpdate = "UPDATE Enrollment SET Teacher_ID = @Teacher_ID WHERE Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryCheckDuplicate = "SELECT COUNT(*) FROM Enrollment WHERE Teacher_ID = @Teacher_ID AND Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryGetCourseTime = "SELECT Starting_Time, Ending_Time, Days FROM Enrollment WHERE Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryCheckCourseExistence = "SELECT COUNT(*) FROM Courses WHERE Title = @Title AND Section = @Section AND Semester = @Semester";
            string queryCheckStudentEnrollment = "SELECT COUNT(*) FROM Enrollment WHERE Title = @Title AND Section = @Section AND Semester = @Semester AND Student_ID IS NOT NULL";


            try
            {
                connect.Open();


                using (SqlCommand cmd = new SqlCommand(queryCheckCourseExistence, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    int courseExists = (int)cmd.ExecuteScalar();

                    if (courseExists == 0)
                    {
                        MessageBox.Show("Course does not exist in the Courses table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

           
                using (SqlCommand cmd = new SqlCommand(queryCheckStudentEnrollment, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    int studentCount = (int)cmd.ExecuteScalar();

                    if (studentCount == 0)
                    {
                        MessageBox.Show("Teacher enrollment failed because no students have been enrolled here.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand cmd = new SqlCommand(queryTeacher, connect))
                {
                    cmd.Parameters.AddWithValue("@Teacher_ID", teacherId);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Teacher ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

              
                using (SqlCommand cmd = new SqlCommand(queryCourse, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Course with this section and semester does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                
                using (SqlCommand cmd = new SqlCommand(queryCheckDuplicate, connect))
                {
                    cmd.Parameters.AddWithValue("@Teacher_ID", teacherId);
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Teacher is already enrolled in this course with the same section and semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                TimeSpan startTime, endTime;
                string days;

                using (SqlCommand cmd = new SqlCommand(queryGetCourseTime, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            startTime = (TimeSpan)reader["Starting_Time"];
                            endTime = (TimeSpan)reader["Ending_Time"];
                            days = reader["Days"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Could not retrieve course time details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                string queryTimeClash = @"
                SELECT COUNT(*) FROM Enrollment 
                WHERE Teacher_ID = @TeacherID 
                AND Semester = @Semester 
                AND Days = @Days 
                AND NOT (Starting_Time >= @EndTime OR Ending_Time <= @StartTime)";

                using (SqlCommand cmd = new SqlCommand(queryTimeClash, connect))
                {
                    cmd.Parameters.AddWithValue("@TeacherID", teacherId);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    cmd.Parameters.AddWithValue("@Days", days);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    int timeClashExists = (int)cmd.ExecuteScalar();

                    if (timeClashExists > 0)
                    {
                        MessageBox.Show("Time clash detected! Please select a different course or section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (SqlCommand cmd = new SqlCommand(queryEnrollment, connect))
                {
                    cmd.Parameters.AddWithValue("@Title", courseTitle);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand updateCmd = new SqlCommand(queryUpdate, connect))
                        {
                            updateCmd.Parameters.AddWithValue("@Teacher_ID", teacherId);
                            updateCmd.Parameters.AddWithValue("@Title", courseTitle);
                            updateCmd.Parameters.AddWithValue("@Section", section);
                            updateCmd.Parameters.AddWithValue("@Semester", semester);
                            updateCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Teacher enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_cancel_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Teacher enrollment failed because no students have been enrolled here.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            LoadEnrollment();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_Tid.Clear();
            comboBox_Course.SelectedIndex = -1;
            textBox_Sec.Clear();
            textBox_Sem.Clear();
        }

        private void EnrollTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet13.Courses' table. You can move, or remove it, as needed.
            //  this.coursesTableAdapter.Fill(this.universityDataSet13.Courses);
            LoadCourses();
            LoadEnrollment();

        }

        private void LoadEnrollment()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Enrollment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string courseID = row.Cells["Course_ID"].Value.ToString();
                string studentID = row.Cells["Student_ID"].Value.ToString();

                MessageBox.Show($"Course ID: {courseID}\nStudent ID: {studentID}", "Enrollment Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void LoadCourses()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Courses", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCourses();
        }

        private void btn_Srch1_Click(object sender, EventArgs e)
        {
            string semester = textBox_Sem1.Text.Trim();
            if (string.IsNullOrEmpty(semester))
            {
                MessageBox.Show("Please enter a semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string query = "SELECT * FROM Courses WHERE Semester = @Semester";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                adapter.SelectCommand.Parameters.AddWithValue("@Semester", semester);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_Srch2_Click(object sender, EventArgs e)
        {
            string semester = textBox_Sem2.Text.Trim();
            if (string.IsNullOrEmpty(semester))
            {
                MessageBox.Show("Please enter a semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string query = "SELECT * FROM Enrollment WHERE Semester = @Semester";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                adapter.SelectCommand.Parameters.AddWithValue("@Semester", semester);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }


        private void picBox_sRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadEnrollment();
        }
    }
}

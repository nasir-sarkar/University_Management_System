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
    public partial class EnrollStudent : Form
    {
        private SqlConnection connect;
        private string loggedinAid;
        public EnrollStudent(string getID)
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

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Sec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enroll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Sid.Text) ||
                 comboBox_Course.SelectedIndex == -1 ||
                 string.IsNullOrWhiteSpace(textBox_Sec.Text) ||
                 string.IsNullOrWhiteSpace(textBox_Sem.Text))
            {
                MessageBox.Show("Please fill in all fields before enrolling.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentId = textBox_Sid.Text;
            string courseTitle = comboBox_Course.SelectedItem.ToString();
            string section = textBox_Sec.Text;
            string semester = textBox_Sem.Text;

            try
            {
                connect.Open();

                SqlCommand checkStudentCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE Student_ID = @StudentID", connect);
                checkStudentCmd.Parameters.AddWithValue("@StudentID", studentId);
                int studentExists = (int)checkStudentCmd.ExecuteScalar();

                if (studentExists == 0)
                {
                    MessageBox.Show("Student ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }

                SqlCommand checkCourseCmd = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE Title = @CourseTitle", connect);
                checkCourseCmd.Parameters.AddWithValue("@CourseTitle", courseTitle);
                int courseExists = (int)checkCourseCmd.ExecuteScalar();

                if (courseExists == 0)
                {
                    MessageBox.Show("Course Title does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }

                SqlCommand checkSectionCmd = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE Title = @CourseTitle AND Section = @Section", connect);
                checkSectionCmd.Parameters.AddWithValue("@CourseTitle", courseTitle);
                checkSectionCmd.Parameters.AddWithValue("@Section", section);
                int sectionExists = (int)checkSectionCmd.ExecuteScalar();

                if (sectionExists == 0)
                {
                    MessageBox.Show("Section does not exist for this course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }

                SqlCommand checkSemesterCmd = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE Semester = @Semester", connect);
                checkSemesterCmd.Parameters.AddWithValue("@Semester", semester);
                int semesterExists = (int)checkSemesterCmd.ExecuteScalar();

                if (semesterExists == 0)
                {
                    MessageBox.Show("The entered semester does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connect.Close();
                    return;
                }

                SqlCommand getCourseDetailsCmd = new SqlCommand("SELECT * FROM Courses WHERE Title = @CourseTitle AND Section = @Section", connect);
                getCourseDetailsCmd.Parameters.AddWithValue("@CourseTitle", courseTitle);
                getCourseDetailsCmd.Parameters.AddWithValue("@Section", section);
                SqlDataReader reader = getCourseDetailsCmd.ExecuteReader();

                if (reader.Read())
                {
                    string courseId = reader["Course_ID"].ToString();
                    string credit = reader["Credit"].ToString();
                    string startingTime = reader["Starting_Time"].ToString();
                    string endingTime = reader["Ending_Time"].ToString();
                    string days = reader["Days"].ToString();
                    reader.Close();

                    TimeSpan startTime = TimeSpan.Parse(startingTime);
                    TimeSpan endTime = TimeSpan.Parse(endingTime);

                    SqlCommand checkDuplicateTitleCmd = new SqlCommand("SELECT COUNT(*) FROM Enrollment WHERE Student_ID = @StudentID AND Title = @Title", connect);
                    checkDuplicateTitleCmd.Parameters.AddWithValue("@StudentID", studentId);
                    checkDuplicateTitleCmd.Parameters.AddWithValue("@Title", courseTitle);
                    int duplicateTitle = (int)checkDuplicateTitleCmd.ExecuteScalar();

                    if (duplicateTitle > 0)
                    {
                        MessageBox.Show("Student is already enrolled in this course, regardless of section or semester.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connect.Close();
                        return;
                    }


                    SqlCommand checkTimeClashCmd = new SqlCommand("SELECT COUNT(*) FROM Enrollment WHERE Student_ID = @StudentID AND Semester = @Semester AND Days = @Days AND NOT (Starting_Time >= @EndTime OR Ending_Time <= @StartTime)", connect);
                    checkTimeClashCmd.Parameters.AddWithValue("@StudentID", studentId);
                    checkTimeClashCmd.Parameters.AddWithValue("@Semester", semester);
                    checkTimeClashCmd.Parameters.AddWithValue("@Days", days);
                    checkTimeClashCmd.Parameters.AddWithValue("@StartTime", startTime);
                    checkTimeClashCmd.Parameters.AddWithValue("@EndTime", endTime);
                    int timeClashExists = (int)checkTimeClashCmd.ExecuteScalar();

                    if (timeClashExists > 0)
                    {
                        MessageBox.Show("Time clash detected! Please select a different course or section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connect.Close();
                        return;
                    }


                    SqlCommand checkTeacherCmd = new SqlCommand("SELECT TOP 1 Teacher_ID FROM Enrollment WHERE Title = @Title AND Section = @Section AND Semester = @Semester AND Teacher_ID IS NOT NULL", connect);
                    checkTeacherCmd.Parameters.AddWithValue("@Title", courseTitle);
                    checkTeacherCmd.Parameters.AddWithValue("@Section", section);
                    checkTeacherCmd.Parameters.AddWithValue("@Semester", semester);

                    object teacherIdObj = checkTeacherCmd.ExecuteScalar();
                    string teacherId = teacherIdObj != null ? teacherIdObj.ToString() : null;

                    SqlCommand enrollStudentCmd = new SqlCommand("INSERT INTO Enrollment (Student_ID, Course_ID, Title, Section, Credit, Semester, Days, Starting_Time, Ending_Time, Teacher_ID) " +
                        "VALUES (@StudentID, @CourseID, @Title, @Section, @Credit, @Semester, @Days, @StartingTime, @EndingTime, @TeacherID)", connect);
                    enrollStudentCmd.Parameters.AddWithValue("@StudentID", studentId);
                    enrollStudentCmd.Parameters.AddWithValue("@CourseID", courseId);
                    enrollStudentCmd.Parameters.AddWithValue("@Title", courseTitle);
                    enrollStudentCmd.Parameters.AddWithValue("@Section", section);
                    enrollStudentCmd.Parameters.AddWithValue("@Credit", credit);
                    enrollStudentCmd.Parameters.AddWithValue("@Semester", semester);
                    enrollStudentCmd.Parameters.AddWithValue("@Days", days);
                    enrollStudentCmd.Parameters.AddWithValue("@StartingTime", startTime);
                    enrollStudentCmd.Parameters.AddWithValue("@EndingTime", endTime);
                    enrollStudentCmd.Parameters.AddWithValue("@TeacherID", (object)teacherId ?? DBNull.Value);

                    enrollStudentCmd.ExecuteNonQuery();
                    MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancel_Click(sender, e);

                    SqlCommand updateCountCmd = new SqlCommand(@"
                    UPDATE Courses
                    SET Count = (SELECT COUNT(*) FROM Enrollment 
                    WHERE Title = @Title AND Section = @Section AND Semester = @Semester)
                    WHERE Title = @Title AND Section = @Section AND Semester = @Semester", connect);

                    updateCountCmd.Parameters.AddWithValue("@Title", courseTitle);
                    updateCountCmd.Parameters.AddWithValue("@Section", section);
                    updateCountCmd.Parameters.AddWithValue("@Semester", semester);

                    updateCountCmd.ExecuteNonQuery();
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connect.Close();
            }

            LoadEnrollment();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_Sid.Clear();
            comboBox_Course.SelectedIndex = -1;
            textBox_Sec.Clear();
            textBox_Sem.Clear();
        }

        private void textBox_Sem_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet12.Courses' table. You can move, or remove it, as needed.
            //this.coursesTableAdapter.Fill(this.universityDataSet12.Courses);
            // TODO: This line of code loads data into the 'universityDataSet5.Enrollment' table. You can move, or remove it, as needed.
            //this.enrollmentTableAdapter.Fill(this.universityDataSet5.Enrollment);
            LoadCourses();
            LoadEnrollment();
            LoadCourseRegStatus();

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


        private void LoadCourseRegStatus()
        {
            try
            {
                if (connect.State != System.Data.ConnectionState.Open)
                    connect.Open();

                string checkQuery = "SELECT Course_Reg FROM Student";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    string currentStatus = checkCmd.ExecuteScalar()?.ToString();

                    if (currentStatus == "On")
                    {
                        label_On.Text = "Currently 'Turned On'";
                        label_Off.Text = "Make it Off";
                    }
                    else if (currentStatus == "Off")
                    {
                        label_Off.Text = "Currently 'Turned Off'";
                        label_On.Text = "Make it On";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == System.Data.ConnectionState.Open)
                    connect.Close();
            }
        }


        private void label_On_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != System.Data.ConnectionState.Open)
                    connect.Open();

                string checkQuery = "SELECT Course_Reg FROM Student";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    string currentStatus = checkCmd.ExecuteScalar()?.ToString();

                    if (currentStatus == "On")
                    {
                        MessageBox.Show("Already On!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                string query = "UPDATE Student SET Course_Reg = 'On'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Turned On successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                label_On.Text = "Currently 'Turned On'";
                label_Off.Text = "Make it Off";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
            }
        }

        private void label_Off_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State != System.Data.ConnectionState.Open)
                    connect.Open();

                string checkQuery = "SELECT Course_Reg FROM Student";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    string currentStatus = checkCmd.ExecuteScalar()?.ToString();

                    if (currentStatus == "Off")
                    {
                        MessageBox.Show("Already Off!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                string query = "UPDATE Student SET Course_Reg = 'Off'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Turned Off successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                label_Off.Text = "Currently 'Turned Off'";
                label_On.Text = "Make it On";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
            }
        }
    }
}

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
    public partial class RegisterCourse : Form
    {
        private SqlConnection connect;
        private string loggedinSid;
        public RegisterCourse(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinSid = getSid;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loggedinSid) ||
                comboBox_Course.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBox_Sec.Text) ||
                string.IsNullOrWhiteSpace(textBox_Sem.Text))
            {
                MessageBox.Show("Please fill in all fields before enrolling.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentId = loggedinSid;
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

                SqlCommand checkCapacityCmd = new SqlCommand("SELECT Count FROM Courses WHERE Title = @Title AND Section = @Section AND Semester = @Semester", connect);
                checkCapacityCmd.Parameters.AddWithValue("@Title", courseTitle);
                checkCapacityCmd.Parameters.AddWithValue("@Section", section);
                checkCapacityCmd.Parameters.AddWithValue("@Semester", semester);

                object result = checkCapacityCmd.ExecuteScalar();
                int currentCount = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                if (currentCount >= 40)
                {
                    MessageBox.Show("Section is full. Please select a different section or course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("You have already enrolled in this course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            LoadCourses();
        }

        private void RegisterCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet18.Courses' table. You can move, or remove it, as needed.
            //this.coursesTableAdapter3.Fill(this.universityDataSet18.Courses);
            // TODO: This line of code loads data into the 'universityDataSet17.Courses' table. You can move, or remove it, as needed.
         //   this.coursesTableAdapter2.Fill(this.universityDataSet17.Courses);
            // TODO: This line of code loads data into the 'universityDataSet16.Courses' table. You can move, or remove it, as needed.
            // this.coursesTableAdapter1.Fill(this.universityDataSet16.Courses);
            LoadCourses();
        }


        private void LoadCourses()
        {
            try
            {
                string query = @"
                WITH RankedSemesters AS (
                SELECT *, 
                       RIGHT(Semester, 9) AS AcademicYear, 
                       CASE 
                           WHEN Semester LIKE 'Fall%' THEN 1
                           WHEN Semester LIKE 'Spring%' THEN 2
                           WHEN Semester LIKE 'Summer%' THEN 3
                       END AS SemesterOrder,
                       DENSE_RANK() OVER (ORDER BY RIGHT(Semester, 9) DESC, 
                                                  CASE 
                                                      WHEN Semester LIKE 'Fall%' THEN 1
                                                      WHEN Semester LIKE 'Spring%' THEN 2
                                                      WHEN Semester LIKE 'Summer%' THEN 3
                                                  END DESC) AS RankNum
                FROM Courses
            )
            SELECT Title, Section, Count, Credit, Starting_Time, Ending_Time, Semester, Course_ID, Days
            FROM RankedSemesters 
            WHERE RankNum = 1
            AND Course_ID NOT IN (
                SELECT Course_ID FROM Enrollment WHERE Student_ID = @StudentID
            );";

                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", loggedinSid);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadCourses();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Student a = new Student(loggedinSid);
            a.Show();
            this.Hide();
        }


        private void btn_Srch1_Click(object sender, EventArgs e)
        {
            if (comboBox_SrchSem.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course title to search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTitle = comboBox_SrchSem.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTitle))
            {
                MessageBox.Show("Please select a valid course title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                WITH RankedSemesters AS (
                SELECT *, 
                   RIGHT(Semester, 9) AS AcademicYear, 
                   CASE 
                       WHEN Semester LIKE 'Fall%' THEN 1
                       WHEN Semester LIKE 'Spring%' THEN 2
                       WHEN Semester LIKE 'Summer%' THEN 3
                   END AS SemesterOrder,
                   DENSE_RANK() OVER (ORDER BY RIGHT(Semester, 9) DESC, 
                                              CASE 
                                                  WHEN Semester LIKE 'Fall%' THEN 1
                                                  WHEN Semester LIKE 'Spring%' THEN 2
                                                  WHEN Semester LIKE 'Summer%' THEN 3
                                              END DESC) AS RankNum
                FROM Courses
                )

                SELECT Title, Section, Credit, Starting_Time, Ending_Time, Semester, Course_ID, Days, Count 
                FROM RankedSemesters 
                WHERE RankNum = 1 
                AND Title = @Title
                AND Course_ID NOT IN (
                SELECT Course_ID FROM Enrollment WHERE Student_ID = @StudentID
                );";

                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                da.SelectCommand.Parameters.AddWithValue("@Title", selectedTitle);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", loggedinSid);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No uncompleted courses found for the selected title in the latest semester.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void picBox_sRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            comboBox_Course.SelectedIndex = -1;
            textBox_Sec.Clear();
            textBox_Sem.Clear();
        }
    }
}

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
    public partial class AddCourse : Form
    {
        private SqlConnection connect;
        private string loggedinAid;
        public AddCourse(string getID)
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

        private void AddCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet11.Courses' table. You can move, or remove it, as needed.
            //this.coursesTableAdapter1.Fill(this.universityDataSet11.Courses);
            // TODO: This line of code loads data into the 'universityDataSet4.Courses' table. You can move, or remove it, as needed.
            //this.coursesTableAdapter.Fill(this.universityDataSet4.Courses);

            LoadCourses();

            /*comboBox_Course.Items.AddRange(new string[] {
                "SOFTWARE ENGINEERING", "OPERATING SYSTEM", "COMPILER DESIGN", "COMPUTER GRAPHICS",
                "PRINCIPLES OF ACCOUNTING", "PRINCIPLES OF ECONOMICS", "BUSINESS COMMUNICATION",
                "ELECTRONIC DEVICES", "ELECTRONIC DEVICES LAB", "DATA COMMUNICATION", "MICROPROCESSOR"
            });*/
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string courseTitle = comboBox_Course.SelectedItem?.ToString();
            string courseId = textBox_Cid.Text.Trim();
            string section = textBox_Sec.Text.Trim();
            string credit = textBox_crdt.Text.Trim();
            string days = textBox_Days.Text.Trim();
            string startTime = textBox_Stime.Text.Trim();
            string endTime = textBox_Etime.Text.Trim();
            string semester = textBox_semester.Text.Trim();

            
            if (string.IsNullOrEmpty(courseTitle) || string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(section) ||
                string.IsNullOrEmpty(credit) || string.IsNullOrEmpty(days) || string.IsNullOrEmpty(startTime) ||
                string.IsNullOrEmpty(endTime) || string.IsNullOrEmpty(semester))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!Regex.IsMatch(credit, @"^[1-3]$"))
            {
                MessageBox.Show("Credit should be 1, 2, or 3.");
                return;
            }

            
            DateTime start;
            DateTime end;
            if (!DateTime.TryParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out start) ||
                !DateTime.TryParseExact(endTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out end))
            {
                MessageBox.Show("Please enter valid time in 24-hour format.");
                return;
            }

            
            try
            {
                connect.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE Title = @Title AND Section = @Section AND Semester = @Semester", connect);
                checkCmd.Parameters.AddWithValue("@Title", courseTitle);
                checkCmd.Parameters.AddWithValue("@Section", section);
                checkCmd.Parameters.AddWithValue("@Semester", semester);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This section already exists for the selected course in the same semester.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Courses (Course_ID, Title, Section, Credit, Starting_Time, Ending_Time, Semester, days) VALUES (@Course_ID, @Title, @Section, @Credit, @Starting_Time, @Ending_Time, @Semester, @Days)", connect);
                cmd.Parameters.AddWithValue("@Course_ID", courseId);
                cmd.Parameters.AddWithValue("@Title", courseTitle);
                cmd.Parameters.AddWithValue("@Section", section);
                cmd.Parameters.AddWithValue("@Credit", credit);
                cmd.Parameters.AddWithValue("@Starting_Time", start);
                cmd.Parameters.AddWithValue("@Ending_Time", end);
                cmd.Parameters.AddWithValue("@Semester", semester);
                cmd.Parameters.AddWithValue("@Days", days);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Course added successfully!");
                btn_cancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            LoadCourses();
        }

        private void textBox_crdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            comboBox_Course.SelectedIndex = -1;
            textBox_Cid.Clear();
            textBox_Sec.Clear();
            textBox_crdt.Clear();
            textBox_Days.Clear();
            textBox_Stime.Clear();
            textBox_Etime.Clear();
            textBox_semester.Clear();
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadCourses()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Courses", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

                textBox_Cid.Text = row.Cells["Course_ID"].Value.ToString();
                comboBox_Course.SelectedItem = row.Cells["Title"].Value.ToString();
                textBox_Sec.Text = row.Cells["Section"].Value.ToString();
                textBox_crdt.Text = row.Cells["Credit"].Value.ToString();
                textBox_Stime.Text = row.Cells["Starting_Time"].Value.ToString();
                textBox_Etime.Text = row.Cells["Ending_Time"].Value.ToString();
                textBox_semester.Text = row.Cells["Semester"].Value.ToString();
                textBox_Days.Text = row.Cells["Days"].Value.ToString();
            }
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
    }
}

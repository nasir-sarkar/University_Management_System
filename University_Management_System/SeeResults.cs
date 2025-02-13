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
    public partial class SeeResults : Form
    {
        private SqlConnection connect;
        private string loggedinSid;
        public SeeResults(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinSid = getSid;

            LoadStudentInfo();
        }

        private void SeeResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet9.Enrollment' table. You can move, or remove it, as needed.
            // this.enrollmentTableAdapter.Fill(this.universityDataSet9.Enrollment);
            LoadResults();
        }


        private void LoadStudentInfo()
        {
            try
            {
                connect.Open();
                string query = "SELECT Name, Student_ID, CGPA, Credit_Completed FROM Student WHERE Student_ID = @Student_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_getName.Text = reader["Name"].ToString();
                        lbl_getID.Text = reader["Student_ID"].ToString();
                        lbl_getCgpa.Text = reader["CGPA"].ToString();
                        lbl_getCredit.Text = reader["Credit_Completed"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student info: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void LoadResults()
        {
            try
            {
                connect.Open();
                string query = "SELECT Course_ID, Title, Section, Credit, Semester, Student_ID, Teacher_ID, Grade, Starting_Time, Ending_Time, Days " +
                               "FROM Enrollment WHERE Student_ID = @Student_ID and Grade is not NULL";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadResults();
        }

        private void textBox_Sem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_see_Click(object sender, EventArgs e)
        {
            try
            {
                string semester = textBox_Sem.Text.Trim();
                if (string.IsNullOrEmpty(semester))
                {
                    MessageBox.Show("Please enter a semester.");
                    return;
                }

                connect.Open();
                string query = "SELECT Course_ID, Title, Section, Credit, Semester, Student_ID, Teacher_ID, Grade, Starting_Time, Ending_Time, Days " +
                               "FROM Enrollment WHERE Student_ID = @Student_ID AND Semester = @Semester AND Grade is not NULL" ;

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);
                    cmd.Parameters.AddWithValue("@Semester", semester);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
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
        }

        private void picBox_Refresh_Click(object sender, EventArgs e)
        {
            LoadResults();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Student a = new Student(loggedinSid);
            a.Show();
            this.Hide();
        }
    }
}

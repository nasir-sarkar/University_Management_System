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
    public partial class Teacher : Form
    {
        private SqlConnection connect;
        private T_options z;
        private string loggedinTid;

        public Teacher(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinTid = getID;

            z = new T_options(loggedinTid);
            z.StartPosition = FormStartPosition.Manual;      
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet8.Enrollment' table. You can move, or remove it, as needed.
            //this.enrollmentTableAdapter.Fill(this.universityDataSet8.Enrollment);
            lbl_getID.Text = loggedinTid;
            LoadTeacherDetails();
            LoadEnrollment();
        }


        private void LoadTeacherDetails()
        {
            try
            {
                connect.Open();
                string query = "SELECT Name, Salary, DOB, Email, Gender FROM Teacher WHERE Teacher_ID = @Teacher_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Teacher_ID", loggedinTid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullName = reader["Name"].ToString();
                        string firstName = fullName.Split(' ')[0];

                        lbl_getTitle.Text = firstName;
                        lbl_getName.Text = fullName;
                        lbl_getSalary.Text = reader["Salary"].ToString();
                        lbl_getDob.Text = Convert.ToDateTime(reader["DOB"]).ToString("yyyy-MM-dd");
                        lbl_getEmail.Text = reader["Email"].ToString();
                        lbl_getGender.Text = reader["Gender"].ToString();
                    }
                    reader.Close();
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

        private void picBox_3lines_Click(object sender, EventArgs e)
        {
            z.Location = new Point(this.Right - z.Width, this.Top);

            if (!z.Visible)
            {
                z.Show();
            }

            z.BringToFront();
        }

        private void picBox_lout_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void LoadEnrollment()
        {
            try
            {
                connect.Open();
                string query = @"
            SELECT DISTINCT Course_ID, Title, Section, Semester, Credit, Starting_Time, Ending_Time, Days 
            FROM Enrollment 
            WHERE Teacher_ID = @Teacher_ID AND Grade IS NULL";

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
                MessageBox.Show("Error loading enrollment data: " + ex.Message);
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
                MessageBox.Show("Selected Enrollment ID: " + row.Cells["Enrollment_ID"].Value.ToString());
            }
        }
    }
}

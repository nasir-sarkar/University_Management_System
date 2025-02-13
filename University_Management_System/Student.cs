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
    public partial class Student : Form
    {
        private SqlConnection connect; 
        private S_options z;
        private string loggedinSid;

        public Student(string getID)
        {
            InitializeComponent();          

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());          

            loggedinSid = getID;

            z = new S_options(loggedinSid); 
            z.StartPosition = FormStartPosition.Manual;

        }

        private void Student_Load(object sender, EventArgs e)
        {
            lbl_getID.Text = loggedinSid;
            LoadStudentDetails();
            LoadEnrollment();
        }

        private void LoadStudentDetails()
        {
            try
            {
                connect.Open();
                string query = "SELECT Name, CGPA, DOB, Email, Gender FROM Student WHERE Student_ID = @Student_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullName = reader["Name"].ToString();
                        string firstName = fullName.Split(' ')[0];

                        lbl_getTitle.Text = firstName;
                        lbl_getName.Text = fullName;
                        lbl_getCGPA.Text = reader["CGPA"].ToString();
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void picBox_lout_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

    
        private void lbl_getTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getID_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getDob_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbl_getGender_Click(object sender, EventArgs e)
        {

        }

        private void LoadEnrollment() 
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Enrollment WHERE Student_ID = @Student_ID AND Grade IS NULL";
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

        private void sID_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

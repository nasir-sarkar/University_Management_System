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
    public partial class S_options : Form
    {
        private SqlConnection connect;
        private string loggedinSid;

        public S_options(string getSid)
        {
            InitializeComponent();
            
            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinSid = getSid;
        }

        private void S_options_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private bool IsStudentInfoComplete()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = "SELECT Program, Blood, Father, Mother, Contact, Address, Nationality FROM Student WHERE Student_ID = @Student_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (reader.IsDBNull(i) || string.IsNullOrWhiteSpace(reader[i].ToString()))
                                {
                                    return false;
                                }
                            }
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
            return false;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
             Student a = new Student(loggedinSid);
             a.Show();
             this.Hide();
        }

        private void label_updateInfo_Click(object sender, EventArgs e)
        {      
            StudentData a = new StudentData(loggedinSid);
            a.Show();
            this.Hide();
        }

        private void label_result_Click(object sender, EventArgs e)
        {
            if (!IsStudentInfoComplete())
            {
                MessageBox.Show("Please update your information to access other facilities.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SeeResults a = new SeeResults(loggedinSid);
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!IsStudentInfoComplete())
            {
                MessageBox.Show("Please, update your information to access other facilities.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                connect.Open();

                string query = "SELECT Course_Reg FROM Student WHERE Student_ID = @Student_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Student_ID", loggedinSid);

                    string courseRegStatus = cmd.ExecuteScalar()?.ToString();

                    if (courseRegStatus == "Off")
                    {
                        MessageBox.Show("You are not allowed to do registration today.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                RegisterCourse a = new RegisterCourse(loggedinSid);
                a.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                connect.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!IsStudentInfoComplete())
            {
                MessageBox.Show("Please, update your information to access other facilities.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PasswordStudent a = new PasswordStudent(loggedinSid);
            a.Show();
            this.Hide();
        }
    }
}

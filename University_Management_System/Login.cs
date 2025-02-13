using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace University_Management_System
{
    public partial class Login : Form
    {
        private SqlConnection connect;
        public Login()
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            textBox_pass.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Registration a = new Registration();
            a.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userId = textBox_id.Text;
            string password = textBox_pass.Text;

            try
            {
                connect.Open();

                string query = "SELECT Status FROM Student WHERE Student_ID = @UserId AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Password", password);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    if (result.ToString() == "Pending")
                    {
                        MessageBox.Show("Your account is not approved yet. Please contact the admin for further assistance. Thank you!");
                    }
                    else
                    {
                        Student studentPage = new Student(userId);                       
                        studentPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    query = "SELECT Status FROM Teacher WHERE Teacher_ID = @UserId AND Password = @Password";
                    cmd.CommandText = query;
                    result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        if (result.ToString() == "Pending")
                        {
                            MessageBox.Show("Your account is not approved yet. Please contact the admin for further assistance. Thank you!");
                        }
                        else
                        {
                            Teacher teacherPage = new Teacher(userId);
                            teacherPage.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        query = "SELECT Status FROM Admin WHERE Admin_ID = @UserId AND Password = @Password";
                        cmd.CommandText = query;
                        result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            if (result.ToString() == "Pending")
                            {
                                MessageBox.Show("Your account is not approved yet. Please contact the admin for further assistance. Thank you!");
                            }
                            else
                            {
                                Admin adminPage = new Admin(userId);
                                adminPage.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID or Password.");
                        }
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
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = !showPass.Checked;
        }

        private void btn_AboutMe_Click(object sender, EventArgs e)
        {
            AboutMe a = new AboutMe();
            a.Show();
            this.Hide();
        }
    }
}

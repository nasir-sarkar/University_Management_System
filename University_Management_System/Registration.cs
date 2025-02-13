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
    public partial class Registration : Form
    {
        private SqlConnection connect;

        public Registration()
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            checkBox_St.CheckedChanged += (s, e) => { if (checkBox_St.Checked) checkBox_Tch.Checked = false; };
            checkBox_Tch.CheckedChanged += (s, e) => { if (checkBox_Tch.Checked) checkBox_St.Checked = false; };

            checkBox_male.CheckedChanged += (s, e) => { if (checkBox_male.Checked) checkBox_female.Checked = false; };
            checkBox_female.CheckedChanged += (s, e) => { if (checkBox_female.Checked) checkBox_male.Checked = false; };

            showPass.CheckedChanged += (s, e) => { textBox_pass.UseSystemPasswordChar = !showPass.Checked; };
            showCpass.CheckedChanged += (s, e) => { textBox_cpass.UseSystemPasswordChar = !showCpass.Checked; };

            textBox_pass.UseSystemPasswordChar = true;
            textBox_cpass.UseSystemPasswordChar = true;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text.Trim();
            string name = textBox_name.Text.Trim();
            string email = textBox_email.Text.Trim();
            string password = textBox_pass.Text;
            string confirmPassword = textBox_cpass.Text;
            DateTime dob = dateTime_dob.Value;
            string gender = checkBox_male.Checked ? "Male" : checkBox_female.Checked ? "Female" : "";
            string status = "Pending";

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(gender) ||
                (!checkBox_St.Checked && !checkBox_Tch.Checked))
            {
                MessageBox.Show("All fields are required. Please fill up all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (id.Length != 5 || !Regex.IsMatch(id, @"^\d{5}$"))
            {
                MessageBox.Show("ID must be exactly 5 digits long and contain only numbers.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Now.Year - dob.Year;
            if (dob > DateTime.Now.AddYears(-age)) age--;
            if (age < 15)
            {
                MessageBox.Show("Oops! It looks like you're under 15. Please double-check your date of birth and enter the correct one.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connect.Open();
                string checkQuery = "SELECT COUNT(*) FROM Student WHERE Student_ID = @ID UNION ALL SELECT COUNT(*) FROM Teacher WHERE Teacher_ID = @ID";
                using (SqlCommand cmd = new SqlCommand(checkQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("This ID already exists in either Student or Teacher records. Please choose a different ID.", "ID Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query;

                if (checkBox_St.Checked)
                {
                    query = "SET IDENTITY_INSERT Student ON; " +
                            "INSERT INTO Student (Student_ID, Name, Email, Password, DOB, Gender, Status) VALUES (@ID, @Name, @Email, @Password, @DOB, @Gender, @Status); " +
                            "SET IDENTITY_INSERT Student OFF;";
                }
                else
                {
                    query = "SET IDENTITY_INSERT Teacher ON; " +
                            "INSERT INTO Teacher (Teacher_ID, Name, Email, Password, DOB, Gender, Status) VALUES (@ID, @Name, @Email, @Password, @DOB, @Gender, @Status); " +
                            "SET IDENTITY_INSERT Teacher OFF;";
                }

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful! Your registration is under review. You will be able to log in once an admin approves your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ClearFields();
                    
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_email.Clear();
            textBox_pass.Clear();
            textBox_cpass.Clear();
            dateTime_dob.Value = DateTime.Now;
            checkBox_St.Checked = false;
            checkBox_Tch.Checked = false;
            checkBox_male.Checked = false;
            checkBox_female.Checked = false;
            showPass.Checked = false;
            showCpass.Checked = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

       
    }
}

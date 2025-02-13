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
    public partial class MaintainUser : Form
    {
        private SqlConnection connect;
        private string loggedinAid;
        public MaintainUser(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());
     
            loggedinAid = getID;

            textBox_pass.UseSystemPasswordChar = true;
            textBox_Cpass.UseSystemPasswordChar = true;
            textBox_Apass.UseSystemPasswordChar = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(loggedinAid);
            a.Show();
            this.Hide();
        }


        private void checkBox_Std_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Std.Checked)
            {
                checkBox_Tch.Checked = false;
                checkBox_Admn.Checked = false;
            }
        }

        private void checkBox_Tch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Tch.Checked)
            {
                checkBox_Std.Checked = false;
                checkBox_Admn.Checked = false;
            }
        }

        private void checkBox_Admn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Admn.Checked)
            {
                checkBox_Std.Checked = false;
                checkBox_Tch.Checked = false;
            }
        }

        private void checkBox_male_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_male.Checked)
            {
                checkBox_female.Checked = false;
            }
        }

        private void checkBox_female_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_female.Checked)
            {
                checkBox_male.Checked = false;
            }
        }


        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = !showPass.Checked;
        }

        private void showCpass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Cpass.UseSystemPasswordChar = !showCpass.Checked;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text.Trim();
            string name = textBox_name.Text.Trim();
            string email = textBox_email.Text.Trim();
            string password = textBox_pass.Text;
            string confirmPassword = textBox_Cpass.Text;
            string gender = checkBox_male.Checked ? "Male" : (checkBox_female.Checked ? "Female" : "");
            DateTime dob = dateTime_dob.Value;
            int age = DateTime.Now.Year - dob.Year;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(gender) ||
                (!checkBox_Std.Checked && !checkBox_Tch.Checked && !checkBox_Admn.Checked))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id.Length != 5 || !Regex.IsMatch(id, @"^\d{5}$"))
            {
                MessageBox.Show("ID must be exactly 5 digits long and contain only numbers.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (age < 15)
            {
                MessageBox.Show("User must be at least 15 years old!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string checkQuery = @"
                SELECT COUNT(*) FROM Student WHERE Student_ID = @id
                UNION ALL
                SELECT COUNT(*) FROM Teacher WHERE Teacher_ID = @id
                UNION ALL
                SELECT COUNT(*) FROM Admin WHERE Admin_ID = @id";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0) > 0)
                            {
                                MessageBox.Show("The ID already exists in another table! Please use a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                string tableName = "";
                string identityColumn = "";

                if (checkBox_Std.Checked)
                {
                    tableName = "Student";
                    identityColumn = "Student_ID";
                }
                else if (checkBox_Tch.Checked)
                {
                    tableName = "Teacher";
                    identityColumn = "Teacher_ID";
                }
                else if (checkBox_Admn.Checked)
                {
                    tableName = "Admin";
                    identityColumn = "Admin_ID";
                }

                string enableIdentityInsert = $"SET IDENTITY_INSERT {tableName} ON";
                using (SqlCommand enableCmd = new SqlCommand(enableIdentityInsert, connect))
                {
                    enableCmd.ExecuteNonQuery();
                }

                string insertQuery = $"INSERT INTO {tableName} ({identityColumn}, Name, Email, Password, DOB, Gender, Status) VALUES (@id, @name, @email, @password, @dob, @gender, @status)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@status", tableName);

                    cmd.ExecuteNonQuery();
                }

                string disableIdentityInsert = $"SET IDENTITY_INSERT {tableName} OFF";
                using (SqlCommand disableCmd = new SqlCommand(disableIdentityInsert, connect))
                {
                    disableCmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_cancel1_Click(sender, e);
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


        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_name.Clear();
            textBox_email.Clear();
            textBox_pass.Clear();
            textBox_Cpass.Clear();
            checkBox_Std.Checked = false;
            checkBox_Tch.Checked = false;
            checkBox_Admn.Checked = false;
            checkBox_male.Checked = false;
            checkBox_female.Checked = false;
            dateTime_dob.Value = DateTime.Today;
        }

        private void textBox_Uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Apass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Apass.UseSystemPasswordChar = !checkBox_showPass.Checked;
        }

        private void checkBox_Std2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Std2.Checked)
            {
                checkBox_Tch2.Checked = false;
                checkBox_Adm.Checked = false;
            }
        }

        private void checkBox_Tch2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Tch2.Checked)
            {
                checkBox_Std2.Checked = false;
                checkBox_Adm.Checked = false;
            }
        }

        private void checkBox_Adm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Adm.Checked)
            {
                checkBox_Std2.Checked = false;
                checkBox_Tch2.Checked = false;
            }
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            string userId = textBox_Uid.Text.Trim();
            string adminPass = textBox_Apass.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(adminPass) ||
                (!checkBox_Std2.Checked && !checkBox_Tch2.Checked && !checkBox_Adm.Checked))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string checkPassQuery = "SELECT COUNT(*) FROM Admin WHERE Admin_ID = @loggedinAid AND Password = @adminPass";
                using (SqlCommand passCmd = new SqlCommand(checkPassQuery, connect))
                {
                    passCmd.Parameters.AddWithValue("@loggedinAid", loggedinAid);
                    passCmd.Parameters.AddWithValue("@adminPass", adminPass);
                    int passCount = (int)passCmd.ExecuteScalar();
                    if (passCount == 0)
                    {
                        MessageBox.Show("Incorrect Admin Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string tableName = "";
                string identityColumn = "";

                if (checkBox_Std2.Checked)
                {
                    tableName = "Student";
                    identityColumn = "Student_ID";
                }
                else if (checkBox_Tch2.Checked)
                {
                    tableName = "Teacher";
                    identityColumn = "Teacher_ID";
                }
                else if (checkBox_Adm.Checked)
                {
                    tableName = "Admin";
                    identityColumn = "Admin_ID";
                }

                string checkUserQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {identityColumn} = @userId";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@userId", userId);
                    int userCount = (int)checkCmd.ExecuteScalar();
                    if (userCount == 0)
                    {
                        MessageBox.Show("User ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }



                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }


                string deleteQuery = $"DELETE FROM {tableName} WHERE {identityColumn} = @userId";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect))
                {
                    deleteCmd.Parameters.AddWithValue("@userId", userId);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_cancel2_Click(sender, e);
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

        private void btn_cancel2_Click(object sender, EventArgs e)
        {
            checkBox_Std2.Checked = false;
            checkBox_Tch2.Checked = false;
            checkBox_Adm.Checked = false;
            textBox_Uid.Clear();
            textBox_Apass.Clear();
        }
    }
}

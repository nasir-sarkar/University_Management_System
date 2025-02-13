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
    public partial class PasswordStudent : Form
    {
        private SqlConnection connect;

        private string loggedinSid;
        public PasswordStudent(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinSid = getID;

            textBox_NewPass.UseSystemPasswordChar = true;
            textBox_CNewPass.UseSystemPasswordChar = true;
            textBox_OldPass.UseSystemPasswordChar = true;
            showPass.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            bool show = showPass.Checked;
            textBox_NewPass.UseSystemPasswordChar = !show;
            textBox_CNewPass.UseSystemPasswordChar = !show;
            textBox_OldPass.UseSystemPasswordChar = !show;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string oldPass = textBox_OldPass.Text;
            string newPass = textBox_NewPass.Text;
            string confirmPass = textBox_CNewPass.Text;

            if (string.IsNullOrWhiteSpace(oldPass) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string query = "SELECT Password FROM Student WHERE Student_ID = @sid";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@sid", loggedinSid);
                object result = cmd.ExecuteScalar();

                if (result != null && result.ToString() == oldPass)
                {
                    string updateQuery = "UPDATE Student SET Password = @newPass WHERE Student_ID = @sid";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connect);
                    updateCmd.Parameters.AddWithValue("@newPass", newPass);
                    updateCmd.Parameters.AddWithValue("@sid", loggedinSid);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_OldPass.Clear();
            textBox_NewPass.Clear();
            textBox_CNewPass.Clear();
            showPass.Checked = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Student a = new Student(loggedinSid);
            a.Show();
            this.Hide();
        }
    }
}

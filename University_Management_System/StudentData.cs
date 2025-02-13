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
    public partial class StudentData : Form
    {
        private SqlConnection connect;
        private string loggedinSid;

        public StudentData(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinSid = getSid;
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Student a = new Student(loggedinSid);
            a.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Fath.Text) ||
                string.IsNullOrWhiteSpace(textBox_Moth.Text) ||
                string.IsNullOrWhiteSpace(textBox_Cont.Text) ||
                string.IsNullOrWhiteSpace(textBox_Prog.Text) ||
                string.IsNullOrWhiteSpace(textBox_Bld.Text) ||
                string.IsNullOrWhiteSpace(textBox_Adrs.Text) ||
                string.IsNullOrWhiteSpace(textBox_Nat.Text))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string checkQuery = "SELECT COUNT(*) FROM Student WHERE Student_ID = @StudentID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connect);
                checkCmd.Parameters.AddWithValue("@StudentID", loggedinSid);
                int exists = (int)checkCmd.ExecuteScalar();

                string query;

                if (exists > 0)
                {
                    query = @"UPDATE Student 
                      SET Father = @Father, Mother = @Mother, Contact = @Contact, 
                          Program = @Program, Blood = @Blood, Address = @Address, 
                          Nationality = @Nationality 
                      WHERE Student_ID = @StudentID";
                }
                else
                {
                    query = @"INSERT INTO Student (Student_ID, Father, Mother, Contact, Program, Blood, Address, Nationality) 
                      VALUES (@StudentID, @Father, @Mother, @Contact, @Program, @Blood, @Address, @Nationality)";
                }

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@StudentID", loggedinSid);
                cmd.Parameters.AddWithValue("@Father", textBox_Fath.Text);
                cmd.Parameters.AddWithValue("@Mother", textBox_Moth.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox_Cont.Text);
                cmd.Parameters.AddWithValue("@Program", textBox_Prog.Text);
                cmd.Parameters.AddWithValue("@Blood", textBox_Bld.Text);
                cmd.Parameters.AddWithValue("@Address", textBox_Adrs.Text);
                cmd.Parameters.AddWithValue("@Nationality", textBox_Nat.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Information updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);            
                btn_cancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_Fath.Text = string.Empty;
            textBox_Moth.Text = string.Empty;
            textBox_Cont.Text = string.Empty;
            textBox_Prog.Text = string.Empty;
            textBox_Bld.Text = string.Empty;
            textBox_Adrs.Text = string.Empty;
            textBox_Nat.Text = string.Empty;
        }
    }
}

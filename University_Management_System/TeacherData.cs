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
    public partial class TeacherData : Form
    {
        private SqlConnection connect;
        private string loggedinTid;

        public TeacherData(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinTid = getSid;
        }

        private void textBox_Dept_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Fath.Text) ||
                string.IsNullOrWhiteSpace(textBox_Moth.Text) ||
                string.IsNullOrWhiteSpace(textBox_Cont.Text) ||
                string.IsNullOrWhiteSpace(textBox_Dept.Text) ||
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

                string checkQuery = "SELECT COUNT(*) FROM Teacher WHERE Teacher_ID = @TeacherID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connect);
                checkCmd.Parameters.AddWithValue("@TeacherID", loggedinTid);
                int exists = (int)checkCmd.ExecuteScalar();

                string query;

                if (exists > 0)
                {
                    query = @"UPDATE Teacher 
                      SET Father = @Father, Mother = @Mother, Contact = @Contact, 
                          Department = @Department, Blood = @Blood, Address = @Address, 
                          Nationality = @Nationality 
                      WHERE Teacher_ID = @TeacherID";
                }
                else
                {
                    query = @"INSERT INTO Teacher (Teacher_ID, Father, Mother, Contact, Department, Blood, Address, Nationality) 
                      VALUES (@TeacherID, @Father, @Mother, @Contact, @Department, @Blood, @Address, @Nationality)";
                }

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@TeacherID", loggedinTid);
                cmd.Parameters.AddWithValue("@Father", textBox_Fath.Text);
                cmd.Parameters.AddWithValue("@Mother", textBox_Moth.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox_Cont.Text);
                cmd.Parameters.AddWithValue("@Department", textBox_Dept.Text);
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
            textBox_Dept.Text = string.Empty;
            textBox_Bld.Text = string.Empty;
            textBox_Adrs.Text = string.Empty;
            textBox_Nat.Text = string.Empty;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Teacher a = new Teacher(loggedinTid);
            a.Show();
            this.Hide();
        }
    }
}

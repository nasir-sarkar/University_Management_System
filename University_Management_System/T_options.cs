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
    public partial class T_options : Form
    {
        private SqlConnection connect;
        private string loggedinTid;

        public T_options(string getSid)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinTid = getSid;
        }

        private bool IsTeacherInfoComplete()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string query = "SELECT Department, Blood, Father, Mother, Contact, Address, Nationality FROM Teacher WHERE Teacher_ID = @Teacher_ID";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Teacher_ID", loggedinTid);
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

        private void label_updateInfo_Click(object sender, EventArgs e)
        {
            TeacherData a = new TeacherData(loggedinTid);
            a.Show();
            this.Hide();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Teacher a = new Teacher(loggedinTid);
            a.Show();
            this.Hide();
        }

        private void label_publishRes_Click(object sender, EventArgs e)
        {
            if (!IsTeacherInfoComplete())
            {
                MessageBox.Show("Please, update your information to access other facilities.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UploadResult a = new UploadResult(loggedinTid);
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void T_options_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!IsTeacherInfoComplete())
            {
                MessageBox.Show("Please update your information to access other facilities.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PasswordTeacher a = new PasswordTeacher(loggedinTid);
            a.Show();
            this.Hide();
        }
    }
}

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
    public partial class Admin : Form
    {    
        private SqlConnection connect;
        private string loggedinAid;
        private A_options z;

        public Admin(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinAid = getID;

            z = new A_options(loggedinAid);
            z.StartPosition = FormStartPosition.Manual;    
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Srequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Trequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet15.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter3.Fill(this.universityDataSet15.Student);
            // TODO: This line of code loads data into the 'universityDataSet14.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter2.Fill(this.universityDataSet14.Student);
            LoadPendingStudents();
            LoadPendingTeachers();

            LoadStudents();
            LoadTeachers();
        }

        private void LoadPendingStudents()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Student WHERE Status = 'Pending'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show("Student Name: " + row.Cells["Name"].Value.ToString());
            }
        }


        private void LoadPendingTeachers()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Teacher WHERE Status = 'Pending'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
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


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                MessageBox.Show("Teacher Name: " + row.Cells["Name"].Value.ToString());
            }
        }


        private void LoadStudents()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Student WHERE Status = 'Student'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView_St.DataSource = dataTable;
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

        private void dataGridView_St_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_St.Rows[e.RowIndex];
                MessageBox.Show("Student Name: " + row.Cells["Name"].Value.ToString());
            }
        }


        private void LoadTeachers()
        {
            try
            {
                connect.Open();
                string query = "SELECT * FROM Teacher WHERE Status = 'Teacher'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView_Tch.DataSource = dataTable;
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

        private void dataGridView_Tch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_Tch.Rows[e.RowIndex];
            MessageBox.Show("Teacher Name: " + row.Cells["Name"].Value.ToString());
        }

        private void textBox_Sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sApprove_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string studentId = textBox_Sid.Text;

                string checkQuery = "SELECT Status FROM Student WHERE Student_ID = @Student_ID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connect);
                checkCommand.Parameters.AddWithValue("@Student_ID", studentId);
                object statusResult = checkCommand.ExecuteScalar();

                if (statusResult != null && statusResult.ToString() == "Student")
                {
                    MessageBox.Show("This student is already approved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "UPDATE Student SET Status = 'Student' WHERE Student_ID = @Student_ID";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Student_ID", studentId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_Sid.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

            LoadPendingStudents();
            LoadStudents();
        }

        private void textBox_Tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_tApprove_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string teacherId = textBox_Tid.Text;

                string checkQuery = "SELECT Status FROM Teacher WHERE Teacher_ID = @Teacher_ID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connect);
                checkCommand.Parameters.AddWithValue("@Teacher_ID", teacherId);
                object statusResult = checkCommand.ExecuteScalar();

                if (statusResult != null && statusResult.ToString() == "Teacher")
                {
                    MessageBox.Show("This teacher is already approved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "UPDATE Teacher SET Status = 'Teacher' WHERE Teacher_ID = @Teacher_ID";
                    SqlCommand command = new SqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Teacher_ID", teacherId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_Tid.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

            LoadPendingTeachers();
            LoadTeachers();
        }

        private void textBox_stid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_srchS_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string studentId = textBox_stid.Text;
                string query = "SELECT * FROM Student WHERE Student_ID = @Student_ID";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@Student_ID", studentId);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    dataGridView_St.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Student not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_St.DataSource = null;
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

        private void textBox_tchid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_srchT_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string teacherId = textBox_tchid.Text;
                string query = "SELECT * FROM Teacher WHERE Teacher_ID = @Teacher_ID";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@Teacher_ID", teacherId);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView_Tch.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Teacher not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_Tch.DataSource = null;
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

        private void picBox_sRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void picBox_tRefresh_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void checkBox_std_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_std.Checked)
            {
                checkBox_tch.Checked = false;
            }
        }

        private void checkBox_tch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tch.Checked)
            {
                checkBox_std.Checked = false;
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_newData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!(checkBox_std.Checked || checkBox_tch.Checked) || string.IsNullOrWhiteSpace(textBox_id.Text) ||
                   comboBox_select.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox_newData.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tableName = checkBox_std.Checked ? "Student" : "Teacher";
            string idColumn = checkBox_std.Checked ? "Student_ID" : "Teacher_ID";
            string columnToUpdate = comboBox_select.SelectedItem.ToString();
            string newValue = textBox_newData.Text;
            string idValue = textBox_id.Text;

            
            if (idValue.Length != 5)
            {
                MessageBox.Show("ID must be exactly 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (columnToUpdate.Equals("DOB", StringComparison.OrdinalIgnoreCase))
            {
                if (!DateTime.TryParseExact(newValue, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show("DOB should be in YYYY-MM-DD format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

           
            if (columnToUpdate.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(newValue);
                    if (addr.Address != newValue)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

          
            if (columnToUpdate.Equals("Password", StringComparison.OrdinalIgnoreCase) && newValue.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (columnToUpdate.Equals("Salary", StringComparison.OrdinalIgnoreCase) && checkBox_std.Checked)
            {
                MessageBox.Show("Students do not have a Salary field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (columnToUpdate.Equals("Department", StringComparison.OrdinalIgnoreCase) && checkBox_std.Checked)
            {
                MessageBox.Show("Students do not have a Department field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (columnToUpdate.Equals("Program", StringComparison.OrdinalIgnoreCase) && checkBox_tch.Checked)
            {
                MessageBox.Show("Teachers do not have a Program field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                connect.Open();
                string verifyIDQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumn} = @ID";
                SqlCommand verifyIDCommand = new SqlCommand(verifyIDQuery, connect);
                verifyIDCommand.Parameters.AddWithValue("@ID", idValue);
                int idExists = (int)verifyIDCommand.ExecuteScalar();

                if (idExists == 0)
                {
                    MessageBox.Show($"{(checkBox_std.Checked ? "Student" : "Teacher")} with this ID does not exist.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {idColumn} = @ID";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connect);
                checkCommand.Parameters.AddWithValue("@ID", idValue);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = $"UPDATE {tableName} SET {columnToUpdate} = @NewValue WHERE {idColumn} = @ID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connect);
                    updateCommand.Parameters.AddWithValue("@NewValue", newValue);
                    updateCommand.Parameters.AddWithValue("@ID", idValue);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Update successful." : "No record found to update.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancel_Click(sender, e);
                }
                else
                {
                    string insertQuery = $"INSERT INTO {tableName} ({idColumn}, {columnToUpdate}) VALUES (@ID, @NewValue)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connect);
                    insertCommand.Parameters.AddWithValue("@ID", idValue);
                    insertCommand.Parameters.AddWithValue("@NewValue", newValue);

                    int rowsInserted = insertCommand.ExecuteNonQuery();
                    MessageBox.Show(rowsInserted > 0 ? "New record added successfully." : "Failed to add record.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_cancel_Click(sender, e);
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

            LoadStudents();
            LoadTeachers();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            comboBox_select.SelectedIndex = -1;
            textBox_newData.Clear();
            checkBox_std.Checked = false;
            checkBox_tch.Checked = false;
        }
    }
}

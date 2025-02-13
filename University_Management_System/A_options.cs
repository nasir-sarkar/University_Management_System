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
    public partial class A_options : Form
    {
        private SqlConnection connect;
        private string loggedinAid;
        public A_options(string getID)
        {
            InitializeComponent();

            DataAccess dataAccess = new DataAccess();
            connect = new SqlConnection(dataAccess.GetConnectionString());

            loggedinAid = getID;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(loggedinAid);
            a.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MaintainUser a = new MaintainUser(loggedinAid);
            a.Show();
            this.Hide();
        }

        private void label_addCourse_Click(object sender, EventArgs e)
        {
            AddCourse a = new AddCourse(loggedinAid);
            a.Show();
            this.Hide();
        }

        private void label_enrollSt_Click(object sender, EventArgs e)
        {
            EnrollStudent a = new EnrollStudent(loggedinAid);
            a.Show();
            this.Hide();
        }

        private void label_enrollTch_Click(object sender, EventArgs e)
        {
            EnrollTeacher a = new EnrollTeacher(loggedinAid);
            a.Show();
            this.Hide();
        }
    }
}

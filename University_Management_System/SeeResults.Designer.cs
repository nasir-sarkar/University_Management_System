
namespace University_Management_System
{
    partial class SeeResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeeResults));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Sem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_see = new System.Windows.Forms.Button();
            this.lbl_getID = new System.Windows.Forms.Label();
            this.lbl_getName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_getCgpa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet9 = new University_Management_System.UniversityDataSet9();
            this.picBox_Refresh = new System.Windows.Forms.PictureBox();
            this.lbl_getCredit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollmentTableAdapter = new University_Management_System.UniversityDataSet9TableAdapters.EnrollmentTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 75);
            this.panel1.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(993, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 38);
            this.btn_back.TabIndex = 114;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(93, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 34);
            this.label8.TabIndex = 34;
            this.label8.Text = "University Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 15);
            this.panel2.TabIndex = 5;
            // 
            // textBox_Sem
            // 
            this.textBox_Sem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem.Location = new System.Drawing.Point(495, 131);
            this.textBox_Sem.Name = "textBox_Sem";
            this.textBox_Sem.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sem.TabIndex = 100;
            this.textBox_Sem.TextChanged += new System.EventHandler(this.textBox_Sem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(491, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 99;
            this.label5.Text = "Semester:";
            // 
            // btn_see
            // 
            this.btn_see.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_see.ForeColor = System.Drawing.Color.White;
            this.btn_see.Location = new System.Drawing.Point(723, 131);
            this.btn_see.Name = "btn_see";
            this.btn_see.Size = new System.Drawing.Size(116, 30);
            this.btn_see.TabIndex = 101;
            this.btn_see.Text = "See";
            this.btn_see.UseVisualStyleBackColor = false;
            this.btn_see.Click += new System.EventHandler(this.btn_see_Click);
            // 
            // lbl_getID
            // 
            this.lbl_getID.AutoSize = true;
            this.lbl_getID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getID.Location = new System.Drawing.Point(75, 233);
            this.lbl_getID.Name = "lbl_getID";
            this.lbl_getID.Size = new System.Drawing.Size(249, 23);
            this.lbl_getID.TabIndex = 105;
            this.lbl_getID.Text = "get_info_from_database";
            // 
            // lbl_getName
            // 
            this.lbl_getName.AutoSize = true;
            this.lbl_getName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getName.Location = new System.Drawing.Point(115, 197);
            this.lbl_getName.Name = "lbl_getName";
            this.lbl_getName.Size = new System.Drawing.Size(249, 23);
            this.lbl_getName.TabIndex = 104;
            this.lbl_getName.Text = "get_info_from_database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 103;
            this.label12.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 102;
            this.label3.Text = "ID:";
            // 
            // lbl_getCgpa
            // 
            this.lbl_getCgpa.AutoSize = true;
            this.lbl_getCgpa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getCgpa.Location = new System.Drawing.Point(115, 269);
            this.lbl_getCgpa.Name = "lbl_getCgpa";
            this.lbl_getCgpa.Size = new System.Drawing.Size(249, 23);
            this.lbl_getCgpa.TabIndex = 107;
            this.lbl_getCgpa.Text = "get_info_from_database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "CGPA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enrollmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(495, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 437);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.universityDataSet9;
            // 
            // universityDataSet9
            // 
            this.universityDataSet9.DataSetName = "UniversityDataSet9";
            this.universityDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picBox_Refresh
            // 
            this.picBox_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Refresh.Image")));
            this.picBox_Refresh.Location = new System.Drawing.Point(1041, 131);
            this.picBox_Refresh.Name = "picBox_Refresh";
            this.picBox_Refresh.Size = new System.Drawing.Size(49, 30);
            this.picBox_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Refresh.TabIndex = 109;
            this.picBox_Refresh.TabStop = false;
            this.picBox_Refresh.Click += new System.EventHandler(this.picBox_Refresh_Click);
            // 
            // lbl_getCredit
            // 
            this.lbl_getCredit.AutoSize = true;
            this.lbl_getCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getCredit.Location = new System.Drawing.Point(231, 305);
            this.lbl_getCredit.Name = "lbl_getCredit";
            this.lbl_getCredit.Size = new System.Drawing.Size(249, 23);
            this.lbl_getCredit.TabIndex = 111;
            this.lbl_getCredit.Text = "get_info_from_database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 23);
            this.label6.TabIndex = 110;
            this.label6.Text = "Credit completed:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 49);
            this.label1.TabIndex = 112;
            this.label1.Text = "Results";
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 34);
            this.label4.TabIndex = 114;
            this.label4.Text = "Grading System";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 416);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(391, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 115;
            this.pictureBox3.TabStop = false;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 160;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 60;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 60;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // SeeResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_getCredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picBox_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_getCgpa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_getID);
            this.Controls.Add(this.lbl_getName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_see);
            this.Controls.Add(this.textBox_Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeeResults";
            this.Load += new System.EventHandler(this.SeeResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Sem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_see;
        private System.Windows.Forms.Label lbl_getID;
        private System.Windows.Forms.Label lbl_getName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_getCgpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picBox_Refresh;
        private System.Windows.Forms.Label lbl_getCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private UniversityDataSet9 universityDataSet9;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSet9TableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
    }
}

namespace University_Management_System
{
    partial class UploadResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadResult));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet10 = new University_Management_System.UniversityDataSet10();
            this.textBox_Sem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Sid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.textBox_Sec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Refresh = new System.Windows.Forms.PictureBox();
            this.btn_see = new System.Windows.Forms.Button();
            this.textBoxSem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Marks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enrollmentTableAdapter = new University_Management_System.UniversityDataSet10TableAdapters.EnrollmentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Refresh)).BeginInit();
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
            this.panel1.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(992, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 38);
            this.btn_back.TabIndex = 122;
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
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 15);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enrollmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 437);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.Width = 60;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.universityDataSet10;
            // 
            // universityDataSet10
            // 
            this.universityDataSet10.DataSetName = "UniversityDataSet10";
            this.universityDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_Sem
            // 
            this.textBox_Sem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem.Location = new System.Drawing.Point(763, 427);
            this.textBox_Sem.Name = "textBox_Sem";
            this.textBox_Sem.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sem.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(759, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "Semester:";
            // 
            // textBox_Sid
            // 
            this.textBox_Sid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sid.Location = new System.Drawing.Point(763, 212);
            this.textBox_Sid.Name = "textBox_Sid";
            this.textBox_Sid.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sid.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 105;
            this.label3.Text = "Student\'s ID:";
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Items.AddRange(new object[] {
            "COMPILER DESIGN",
            "COMPUTER GRAPHICS",
            "DATA STRUCTURE",
            "DATA STRUCTURE LAB",
            "OPERATING SYSTEM",
            "SOFTWARE ENGINEERING",
            "WEB TECHNOLOGIES",
            "DATA COMMUNICATION",
            "ELECTRONIC DEVICES",
            "ELECTRONIC DEVICES LAB",
            "ENGINEERING ETHICS",
            "ENGINEERING MANAGEMENT\t",
            "MICROPROCESSOR",
            "BUSINESS COMMUNICATION",
            "ENGLISH READING SKILLS",
            "ENGLISH WRITING SKILLS",
            "PRINCIPLES OF ACCOUNTING",
            "PRINCIPLES OF ECONOMICS"});
            this.comboBox_Course.Location = new System.Drawing.Point(763, 284);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(222, 24);
            this.comboBox_Course.TabIndex = 104;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(763, 593);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(222, 38);
            this.btn_cancel.TabIndex = 100;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(763, 549);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(222, 38);
            this.btn_upload.TabIndex = 99;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // textBox_Sec
            // 
            this.textBox_Sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sec.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sec.Location = new System.Drawing.Point(763, 352);
            this.textBox_Sec.Name = "textBox_Sec";
            this.textBox_Sec.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sec.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(759, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Section:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 101;
            this.label1.Text = "Course title:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(792, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(866, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 52);
            this.label2.TabIndex = 114;
            this.label2.Text = "Upload\r\nResult";
            // 
            // picBox_Refresh
            // 
            this.picBox_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Refresh.Image")));
            this.picBox_Refresh.Location = new System.Drawing.Point(570, 139);
            this.picBox_Refresh.Name = "picBox_Refresh";
            this.picBox_Refresh.Size = new System.Drawing.Size(49, 30);
            this.picBox_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Refresh.TabIndex = 119;
            this.picBox_Refresh.TabStop = false;
            this.picBox_Refresh.Click += new System.EventHandler(this.picBox_Refresh_Click);
            // 
            // btn_see
            // 
            this.btn_see.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_see.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_see.ForeColor = System.Drawing.Color.White;
            this.btn_see.Location = new System.Drawing.Point(272, 139);
            this.btn_see.Name = "btn_see";
            this.btn_see.Size = new System.Drawing.Size(116, 30);
            this.btn_see.TabIndex = 118;
            this.btn_see.Text = "See";
            this.btn_see.UseVisualStyleBackColor = false;
            this.btn_see.Click += new System.EventHandler(this.btn_see_Click);
            // 
            // textBoxSem
            // 
            this.textBoxSem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSem.Location = new System.Drawing.Point(44, 139);
            this.textBoxSem.Name = "textBoxSem";
            this.textBoxSem.Size = new System.Drawing.Size(222, 30);
            this.textBoxSem.TabIndex = 117;
            this.textBoxSem.TextChanged += new System.EventHandler(this.textBoxSem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 116;
            this.label6.Text = "Semester:";
            // 
            // textBox_Marks
            // 
            this.textBox_Marks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Marks.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Marks.Location = new System.Drawing.Point(763, 505);
            this.textBox_Marks.Name = "textBox_Marks";
            this.textBox_Marks.Size = new System.Drawing.Size(222, 30);
            this.textBox_Marks.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 120;
            this.label7.Text = "Marks:";
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // UploadResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.textBox_Marks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picBox_Refresh);
            this.Controls.Add(this.btn_see);
            this.Controls.Add(this.textBoxSem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Sid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.textBox_Sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadResult";
            this.Load += new System.EventHandler(this.UploadResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Sem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Sid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox textBox_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Refresh;
        private System.Windows.Forms.Button btn_see;
        private System.Windows.Forms.TextBox textBoxSem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Marks;
        private System.Windows.Forms.Label label7;
        private UniversityDataSet10 universityDataSet10;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSet10TableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}
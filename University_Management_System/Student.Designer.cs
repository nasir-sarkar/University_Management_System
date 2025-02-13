namespace University_Management_System
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox_3lines = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_getName = new System.Windows.Forms.Label();
            this.lbl_getID = new System.Windows.Forms.Label();
            this.lbl_getDob = new System.Windows.Forms.Label();
            this.lbl_getGender = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet7 = new University_Management_System.UniversityDataSet7();
            this.lbl_getEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_getTitle = new System.Windows.Forms.Label();
            this.picBox_lout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enrollmentTableAdapter = new University_Management_System.UniversityDataSet7TableAdapters.EnrollmentTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_getCGPA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3lines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_lout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.picBox_3lines);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 75);
            this.panel1.TabIndex = 1;
            // 
            // picBox_3lines
            // 
            this.picBox_3lines.Image = ((System.Drawing.Image)(resources.GetObject("picBox_3lines.Image")));
            this.picBox_3lines.Location = new System.Drawing.Point(1062, 18);
            this.picBox_3lines.Name = "picBox_3lines";
            this.picBox_3lines.Size = new System.Drawing.Size(51, 42);
            this.picBox_3lines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_3lines.TabIndex = 35;
            this.picBox_3lines.TabStop = false;
            this.picBox_3lines.Click += new System.EventHandler(this.picBox_3lines_Click);
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
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student\'s\r\nRoutine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hello!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "DOB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(688, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gender:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(687, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Name:";
            // 
            // lbl_getName
            // 
            this.lbl_getName.AutoSize = true;
            this.lbl_getName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getName.Location = new System.Drawing.Point(769, 291);
            this.lbl_getName.Name = "lbl_getName";
            this.lbl_getName.Size = new System.Drawing.Size(249, 23);
            this.lbl_getName.TabIndex = 14;
            this.lbl_getName.Text = "get_info_from_database";
            this.lbl_getName.Click += new System.EventHandler(this.lbl_getName_Click);
            // 
            // lbl_getID
            // 
            this.lbl_getID.AutoSize = true;
            this.lbl_getID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getID.Location = new System.Drawing.Point(729, 327);
            this.lbl_getID.Name = "lbl_getID";
            this.lbl_getID.Size = new System.Drawing.Size(249, 23);
            this.lbl_getID.TabIndex = 15;
            this.lbl_getID.Text = "get_info_from_database";
            this.lbl_getID.Click += new System.EventHandler(this.lbl_getID_Click);
            // 
            // lbl_getDob
            // 
            this.lbl_getDob.AutoSize = true;
            this.lbl_getDob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getDob.Location = new System.Drawing.Point(752, 396);
            this.lbl_getDob.Name = "lbl_getDob";
            this.lbl_getDob.Size = new System.Drawing.Size(249, 23);
            this.lbl_getDob.TabIndex = 18;
            this.lbl_getDob.Text = "get_info_from_database";
            this.lbl_getDob.Click += new System.EventHandler(this.lbl_getDob_Click);
            // 
            // lbl_getGender
            // 
            this.lbl_getGender.AutoSize = true;
            this.lbl_getGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getGender.Location = new System.Drawing.Point(784, 467);
            this.lbl_getGender.Name = "lbl_getGender";
            this.lbl_getGender.Size = new System.Drawing.Size(249, 23);
            this.lbl_getGender.TabIndex = 20;
            this.lbl_getGender.Text = "get_info_from_database";
            this.lbl_getGender.Click += new System.EventHandler(this.lbl_getGender_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.Semester,
            this.teacherIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enrollmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 317);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.universityDataSet7;
            // 
            // universityDataSet7
            // 
            this.universityDataSet7.DataSetName = "UniversityDataSet7";
            this.universityDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_getEmail
            // 
            this.lbl_getEmail.AutoSize = true;
            this.lbl_getEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getEmail.Location = new System.Drawing.Point(760, 433);
            this.lbl_getEmail.Name = "lbl_getEmail";
            this.lbl_getEmail.Size = new System.Drawing.Size(249, 23);
            this.lbl_getEmail.TabIndex = 41;
            this.lbl_getEmail.Text = "get_info_from_database";
            this.lbl_getEmail.Click += new System.EventHandler(this.lbl_getEmail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(687, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email:";
            // 
            // lbl_getTitle
            // 
            this.lbl_getTitle.AutoSize = true;
            this.lbl_getTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getTitle.Location = new System.Drawing.Point(796, 228);
            this.lbl_getTitle.Name = "lbl_getTitle";
            this.lbl_getTitle.Size = new System.Drawing.Size(115, 39);
            this.lbl_getTitle.TabIndex = 42;
            this.lbl_getTitle.Text = "Name";
            this.lbl_getTitle.Click += new System.EventHandler(this.lbl_getTitle_Click);
            // 
            // picBox_lout
            // 
            this.picBox_lout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_lout.Image = ((System.Drawing.Image)(resources.GetObject("picBox_lout.Image")));
            this.picBox_lout.Location = new System.Drawing.Point(1062, 81);
            this.picBox_lout.Name = "picBox_lout";
            this.picBox_lout.Size = new System.Drawing.Size(51, 54);
            this.picBox_lout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_lout.TabIndex = 38;
            this.picBox_lout.TabStop = false;
            this.picBox_lout.Click += new System.EventHandler(this.picBox_lout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(966, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 55;
            this.label13.Text = "Logout";
            // 
            // lbl_getCGPA
            // 
            this.lbl_getCGPA.AutoSize = true;
            this.lbl_getCGPA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_getCGPA.Location = new System.Drawing.Point(768, 360);
            this.lbl_getCGPA.Name = "lbl_getCGPA";
            this.lbl_getCGPA.Size = new System.Drawing.Size(249, 23);
            this.lbl_getCGPA.TabIndex = 57;
            this.lbl_getCGPA.Text = "get_info_from_database";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(687, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "CGPA:";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 115;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 48;
            // 
            // startingTimeDataGridViewTextBoxColumn
            // 
            this.startingTimeDataGridViewTextBoxColumn.DataPropertyName = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.HeaderText = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingTimeDataGridViewTextBoxColumn.Name = "startingTimeDataGridViewTextBoxColumn";
            this.startingTimeDataGridViewTextBoxColumn.Width = 80;
            // 
            // endingTimeDataGridViewTextBoxColumn
            // 
            this.endingTimeDataGridViewTextBoxColumn.DataPropertyName = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.HeaderText = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endingTimeDataGridViewTextBoxColumn.Name = "endingTimeDataGridViewTextBoxColumn";
            this.endingTimeDataGridViewTextBoxColumn.Width = 80;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.Width = 60;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.lbl_getCGPA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_getTitle);
            this.Controls.Add(this.lbl_getEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBox_lout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_getGender);
            this.Controls.Add(this.lbl_getDob);
            this.Controls.Add(this.lbl_getID);
            this.Controls.Add(this.lbl_getName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_3lines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_lout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBox_3lines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_getName;
        private System.Windows.Forms.Label lbl_getID;
        private System.Windows.Forms.Label lbl_getDob;
        private System.Windows.Forms.Label lbl_getGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picBox_lout;
        private System.Windows.Forms.Label lbl_getEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_getTitle;
        private UniversityDataSet7 universityDataSet7;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSet7TableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_getCGPA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
    }
}
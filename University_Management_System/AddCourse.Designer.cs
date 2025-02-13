
namespace University_Management_System
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox_Etime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Stime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Days = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Sec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Cid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_semester = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_crdt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet11 = new University_Management_System.UniversityDataSet11();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet4 = new University_Management_System.UniversityDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.coursesTableAdapter = new University_Management_System.UniversityDataSet4TableAdapters.CoursesTableAdapter();
            this.coursesTableAdapter1 = new University_Management_System.UniversityDataSet11TableAdapters.CoursesTableAdapter();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBox_sRefresh = new System.Windows.Forms.PictureBox();
            this.btn_Srch1 = new System.Windows.Forms.Button();
            this.textBox_Sem1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(998, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 38);
            this.btn_back.TabIndex = 74;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(594, 553);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(235, 38);
            this.btn_add.TabIndex = 73;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox_Etime
            // 
            this.textBox_Etime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Etime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Etime.Location = new System.Drawing.Point(858, 401);
            this.textBox_Etime.Name = "textBox_Etime";
            this.textBox_Etime.Size = new System.Drawing.Size(222, 30);
            this.textBox_Etime.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(854, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "Ending time:";
            // 
            // textBox_Stime
            // 
            this.textBox_Stime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Stime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stime.Location = new System.Drawing.Point(858, 318);
            this.textBox_Stime.Name = "textBox_Stime";
            this.textBox_Stime.Size = new System.Drawing.Size(222, 30);
            this.textBox_Stime.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Starting time:";
            // 
            // textBox_Days
            // 
            this.textBox_Days.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Days.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Days.Location = new System.Drawing.Point(858, 237);
            this.textBox_Days.Name = "textBox_Days";
            this.textBox_Days.Size = new System.Drawing.Size(222, 30);
            this.textBox_Days.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(854, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "Days:";
            // 
            // textBox_Sec
            // 
            this.textBox_Sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sec.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sec.Location = new System.Drawing.Point(594, 401);
            this.textBox_Sec.Name = "textBox_Sec";
            this.textBox_Sec.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sec.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Section:";
            // 
            // textBox_Cid
            // 
            this.textBox_Cid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Cid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cid.Location = new System.Drawing.Point(594, 318);
            this.textBox_Cid.Name = "textBox_Cid";
            this.textBox_Cid.Size = new System.Drawing.Size(222, 30);
            this.textBox_Cid.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Course title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 15);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 75);
            this.panel1.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 11);
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
            this.label8.Location = new System.Drawing.Point(93, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 34);
            this.label8.TabIndex = 34;
            this.label8.Text = "University Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Course ID:";
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
            this.comboBox_Course.Location = new System.Drawing.Point(594, 240);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(222, 24);
            this.comboBox_Course.TabIndex = 75;
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(680, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 19);
            this.label9.TabIndex = 76;
            this.label9.Text = "Time must be entered in the 24-hour format.";
            // 
            // textBox_semester
            // 
            this.textBox_semester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_semester.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_semester.Location = new System.Drawing.Point(858, 487);
            this.textBox_semester.Name = "textBox_semester";
            this.textBox_semester.Size = new System.Drawing.Size(222, 30);
            this.textBox_semester.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(854, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 79;
            this.label10.Text = "Semester:";
            // 
            // textBox_crdt
            // 
            this.textBox_crdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_crdt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_crdt.Location = new System.Drawing.Point(594, 487);
            this.textBox_crdt.Name = "textBox_crdt";
            this.textBox_crdt.Size = new System.Drawing.Size(222, 30);
            this.textBox_crdt.TabIndex = 78;
            this.textBox_crdt.TextChanged += new System.EventHandler(this.textBox_crdt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(590, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 23);
            this.label11.TabIndex = 77;
            this.label11.Text = "Credit:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(845, 553);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(235, 38);
            this.btn_cancel.TabIndex = 81;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.Count,
            this.creditDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(523, 354);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.universityDataSet11;
            // 
            // universityDataSet11
            // 
            this.universityDataSet11.DataSetName = "UniversityDataSet11";
            this.universityDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.universityDataSet4;
            // 
            // universityDataSet4
            // 
            this.universityDataSet4.DataSetName = "UniversityDataSet4";
            this.universityDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(812, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 74);
            this.label2.TabIndex = 61;
            this.label2.Text = "Add\r\nCourse";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(182, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 74);
            this.label12.TabIndex = 83;
            this.label12.Text = "Availabe\r\nCourses";
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
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
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 50;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Width = 50;
            // 
            // startingTimeDataGridViewTextBoxColumn
            // 
            this.startingTimeDataGridViewTextBoxColumn.DataPropertyName = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.HeaderText = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingTimeDataGridViewTextBoxColumn.Name = "startingTimeDataGridViewTextBoxColumn";
            this.startingTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // endingTimeDataGridViewTextBoxColumn
            // 
            this.endingTimeDataGridViewTextBoxColumn.DataPropertyName = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.HeaderText = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endingTimeDataGridViewTextBoxColumn.Name = "endingTimeDataGridViewTextBoxColumn";
            this.endingTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 110;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.Width = 80;
            // 
            // picBox_sRefresh
            // 
            this.picBox_sRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_sRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picBox_sRefresh.Image")));
            this.picBox_sRefresh.Location = new System.Drawing.Point(460, 198);
            this.picBox_sRefresh.Name = "picBox_sRefresh";
            this.picBox_sRefresh.Size = new System.Drawing.Size(32, 33);
            this.picBox_sRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_sRefresh.TabIndex = 113;
            this.picBox_sRefresh.TabStop = false;
            this.picBox_sRefresh.Click += new System.EventHandler(this.picBox_sRefresh_Click);
            // 
            // btn_Srch1
            // 
            this.btn_Srch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Srch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Srch1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Srch1.ForeColor = System.Drawing.Color.White;
            this.btn_Srch1.Location = new System.Drawing.Point(266, 196);
            this.btn_Srch1.Name = "btn_Srch1";
            this.btn_Srch1.Size = new System.Drawing.Size(188, 35);
            this.btn_Srch1.TabIndex = 112;
            this.btn_Srch1.Text = "Search Semester";
            this.btn_Srch1.UseVisualStyleBackColor = false;
            this.btn_Srch1.Click += new System.EventHandler(this.btn_Srch1_Click);
            // 
            // textBox_Sem1
            // 
            this.textBox_Sem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem1.Location = new System.Drawing.Point(72, 198);
            this.textBox_Sem1.Name = "textBox_Sem1";
            this.textBox_Sem1.Size = new System.Drawing.Size(188, 30);
            this.textBox_Sem1.TabIndex = 111;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.picBox_sRefresh);
            this.Controls.Add(this.btn_Srch1);
            this.Controls.Add(this.textBox_Sem1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.textBox_semester);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_crdt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox_Etime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Stime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Cid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBox_Etime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Stime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Days;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Cid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_semester;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_crdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private UniversityDataSet4 universityDataSet4;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private UniversityDataSet4TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private UniversityDataSet11 universityDataSet11;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private UniversityDataSet11TableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picBox_sRefresh;
        private System.Windows.Forms.Button btn_Srch1;
        private System.Windows.Forms.TextBox textBox_Sem1;
    }
}
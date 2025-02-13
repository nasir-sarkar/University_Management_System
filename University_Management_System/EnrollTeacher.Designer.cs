
namespace University_Management_System
{
    partial class EnrollTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollTeacher));
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.textBox_Sec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_Tid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Sem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet6 = new University_Management_System.UniversityDataSet6();
            this.enrollmentTableAdapter = new University_Management_System.UniversityDataSet6TableAdapters.EnrollmentTableAdapter();
            this.btn_Srch2 = new System.Windows.Forms.Button();
            this.textBox_Sem2 = new System.Windows.Forms.TextBox();
            this.btn_Srch1 = new System.Windows.Forms.Button();
            this.textBox_Sem1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet13 = new University_Management_System.UniversityDataSet13();
            this.label12 = new System.Windows.Forms.Label();
            this.coursesTableAdapter = new University_Management_System.UniversityDataSet13TableAdapters.CoursesTableAdapter();
            this.picBox_sRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.comboBox_Course.Location = new System.Drawing.Point(764, 328);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(222, 24);
            this.comboBox_Course.TabIndex = 106;
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(764, 563);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(222, 38);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_enroll
            // 
            this.btn_enroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enroll.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enroll.ForeColor = System.Drawing.Color.White;
            this.btn_enroll.Location = new System.Drawing.Point(764, 519);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(222, 38);
            this.btn_enroll.TabIndex = 0;
            this.btn_enroll.Text = "Enroll";
            this.btn_enroll.UseVisualStyleBackColor = false;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // textBox_Sec
            // 
            this.textBox_Sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sec.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sec.Location = new System.Drawing.Point(764, 393);
            this.textBox_Sec.Name = "textBox_Sec";
            this.textBox_Sec.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sec.TabIndex = 103;
            this.textBox_Sec.TextChanged += new System.EventHandler(this.textBox_Sec_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(760, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 102;
            this.label4.Text = "Section:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(775, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 74);
            this.label2.TabIndex = 100;
            this.label2.Text = "Enroll\r\nTeacher\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Course title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 15);
            this.panel2.TabIndex = 98;
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
            this.panel1.TabIndex = 97;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(997, 20);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 38);
            this.btn_back.TabIndex = 3;
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
            // textBox_Tid
            // 
            this.textBox_Tid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Tid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tid.Location = new System.Drawing.Point(764, 253);
            this.textBox_Tid.Name = "textBox_Tid";
            this.textBox_Tid.Size = new System.Drawing.Size(222, 30);
            this.textBox_Tid.TabIndex = 108;
            this.textBox_Tid.TextChanged += new System.EventHandler(this.textBox_Tid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 107;
            this.label3.Text = "Teacher\'s ID:";
            // 
            // textBox_Sem
            // 
            this.textBox_Sem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem.Location = new System.Drawing.Point(764, 469);
            this.textBox_Sem.Name = "textBox_Sem";
            this.textBox_Sem.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sem.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(760, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "Semester:";
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
            this.semesterDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enrollmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(54, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 238);
            this.dataGridView1.TabIndex = 111;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.universityDataSet6;
            // 
            // universityDataSet6
            // 
            this.universityDataSet6.DataSetName = "UniversityDataSet6";
            this.universityDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Srch2
            // 
            this.btn_Srch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Srch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Srch2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Srch2.ForeColor = System.Drawing.Color.White;
            this.btn_Srch2.Location = new System.Drawing.Point(446, 384);
            this.btn_Srch2.Name = "btn_Srch2";
            this.btn_Srch2.Size = new System.Drawing.Size(174, 28);
            this.btn_Srch2.TabIndex = 119;
            this.btn_Srch2.Text = "Search Semester";
            this.btn_Srch2.UseVisualStyleBackColor = false;
            this.btn_Srch2.Click += new System.EventHandler(this.btn_Srch2_Click);
            // 
            // textBox_Sem2
            // 
            this.textBox_Sem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem2.Location = new System.Drawing.Point(275, 384);
            this.textBox_Sem2.Name = "textBox_Sem2";
            this.textBox_Sem2.Size = new System.Drawing.Size(165, 28);
            this.textBox_Sem2.TabIndex = 118;
            // 
            // btn_Srch1
            // 
            this.btn_Srch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Srch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Srch1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Srch1.ForeColor = System.Drawing.Color.White;
            this.btn_Srch1.Location = new System.Drawing.Point(446, 91);
            this.btn_Srch1.Name = "btn_Srch1";
            this.btn_Srch1.Size = new System.Drawing.Size(174, 28);
            this.btn_Srch1.TabIndex = 116;
            this.btn_Srch1.Text = "Search Semester";
            this.btn_Srch1.UseVisualStyleBackColor = false;
            this.btn_Srch1.Click += new System.EventHandler(this.btn_Srch1_Click);
            // 
            // textBox_Sem1
            // 
            this.textBox_Sem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem1.Location = new System.Drawing.Point(275, 90);
            this.textBox_Sem1.Name = "textBox_Sem1";
            this.textBox_Sem1.Size = new System.Drawing.Size(165, 28);
            this.textBox_Sem1.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 114;
            this.label6.Text = "Enrollments:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.sectionDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn1,
            this.startingTimeDataGridViewTextBoxColumn1,
            this.endingTimeDataGridViewTextBoxColumn1,
            this.daysDataGridViewTextBoxColumn1,
            this.semesterDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.coursesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(54, 124);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(604, 238);
            this.dataGridView2.TabIndex = 113;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.universityDataSet13;
            // 
            // universityDataSet13
            // 
            this.universityDataSet13.DataSetName = "UniversityDataSet13";
            this.universityDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 34);
            this.label12.TabIndex = 112;
            this.label12.Text = "Courses:";
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // picBox_sRefresh
            // 
            this.picBox_sRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_sRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picBox_sRefresh.Image")));
            this.picBox_sRefresh.Location = new System.Drawing.Point(626, 89);
            this.picBox_sRefresh.Name = "picBox_sRefresh";
            this.picBox_sRefresh.Size = new System.Drawing.Size(32, 28);
            this.picBox_sRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_sRefresh.TabIndex = 121;
            this.picBox_sRefresh.TabStop = false;
            this.picBox_sRefresh.Click += new System.EventHandler(this.picBox_sRefresh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(626, 384);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 122;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.Width = 70;
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
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.Width = 80;
            // 
            // courseIDDataGridViewTextBoxColumn1
            // 
            this.courseIDDataGridViewTextBoxColumn1.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn1.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn1.Name = "courseIDDataGridViewTextBoxColumn1";
            this.courseIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.Width = 160;
            // 
            // sectionDataGridViewTextBoxColumn1
            // 
            this.sectionDataGridViewTextBoxColumn1.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn1.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sectionDataGridViewTextBoxColumn1.Name = "sectionDataGridViewTextBoxColumn1";
            this.sectionDataGridViewTextBoxColumn1.Width = 60;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 50;
            // 
            // creditDataGridViewTextBoxColumn1
            // 
            this.creditDataGridViewTextBoxColumn1.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn1.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn1.Name = "creditDataGridViewTextBoxColumn1";
            this.creditDataGridViewTextBoxColumn1.Width = 50;
            // 
            // startingTimeDataGridViewTextBoxColumn1
            // 
            this.startingTimeDataGridViewTextBoxColumn1.DataPropertyName = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn1.HeaderText = "Starting_Time";
            this.startingTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startingTimeDataGridViewTextBoxColumn1.Name = "startingTimeDataGridViewTextBoxColumn1";
            this.startingTimeDataGridViewTextBoxColumn1.Width = 90;
            // 
            // endingTimeDataGridViewTextBoxColumn1
            // 
            this.endingTimeDataGridViewTextBoxColumn1.DataPropertyName = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn1.HeaderText = "Ending_Time";
            this.endingTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endingTimeDataGridViewTextBoxColumn1.Name = "endingTimeDataGridViewTextBoxColumn1";
            this.endingTimeDataGridViewTextBoxColumn1.Width = 90;
            // 
            // daysDataGridViewTextBoxColumn1
            // 
            this.daysDataGridViewTextBoxColumn1.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn1.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn1.Name = "daysDataGridViewTextBoxColumn1";
            this.daysDataGridViewTextBoxColumn1.Width = 80;
            // 
            // semesterDataGridViewTextBoxColumn1
            // 
            this.semesterDataGridViewTextBoxColumn1.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn1.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn1.Name = "semesterDataGridViewTextBoxColumn1";
            // 
            // EnrollTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picBox_sRefresh);
            this.Controls.Add(this.btn_Srch2);
            this.Controls.Add(this.textBox_Sem2);
            this.Controls.Add(this.btn_Srch1);
            this.Controls.Add(this.textBox_Sem1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.textBox_Sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_Tid);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnrollTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnrollTeacher";
            this.Load += new System.EventHandler(this.EnrollTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.TextBox textBox_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_Tid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Sem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UniversityDataSet6 universityDataSet6;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSet6TableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Button btn_Srch2;
        private System.Windows.Forms.TextBox textBox_Sem2;
        private System.Windows.Forms.Button btn_Srch1;
        private System.Windows.Forms.TextBox textBox_Sem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private UniversityDataSet13 universityDataSet13;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private UniversityDataSet13TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.PictureBox picBox_sRefresh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn1;
    }
}
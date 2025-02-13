
namespace University_Management_System
{
    partial class RegisterCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCourse));
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet5 = new University_Management_System.UniversityDataSet5();
            this.enrollmentTableAdapter = new University_Management_System.UniversityDataSet5TableAdapters.EnrollmentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet18 = new University_Management_System.UniversityDataSet18();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet16 = new University_Management_System.UniversityDataSet16();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet12 = new University_Management_System.UniversityDataSet12();
            this.coursesTableAdapter = new University_Management_System.UniversityDataSet12TableAdapters.CoursesTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Srch1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.textBox_Sec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Sem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox_sRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coursesTableAdapter1 = new University_Management_System.UniversityDataSet16TableAdapters.CoursesTableAdapter();
            this.comboBox_SrchSem = new System.Windows.Forms.ComboBox();
            this.universityDataSet17 = new University_Management_System.UniversityDataSet17();
            this.coursesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter2 = new University_Management_System.UniversityDataSet17TableAdapters.CoursesTableAdapter();
            this.coursesTableAdapter3 = new University_Management_System.UniversityDataSet18TableAdapters.CoursesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet12)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "Enrollment";
            this.enrollmentBindingSource.DataSource = this.universityDataSet5;
            // 
            // universityDataSet5
            // 
            this.universityDataSet5.DataSetName = "UniversityDataSet5";
            this.universityDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
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
            this.countDataGridViewTextBoxColumn,
            this.startingTimeDataGridViewTextBoxColumn,
            this.endingTimeDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(22, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 423);
            this.dataGridView1.TabIndex = 128;
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
            this.titleDataGridViewTextBoxColumn.Width = 150;
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
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 50;
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
            this.daysDataGridViewTextBoxColumn.Width = 70;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesBindingSource3
            // 
            this.coursesBindingSource3.DataMember = "Courses";
            this.coursesBindingSource3.DataSource = this.universityDataSet18;
            // 
            // universityDataSet18
            // 
            this.universityDataSet18.DataSetName = "UniversityDataSet18";
            this.universityDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.universityDataSet16;
            // 
            // universityDataSet16
            // 
            this.universityDataSet16.DataSetName = "UniversityDataSet16";
            this.universityDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.universityDataSet12;
            // 
            // universityDataSet12
            // 
            this.universityDataSet12.DataSetName = "UniversityDataSet12";
            this.universityDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 132;
            this.label7.Text = "Course:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_Srch1
            // 
            this.btn_Srch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Srch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Srch1.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Srch1.ForeColor = System.Drawing.Color.White;
            this.btn_Srch1.Location = new System.Drawing.Point(433, 176);
            this.btn_Srch1.Name = "btn_Srch1";
            this.btn_Srch1.Size = new System.Drawing.Size(100, 24);
            this.btn_Srch1.TabIndex = 131;
            this.btn_Srch1.Text = "Search";
            this.btn_Srch1.UseVisualStyleBackColor = false;
            this.btn_Srch1.Click += new System.EventHandler(this.btn_Srch1_Click);
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
            this.comboBox_Course.Location = new System.Drawing.Point(790, 295);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(222, 24);
            this.comboBox_Course.TabIndex = 121;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(790, 546);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(222, 38);
            this.btn_cancel.TabIndex = 113;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(790, 491);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(222, 38);
            this.btn_register.TabIndex = 112;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // textBox_Sec
            // 
            this.textBox_Sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sec.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sec.Location = new System.Drawing.Point(790, 360);
            this.textBox_Sec.Name = "textBox_Sec";
            this.textBox_Sec.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sec.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(786, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "Section:";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(413, 34);
            this.label12.TabIndex = 127;
            this.label12.Text = "Available Courses To Register";
            // 
            // textBox_Sem
            // 
            this.textBox_Sem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Sem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sem.Location = new System.Drawing.Point(790, 435);
            this.textBox_Sem.Name = "textBox_Sem";
            this.textBox_Sem.Size = new System.Drawing.Size(222, 30);
            this.textBox_Sem.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 124;
            this.label5.Text = "Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 74);
            this.label2.TabIndex = 117;
            this.label2.Text = "Register\r\nCourse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 116;
            this.label1.Text = "Course title:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 695);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 15);
            this.panel2.TabIndex = 115;
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
            this.panel1.TabIndex = 114;
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
            // picBox_sRefresh
            // 
            this.picBox_sRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_sRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picBox_sRefresh.Image")));
            this.picBox_sRefresh.Location = new System.Drawing.Point(539, 176);
            this.picBox_sRefresh.Name = "picBox_sRefresh";
            this.picBox_sRefresh.Size = new System.Drawing.Size(28, 24);
            this.picBox_sRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_sRefresh.TabIndex = 136;
            this.picBox_sRefresh.TabStop = false;
            this.picBox_sRefresh.Click += new System.EventHandler(this.picBox_sRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(794, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // coursesTableAdapter1
            // 
            this.coursesTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox_SrchSem
            // 
            this.comboBox_SrchSem.FormattingEnabled = true;
            this.comboBox_SrchSem.Items.AddRange(new object[] {
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
            this.comboBox_SrchSem.Location = new System.Drawing.Point(248, 176);
            this.comboBox_SrchSem.Name = "comboBox_SrchSem";
            this.comboBox_SrchSem.Size = new System.Drawing.Size(179, 24);
            this.comboBox_SrchSem.TabIndex = 137;
            // 
            // universityDataSet17
            // 
            this.universityDataSet17.DataSetName = "UniversityDataSet17";
            this.universityDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource2
            // 
            this.coursesBindingSource2.DataMember = "Courses";
            this.coursesBindingSource2.DataSource = this.universityDataSet17;
            // 
            // coursesTableAdapter2
            // 
            this.coursesTableAdapter2.ClearBeforeFill = true;
            // 
            // coursesTableAdapter3
            // 
            this.coursesTableAdapter3.ClearBeforeFill = true;
            // 
            // RegisterCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1125, 710);
            this.Controls.Add(this.comboBox_SrchSem);
            this.Controls.Add(this.picBox_sRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Srch1);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.textBox_Sec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterCourse";
            this.Load += new System.EventHandler(this.RegisterCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_sRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_sRefresh;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private UniversityDataSet5 universityDataSet5;
        private UniversityDataSet5TableAdapters.EnrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private UniversityDataSet12 universityDataSet12;
        private UniversityDataSet12TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Srch1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox textBox_Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Sem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private UniversityDataSet16 universityDataSet16;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private UniversityDataSet16TableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox_SrchSem;
        private UniversityDataSet17 universityDataSet17;
        private System.Windows.Forms.BindingSource coursesBindingSource2;
        private UniversityDataSet17TableAdapters.CoursesTableAdapter coursesTableAdapter2;
        private UniversityDataSet18 universityDataSet18;
        private System.Windows.Forms.BindingSource coursesBindingSource3;
        private UniversityDataSet18TableAdapters.CoursesTableAdapter coursesTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}
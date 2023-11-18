namespace Assignment_2
{
    partial class languageArtsInstitute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(languageArtsInstitute));
            this.laiPicture = new System.Windows.Forms.PictureBox();
            this.termGroupBox = new System.Windows.Forms.GroupBox();
            this.semesterYearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.summerRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.courseGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCourseButton = new System.Windows.Forms.Button();
            this.totalChargeButton = new System.Windows.Forms.Button();
            this.totalCourse = new System.Windows.Forms.Label();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.totalCharge = new System.Windows.Forms.Label();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.creditCardTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.mastercardRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.laiPicture)).BeginInit();
            this.termGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.courseGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laiPicture
            // 
            this.laiPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.laiPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laiPicture.Image = ((System.Drawing.Image)(resources.GetObject("laiPicture.Image")));
            this.laiPicture.Location = new System.Drawing.Point(13, 220);
            this.laiPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.laiPicture.Name = "laiPicture";
            this.laiPicture.Size = new System.Drawing.Size(264, 258);
            this.laiPicture.TabIndex = 0;
            this.laiPicture.TabStop = false;
            // 
            // termGroupBox
            // 
            this.termGroupBox.Controls.Add(this.semesterYearComboBox);
            this.termGroupBox.Controls.Add(this.springRadioButton);
            this.termGroupBox.Controls.Add(this.summerRadioButton);
            this.termGroupBox.Controls.Add(this.fallRadioButton);
            this.termGroupBox.Location = new System.Drawing.Point(290, 220);
            this.termGroupBox.Name = "termGroupBox";
            this.termGroupBox.Size = new System.Drawing.Size(966, 80);
            this.termGroupBox.TabIndex = 1;
            this.termGroupBox.TabStop = false;
            this.termGroupBox.Text = "Term Information";
            // 
            // semesterYearComboBox
            // 
            this.semesterYearComboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterYearComboBox.FormattingEnabled = true;
            this.semesterYearComboBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.semesterYearComboBox.Location = new System.Drawing.Point(489, 35);
            this.semesterYearComboBox.Name = "semesterYearComboBox";
            this.semesterYearComboBox.Size = new System.Drawing.Size(125, 23);
            this.semesterYearComboBox.TabIndex = 4;
            // 
            // springRadioButton
            // 
            this.springRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.springRadioButton.Location = new System.Drawing.Point(6, 25);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(115, 41);
            this.springRadioButton.TabIndex = 1;
            this.springRadioButton.TabStop = true;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // summerRadioButton
            // 
            this.summerRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerRadioButton.Location = new System.Drawing.Point(165, 25);
            this.summerRadioButton.Name = "summerRadioButton";
            this.summerRadioButton.Size = new System.Drawing.Size(115, 41);
            this.summerRadioButton.TabIndex = 2;
            this.summerRadioButton.TabStop = true;
            this.summerRadioButton.Text = "Summer";
            this.summerRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallRadioButton.Location = new System.Drawing.Point(320, 25);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(115, 41);
            this.fallRadioButton.TabIndex = 3;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.studentIDTextBox);
            this.studentGroupBox.Controls.Add(this.emailTextBox);
            this.studentGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentGroupBox.Controls.Add(this.emailLabel);
            this.studentGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentGroupBox.Controls.Add(this.studentIDLabel);
            this.studentGroupBox.Controls.Add(this.lastNameLabel);
            this.studentGroupBox.Controls.Add(this.firstNameLabel);
            this.studentGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentGroupBox.Location = new System.Drawing.Point(284, 306);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(972, 172);
            this.studentGroupBox.TabIndex = 2;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Information";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(631, 82);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(273, 26);
            this.emailTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(631, 37);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(273, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Location = new System.Drawing.Point(476, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(149, 30);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentIDLabel.Location = new System.Drawing.Point(6, 78);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(149, 30);
            this.studentIDLabel.TabIndex = 7;
            this.studentIDLabel.Text = "Student ID";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel.Location = new System.Drawing.Point(476, 33);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(149, 30);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(149, 30);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 37);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(273, 26);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // courseGroupBox
            // 
            this.courseGroupBox.Controls.Add(this.totalCourseButton);
            this.courseGroupBox.Controls.Add(this.totalChargeButton);
            this.courseGroupBox.Controls.Add(this.totalCourse);
            this.courseGroupBox.Controls.Add(this.totalCharge);
            this.courseGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseGroupBox.Controls.Add(this.russianCheckBox);
            this.courseGroupBox.Controls.Add(this.italianCheckBox);
            this.courseGroupBox.Controls.Add(this.germanCheckBox);
            this.courseGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseGroupBox.Location = new System.Drawing.Point(12, 486);
            this.courseGroupBox.Name = "courseGroupBox";
            this.courseGroupBox.Size = new System.Drawing.Size(1244, 231);
            this.courseGroupBox.TabIndex = 2;
            this.courseGroupBox.TabStop = false;
            this.courseGroupBox.Text = "Course Order Information";
            // 
            // totalCourseButton
            // 
            this.totalCourseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalCourseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.totalCourseButton.Location = new System.Drawing.Point(20, 176);
            this.totalCourseButton.Name = "totalCourseButton";
            this.totalCourseButton.Size = new System.Drawing.Size(136, 33);
            this.totalCourseButton.TabIndex = 17;
            this.totalCourseButton.Text = "Courses";
            this.totalCourseButton.UseVisualStyleBackColor = false;
            this.totalCourseButton.Click += new System.EventHandler(this.totalCourseButton_Click);
            // 
            // totalChargeButton
            // 
            this.totalChargeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalChargeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.totalChargeButton.Location = new System.Drawing.Point(20, 116);
            this.totalChargeButton.Name = "totalChargeButton";
            this.totalChargeButton.Size = new System.Drawing.Size(136, 33);
            this.totalChargeButton.TabIndex = 16;
            this.totalChargeButton.Text = "Cost";
            this.totalChargeButton.UseVisualStyleBackColor = false;
            this.totalChargeButton.Click += new System.EventHandler(this.totalChargeButton_Click);
            // 
            // totalCourse
            // 
            this.totalCourse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.totalCourse.Location = new System.Drawing.Point(190, 176);
            this.totalCourse.Name = "totalCourse";
            this.totalCourse.Size = new System.Drawing.Size(91, 33);
            this.totalCourse.TabIndex = 17;
            this.totalCourse.UseCompatibleTextRendering = true;
            this.totalCourse.Click += new System.EventHandler(this.totalCourse_Click);
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outOfStateRadioButton.Location = new System.Drawing.Point(143, 138);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(111, 22);
            this.outOfStateRadioButton.TabIndex = 10;
            this.outOfStateRadioButton.TabStop = true;
            this.outOfStateRadioButton.Text = "Out of State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.outOfStateRadioButton_CheckedChanged);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStateRadioButton.Location = new System.Drawing.Point(9, 138);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(111, 22);
            this.inStateRadioButton.TabIndex = 9;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.inStateRadioButton_CheckedChanged);
            // 
            // totalCharge
            // 
            this.totalCharge.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCharge.ForeColor = System.Drawing.SystemColors.Control;
            this.totalCharge.Location = new System.Drawing.Point(190, 116);
            this.totalCharge.Name = "totalCharge";
            this.totalCharge.Size = new System.Drawing.Size(507, 33);
            this.totalCharge.TabIndex = 16;
            this.totalCharge.UseCompatibleTextRendering = true;
            this.totalCharge.Click += new System.EventHandler(this.totalCharge_Click);
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanishCheckBox.Location = new System.Drawing.Point(684, 48);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(173, 47);
            this.spanishCheckBox.TabIndex = 15;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.russianCheckBox.Location = new System.Drawing.Point(241, 48);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(173, 47);
            this.russianCheckBox.TabIndex = 14;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italianCheckBox.Location = new System.Drawing.Point(462, 48);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(173, 47);
            this.italianCheckBox.TabIndex = 13;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanCheckBox.Location = new System.Drawing.Point(903, 48);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(173, 47);
            this.germanCheckBox.TabIndex = 12;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchCheckBox.Location = new System.Drawing.Point(20, 48);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(173, 47);
            this.frenchCheckBox.TabIndex = 11;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.creditCardTextBox);
            this.paymentGroupBox.Controls.Add(this.expirationDateTextBox);
            this.paymentGroupBox.Controls.Add(this.expirationDateLabel);
            this.paymentGroupBox.Controls.Add(this.creditCardLabel);
            this.paymentGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentGroupBox.Controls.Add(this.mastercardRadioButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(13, 723);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(1243, 180);
            this.paymentGroupBox.TabIndex = 2;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Information";
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Location = new System.Drawing.Point(0, 118);
            this.creditCardTextBox.Mask = "0000-0000-0000";
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(232, 26);
            this.creditCardTextBox.TabIndex = 20;
            // 
            // expirationDateTextBox
            // 
            this.expirationDateTextBox.Location = new System.Drawing.Point(461, 118);
            this.expirationDateTextBox.Mask = "00/00/0000";
            this.expirationDateTextBox.Name = "expirationDateTextBox";
            this.expirationDateTextBox.Size = new System.Drawing.Size(236, 26);
            this.expirationDateTextBox.TabIndex = 21;
            this.expirationDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expirationDateLabel.Location = new System.Drawing.Point(461, 84);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(320, 31);
            this.expirationDateLabel.TabIndex = 21;
            this.expirationDateLabel.Text = "Expiration Date";
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditCardLabel.Location = new System.Drawing.Point(0, 84);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(320, 31);
            this.creditCardLabel.TabIndex = 20;
            this.creditCardLabel.Text = "Credit Card Number";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaRadioButton.Location = new System.Drawing.Point(191, 25);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(159, 51);
            this.visaRadioButton.TabIndex = 19;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastercardRadioButton
            // 
            this.mastercardRadioButton.Checked = true;
            this.mastercardRadioButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mastercardRadioButton.Location = new System.Drawing.Point(6, 25);
            this.mastercardRadioButton.Name = "mastercardRadioButton";
            this.mastercardRadioButton.Size = new System.Drawing.Size(159, 51);
            this.mastercardRadioButton.TabIndex = 18;
            this.mastercardRadioButton.TabStop = true;
            this.mastercardRadioButton.Text = "MasterCard";
            this.mastercardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(32, 918);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(201, 33);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(624, 918);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(201, 33);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(326, 918);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 33);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(161, 78);
            this.studentIDTextBox.Mask = "000-000-000";
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(273, 26);
            this.studentIDTextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // languageArtsInstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 963);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.courseGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.termGroupBox);
            this.Controls.Add(this.laiPicture);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "languageArtsInstitute";
            this.Text = "Language Arts Institute";
            ((System.ComponentModel.ISupportInitialize)(this.laiPicture)).EndInit();
            this.termGroupBox.ResumeLayout(false);
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.courseGroupBox.ResumeLayout(false);
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox laiPicture;
        private System.Windows.Forms.GroupBox termGroupBox;
        private System.Windows.Forms.ComboBox semesterYearComboBox;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton summerRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.GroupBox courseGroupBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton mastercardRadioButton;
        private System.Windows.Forms.MaskedTextBox creditCardTextBox;
        private System.Windows.Forms.MaskedTextBox expirationDateTextBox;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalCharge;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label totalCourse;
        private System.Windows.Forms.Button totalCourseButton;
        private System.Windows.Forms.Button totalChargeButton;
        private System.Windows.Forms.MaskedTextBox studentIDTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


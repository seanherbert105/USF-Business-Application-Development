namespace Assignment_1
{
    partial class motorwayMotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motorwayMotel));
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.ListBox();
            this.nightsStayedLabel = new System.Windows.Forms.Label();
            this.miniBarLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.miscellaneousLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.billingGroup = new System.Windows.Forms.GroupBox();
            this.miscellaneousCosts = new System.Windows.Forms.TextBox();
            this.telephoneCosts = new System.Windows.Forms.TextBox();
            this.miniBarCosts = new System.Windows.Forms.TextBox();
            this.nightsStayedNumber = new System.Windows.Forms.NumericUpDown();
            this.totalsGroup = new System.Windows.Forms.GroupBox();
            this.additionalCharges = new System.Windows.Forms.Label();
            this.roomPrice = new System.Windows.Forms.Label();
            this.additionalPrice = new System.Windows.Forms.Label();
            this.subtotalPrice = new System.Windows.Forms.Label();
            this.taxCharge = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.subtotalCharges = new System.Windows.Forms.Label();
            this.roomCharges = new System.Windows.Forms.Label();
            this.guestCheckOut = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.billingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightsStayedNumber)).BeginInit();
            this.totalsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePicture
            // 
            this.titlePicture.ErrorImage = null;
            this.titlePicture.Image = ((System.Drawing.Image)(resources.GetObject("titlePicture.Image")));
            this.titlePicture.InitialImage = null;
            this.titlePicture.Location = new System.Drawing.Point(635, 78);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(285, 219);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePicture.TabIndex = 0;
            this.titlePicture.TabStop = false;
            this.titlePicture.Click += new System.EventHandler(this.titlePicture_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(635, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(284, 64);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Motorway Motel";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkOutLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutLabel.Location = new System.Drawing.Point(635, 318);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(180, 37);
            this.checkOutLabel.TabIndex = 0;
            this.checkOutLabel.Text = "Guest Check Out";
            this.checkOutLabel.Click += new System.EventHandler(this.checkOutLabel_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(14, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(138, 38);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(14, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(138, 38);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomNumberLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberLabel.Location = new System.Drawing.Point(14, 107);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(138, 38);
            this.roomNumberLabel.TabIndex = 0;
            this.roomNumberLabel.Text = "Room Number:";
            this.roomNumberLabel.Click += new System.EventHandler(this.roomNumberLabel_Click);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(159, 33);
            this.firstName.MaxLength = 50;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(301, 26);
            this.firstName.TabIndex = 2;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(159, 69);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(301, 26);
            this.lastName.TabIndex = 3;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // roomNumber
            // 
            this.roomNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.FormattingEnabled = true;
            this.roomNumber.ItemHeight = 15;
            this.roomNumber.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "------",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215"});
            this.roomNumber.Location = new System.Drawing.Point(159, 107);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(99, 79);
            this.roomNumber.TabIndex = 4;
            this.roomNumber.SelectedIndexChanged += new System.EventHandler(this.roomNumber_SelectedIndexChanged);
            // 
            // nightsStayedLabel
            // 
            this.nightsStayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nightsStayedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightsStayedLabel.Location = new System.Drawing.Point(0, 69);
            this.nightsStayedLabel.Name = "nightsStayedLabel";
            this.nightsStayedLabel.Size = new System.Drawing.Size(126, 36);
            this.nightsStayedLabel.TabIndex = 0;
            this.nightsStayedLabel.Text = "Nights Stayed";
            this.nightsStayedLabel.Click += new System.EventHandler(this.nightsStayedLabel_Click);
            // 
            // miniBarLabel
            // 
            this.miniBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miniBarLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBarLabel.Location = new System.Drawing.Point(0, 126);
            this.miniBarLabel.Name = "miniBarLabel";
            this.miniBarLabel.Size = new System.Drawing.Size(126, 36);
            this.miniBarLabel.TabIndex = 0;
            this.miniBarLabel.Text = "Mini Bar";
            this.miniBarLabel.Click += new System.EventHandler(this.miniBarLabel_Click);
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.telephoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(0, 179);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(126, 36);
            this.telephoneLabel.TabIndex = 0;
            this.telephoneLabel.Text = "Telephone";
            this.telephoneLabel.Click += new System.EventHandler(this.telephoneLabel_Click);
            // 
            // miscellaneousLabel
            // 
            this.miscellaneousLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miscellaneousLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscellaneousLabel.Location = new System.Drawing.Point(0, 233);
            this.miscellaneousLabel.Name = "miscellaneousLabel";
            this.miscellaneousLabel.Size = new System.Drawing.Size(126, 37);
            this.miscellaneousLabel.TabIndex = 0;
            this.miscellaneousLabel.Text = "Miscellaneous";
            this.miscellaneousLabel.Click += new System.EventHandler(this.miscellaneousLabel_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(6, 250);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(126, 36);
            this.totalPriceLabel.TabIndex = 0;
            this.totalPriceLabel.Text = "Total";
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalPrice.Location = new System.Drawing.Point(169, 250);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(99, 35);
            this.totalPrice.TabIndex = 0;
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.totalButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.totalButton.Location = new System.Drawing.Point(350, 735);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(204, 59);
            this.totalButton.TabIndex = 9;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(560, 735);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(204, 59);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.helpButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.helpButton.Location = new System.Drawing.Point(1, 761);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(115, 33);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(1007, 761);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 33);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // billingGroup
            // 
            this.billingGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billingGroup.BackgroundImage")));
            this.billingGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.billingGroup.Controls.Add(this.miscellaneousCosts);
            this.billingGroup.Controls.Add(this.nightsStayedLabel);
            this.billingGroup.Controls.Add(this.telephoneCosts);
            this.billingGroup.Controls.Add(this.miniBarCosts);
            this.billingGroup.Controls.Add(this.miniBarLabel);
            this.billingGroup.Controls.Add(this.telephoneLabel);
            this.billingGroup.Controls.Add(this.miscellaneousLabel);
            this.billingGroup.Controls.Add(this.nightsStayedNumber);
            this.billingGroup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingGroup.Location = new System.Drawing.Point(14, 192);
            this.billingGroup.Name = "billingGroup";
            this.billingGroup.Size = new System.Drawing.Size(446, 295);
            this.billingGroup.TabIndex = 0;
            this.billingGroup.TabStop = false;
            this.billingGroup.Text = "Billing";
            this.billingGroup.Enter += new System.EventHandler(this.billingGroup_Enter);
            // 
            // miscellaneousCosts
            // 
            this.miscellaneousCosts.Location = new System.Drawing.Point(154, 241);
            this.miscellaneousCosts.Name = "miscellaneousCosts";
            this.miscellaneousCosts.Size = new System.Drawing.Size(99, 29);
            this.miscellaneousCosts.TabIndex = 8;
            this.miscellaneousCosts.TextChanged += new System.EventHandler(this.miscellaneousCosts_TextChanged);
            // 
            // telephoneCosts
            // 
            this.telephoneCosts.Location = new System.Drawing.Point(154, 186);
            this.telephoneCosts.Name = "telephoneCosts";
            this.telephoneCosts.Size = new System.Drawing.Size(99, 29);
            this.telephoneCosts.TabIndex = 7;
            this.telephoneCosts.TextChanged += new System.EventHandler(this.telephoneCosts_TextChanged);
            // 
            // miniBarCosts
            // 
            this.miniBarCosts.Location = new System.Drawing.Point(154, 133);
            this.miniBarCosts.Name = "miniBarCosts";
            this.miniBarCosts.Size = new System.Drawing.Size(99, 29);
            this.miniBarCosts.TabIndex = 6;
            this.miniBarCosts.TextChanged += new System.EventHandler(this.miniBarCosts_TextChanged);
            // 
            // nightsStayedNumber
            // 
            this.nightsStayedNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightsStayedNumber.Location = new System.Drawing.Point(154, 69);
            this.nightsStayedNumber.Name = "nightsStayedNumber";
            this.nightsStayedNumber.Size = new System.Drawing.Size(38, 22);
            this.nightsStayedNumber.TabIndex = 5;
            this.nightsStayedNumber.ValueChanged += new System.EventHandler(this.nightsStayedNumber_ValueChanged);
            // 
            // totalsGroup
            // 
            this.totalsGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("totalsGroup.BackgroundImage")));
            this.totalsGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.totalsGroup.Controls.Add(this.additionalCharges);
            this.totalsGroup.Controls.Add(this.roomPrice);
            this.totalsGroup.Controls.Add(this.additionalPrice);
            this.totalsGroup.Controls.Add(this.subtotalPrice);
            this.totalsGroup.Controls.Add(this.taxCharge);
            this.totalsGroup.Controls.Add(this.taxAmount);
            this.totalsGroup.Controls.Add(this.subtotalCharges);
            this.totalsGroup.Controls.Add(this.roomCharges);
            this.totalsGroup.Controls.Add(this.totalPriceLabel);
            this.totalsGroup.Controls.Add(this.totalPrice);
            this.totalsGroup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsGroup.Location = new System.Drawing.Point(515, 387);
            this.totalsGroup.Name = "totalsGroup";
            this.totalsGroup.Size = new System.Drawing.Size(404, 323);
            this.totalsGroup.TabIndex = 37;
            this.totalsGroup.TabStop = false;
            this.totalsGroup.Text = "Totals";
            this.totalsGroup.Enter += new System.EventHandler(this.totalsGroup_Enter);
            // 
            // additionalCharges
            // 
            this.additionalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.additionalCharges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalCharges.Location = new System.Drawing.Point(6, 94);
            this.additionalCharges.Name = "additionalCharges";
            this.additionalCharges.Size = new System.Drawing.Size(126, 36);
            this.additionalCharges.TabIndex = 0;
            this.additionalCharges.Text = "Additional";
            this.additionalCharges.Click += new System.EventHandler(this.additionalCharges_Click);
            // 
            // roomPrice
            // 
            this.roomPrice.BackColor = System.Drawing.SystemColors.Control;
            this.roomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roomPrice.Location = new System.Drawing.Point(169, 39);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(99, 35);
            this.roomPrice.TabIndex = 0;
            this.roomPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roomPrice.Click += new System.EventHandler(this.roomPrice_Click);
            // 
            // additionalPrice
            // 
            this.additionalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.additionalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.additionalPrice.Location = new System.Drawing.Point(169, 94);
            this.additionalPrice.Name = "additionalPrice";
            this.additionalPrice.Size = new System.Drawing.Size(99, 35);
            this.additionalPrice.TabIndex = 0;
            this.additionalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.additionalPrice.Click += new System.EventHandler(this.additionalPrice_Click);
            // 
            // subtotalPrice
            // 
            this.subtotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.subtotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subtotalPrice.Location = new System.Drawing.Point(169, 149);
            this.subtotalPrice.Name = "subtotalPrice";
            this.subtotalPrice.Size = new System.Drawing.Size(99, 35);
            this.subtotalPrice.TabIndex = 0;
            this.subtotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subtotalPrice.Click += new System.EventHandler(this.subtotalPrice_Click);
            // 
            // taxCharge
            // 
            this.taxCharge.BackColor = System.Drawing.SystemColors.Control;
            this.taxCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxCharge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxCharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxCharge.Location = new System.Drawing.Point(169, 202);
            this.taxCharge.Name = "taxCharge";
            this.taxCharge.Size = new System.Drawing.Size(99, 35);
            this.taxCharge.TabIndex = 0;
            this.taxCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taxCharge.Click += new System.EventHandler(this.taxCharge_Click);
            // 
            // taxAmount
            // 
            this.taxAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmount.Location = new System.Drawing.Point(6, 202);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(126, 36);
            this.taxAmount.TabIndex = 0;
            this.taxAmount.Text = "Tax";
            this.taxAmount.Click += new System.EventHandler(this.taxAmount_Click);
            // 
            // subtotalCharges
            // 
            this.subtotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtotalCharges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalCharges.Location = new System.Drawing.Point(6, 149);
            this.subtotalCharges.Name = "subtotalCharges";
            this.subtotalCharges.Size = new System.Drawing.Size(126, 36);
            this.subtotalCharges.TabIndex = 0;
            this.subtotalCharges.Text = "Subtotal";
            this.subtotalCharges.Click += new System.EventHandler(this.subtotalCharges_Click);
            // 
            // roomCharges
            // 
            this.roomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomCharges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCharges.Location = new System.Drawing.Point(6, 39);
            this.roomCharges.Name = "roomCharges";
            this.roomCharges.Size = new System.Drawing.Size(126, 36);
            this.roomCharges.TabIndex = 0;
            this.roomCharges.Text = "Room";
            this.roomCharges.Click += new System.EventHandler(this.roomCharges_Click);
            // 
            // guestCheckOut
            // 
            this.guestCheckOut.Location = new System.Drawing.Point(635, 348);
            this.guestCheckOut.Mask = "00/00/0000";
            this.guestCheckOut.Name = "guestCheckOut";
            this.guestCheckOut.Size = new System.Drawing.Size(240, 22);
            this.guestCheckOut.TabIndex = 1;
            this.guestCheckOut.ValidatingType = typeof(System.DateTime);
            this.guestCheckOut.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.guestCheckOut_MaskInputRejected);
            // 
            // motorwayMotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 806);
            this.Controls.Add(this.guestCheckOut);
            this.Controls.Add(this.totalsGroup);
            this.Controls.Add(this.billingGroup);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePicture);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "motorwayMotel";
            this.Text = "Motorway Motel Guest Total";
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.billingGroup.ResumeLayout(false);
            this.billingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightsStayedNumber)).EndInit();
            this.totalsGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.ListBox roomNumber;
        private System.Windows.Forms.Label nightsStayedLabel;
        private System.Windows.Forms.Label miniBarLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label miscellaneousLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox billingGroup;
        private System.Windows.Forms.NumericUpDown nightsStayedNumber;
        private System.Windows.Forms.TextBox miniBarCosts;
        private System.Windows.Forms.TextBox telephoneCosts;
        private System.Windows.Forms.TextBox miscellaneousCosts;
        private System.Windows.Forms.GroupBox totalsGroup;
        private System.Windows.Forms.Label roomPrice;
        private System.Windows.Forms.Label additionalPrice;
        private System.Windows.Forms.Label subtotalPrice;
        private System.Windows.Forms.Label taxCharge;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label subtotalCharges;
        private System.Windows.Forms.Label roomCharges;
        private System.Windows.Forms.Label additionalCharges;
        private System.Windows.Forms.MaskedTextBox guestCheckOut;
    }
}


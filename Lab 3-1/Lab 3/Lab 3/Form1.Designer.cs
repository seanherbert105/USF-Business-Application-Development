namespace Lab_3
{
    partial class petBoutique
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
            this.petOwnerGroup = new System.Windows.Forms.GroupBox();
            this.orderPhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.orderPhoneLabel = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.petGroup = new System.Windows.Forms.GroupBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.petDOBTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.petTypeLabel = new System.Windows.Forms.Label();
            this.petDOBLabel = new System.Windows.Forms.Label();
            this.petNameLabel = new System.Windows.Forms.Label();
            this.serviceGroup = new System.Windows.Forms.GroupBox();
            this.furTrimmingLabel = new System.Windows.Forms.Label();
            this.shampooLabel = new System.Windows.Forms.Label();
            this.nailClippingLabel = new System.Windows.Forms.Label();
            this.fleaRemovalLabel = new System.Windows.Forms.Label();
            this.totalResultLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.petOwnerGroup.SuspendLayout();
            this.petGroup.SuspendLayout();
            this.serviceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // petOwnerGroup
            // 
            this.petOwnerGroup.Controls.Add(this.orderPhoneTextBox);
            this.petOwnerGroup.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroup.Controls.Add(this.orderPhoneLabel);
            this.petOwnerGroup.Controls.Add(this.ownerNameLabel);
            this.petOwnerGroup.Location = new System.Drawing.Point(12, 12);
            this.petOwnerGroup.Name = "petOwnerGroup";
            this.petOwnerGroup.Size = new System.Drawing.Size(666, 121);
            this.petOwnerGroup.TabIndex = 0;
            this.petOwnerGroup.TabStop = false;
            this.petOwnerGroup.Text = "Pet Owner";
            // 
            // orderPhoneTextBox
            // 
            this.orderPhoneTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPhoneTextBox.Location = new System.Drawing.Point(153, 77);
            this.orderPhoneTextBox.Mask = "(999) 000-0000";
            this.orderPhoneTextBox.Name = "orderPhoneTextBox";
            this.orderPhoneTextBox.Size = new System.Drawing.Size(150, 26);
            this.orderPhoneTextBox.TabIndex = 2;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerNameTextBox.Location = new System.Drawing.Point(153, 43);
            this.ownerNameTextBox.MaxLength = 100;
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(377, 26);
            this.ownerNameTextBox.TabIndex = 1;
            // 
            // orderPhoneLabel
            // 
            this.orderPhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderPhoneLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPhoneLabel.Location = new System.Drawing.Point(6, 69);
            this.orderPhoneLabel.Name = "orderPhoneLabel";
            this.orderPhoneLabel.Size = new System.Drawing.Size(139, 34);
            this.orderPhoneLabel.TabIndex = 2;
            this.orderPhoneLabel.Text = "Order Phone:";
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ownerNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerNameLabel.Location = new System.Drawing.Point(6, 35);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(139, 34);
            this.ownerNameLabel.TabIndex = 1;
            this.ownerNameLabel.Text = "Owner Name:";
            // 
            // petGroup
            // 
            this.petGroup.Controls.Add(this.typeTextBox);
            this.petGroup.Controls.Add(this.typeLabel);
            this.petGroup.Controls.Add(this.otherRadioButton);
            this.petGroup.Controls.Add(this.dogRadioButton);
            this.petGroup.Controls.Add(this.catRadioButton);
            this.petGroup.Controls.Add(this.petDOBTextBox);
            this.petGroup.Controls.Add(this.petNameTextBox);
            this.petGroup.Controls.Add(this.petTypeLabel);
            this.petGroup.Controls.Add(this.petDOBLabel);
            this.petGroup.Controls.Add(this.petNameLabel);
            this.petGroup.Location = new System.Drawing.Point(12, 139);
            this.petGroup.Name = "petGroup";
            this.petGroup.Size = new System.Drawing.Size(666, 211);
            this.petGroup.TabIndex = 1;
            this.petGroup.TabStop = false;
            this.petGroup.Text = "Pet";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Enabled = false;
            this.typeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTextBox.Location = new System.Drawing.Point(151, 163);
            this.typeTextBox.MaxLength = 100;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(377, 26);
            this.typeTextBox.TabIndex = 7;
            // 
            // typeLabel
            // 
            this.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.typeLabel.Enabled = false;
            this.typeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(6, 155);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(139, 34);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "T&ype (if Other):";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRadioButton.Location = new System.Drawing.Point(339, 125);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(103, 30);
            this.otherRadioButton.TabIndex = 7;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogRadioButton.Location = new System.Drawing.Point(248, 125);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(103, 30);
            this.dogRadioButton.TabIndex = 6;
            this.dogRadioButton.Text = "Dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // catRadioButton
            // 
            this.catRadioButton.Checked = true;
            this.catRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catRadioButton.Location = new System.Drawing.Point(153, 125);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(101, 30);
            this.catRadioButton.TabIndex = 5;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "Cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // petDOBTextBox
            // 
            this.petDOBTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petDOBTextBox.Location = new System.Drawing.Point(151, 80);
            this.petDOBTextBox.Mask = "00/00/0000";
            this.petDOBTextBox.Name = "petDOBTextBox";
            this.petDOBTextBox.Size = new System.Drawing.Size(152, 26);
            this.petDOBTextBox.TabIndex = 4;
            this.petDOBTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petNameTextBox.Location = new System.Drawing.Point(151, 46);
            this.petNameTextBox.MaxLength = 100;
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(377, 26);
            this.petNameTextBox.TabIndex = 3;
            // 
            // petTypeLabel
            // 
            this.petTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petTypeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTypeLabel.Location = new System.Drawing.Point(6, 121);
            this.petTypeLabel.Name = "petTypeLabel";
            this.petTypeLabel.Size = new System.Drawing.Size(139, 34);
            this.petTypeLabel.TabIndex = 5;
            this.petTypeLabel.Text = "Pet Type:";
            // 
            // petDOBLabel
            // 
            this.petDOBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petDOBLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petDOBLabel.Location = new System.Drawing.Point(6, 72);
            this.petDOBLabel.Name = "petDOBLabel";
            this.petDOBLabel.Size = new System.Drawing.Size(139, 34);
            this.petDOBLabel.TabIndex = 4;
            this.petDOBLabel.Text = "Pet Date of Birth:";
            // 
            // petNameLabel
            // 
            this.petNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.petNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petNameLabel.Location = new System.Drawing.Point(6, 38);
            this.petNameLabel.Name = "petNameLabel";
            this.petNameLabel.Size = new System.Drawing.Size(139, 34);
            this.petNameLabel.TabIndex = 3;
            this.petNameLabel.Text = "Pet Name:";
            // 
            // serviceGroup
            // 
            this.serviceGroup.Controls.Add(this.furTrimmingLabel);
            this.serviceGroup.Controls.Add(this.shampooLabel);
            this.serviceGroup.Controls.Add(this.nailClippingLabel);
            this.serviceGroup.Controls.Add(this.fleaRemovalLabel);
            this.serviceGroup.Controls.Add(this.totalResultLabel);
            this.serviceGroup.Controls.Add(this.totalLabel);
            this.serviceGroup.Controls.Add(this.furTrimmingCheckBox);
            this.serviceGroup.Controls.Add(this.shampooCheckBox);
            this.serviceGroup.Controls.Add(this.nailClippingCheckBox);
            this.serviceGroup.Controls.Add(this.fleaRemovalCheckBox);
            this.serviceGroup.Location = new System.Drawing.Point(12, 356);
            this.serviceGroup.Name = "serviceGroup";
            this.serviceGroup.Size = new System.Drawing.Size(666, 193);
            this.serviceGroup.TabIndex = 2;
            this.serviceGroup.TabStop = false;
            this.serviceGroup.Text = "Services";
            // 
            // furTrimmingLabel
            // 
            this.furTrimmingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.furTrimmingLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furTrimmingLabel.Location = new System.Drawing.Point(457, 86);
            this.furTrimmingLabel.Name = "furTrimmingLabel";
            this.furTrimmingLabel.Size = new System.Drawing.Size(87, 31);
            this.furTrimmingLabel.TabIndex = 11;
            this.furTrimmingLabel.Text = "$9.00";
            this.furTrimmingLabel.Click += new System.EventHandler(this.furTrimmingLabel_Click);
            // 
            // shampooLabel
            // 
            this.shampooLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shampooLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shampooLabel.Location = new System.Drawing.Point(457, 38);
            this.shampooLabel.Name = "shampooLabel";
            this.shampooLabel.Size = new System.Drawing.Size(87, 31);
            this.shampooLabel.TabIndex = 9;
            this.shampooLabel.Text = "$4.00";
            this.shampooLabel.Click += new System.EventHandler(this.shampooLabel_Click);
            // 
            // nailClippingLabel
            // 
            this.nailClippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nailClippingLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nailClippingLabel.Location = new System.Drawing.Point(151, 86);
            this.nailClippingLabel.Name = "nailClippingLabel";
            this.nailClippingLabel.Size = new System.Drawing.Size(87, 31);
            this.nailClippingLabel.TabIndex = 10;
            this.nailClippingLabel.Text = "$4.50";
            this.nailClippingLabel.Click += new System.EventHandler(this.nailClippingLabel_Click);
            // 
            // fleaRemovalLabel
            // 
            this.fleaRemovalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fleaRemovalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fleaRemovalLabel.Location = new System.Drawing.Point(151, 38);
            this.fleaRemovalLabel.Name = "fleaRemovalLabel";
            this.fleaRemovalLabel.Size = new System.Drawing.Size(87, 31);
            this.fleaRemovalLabel.TabIndex = 8;
            this.fleaRemovalLabel.Text = "$5.00";
            this.fleaRemovalLabel.Click += new System.EventHandler(this.fleaRemovalLabel_Click);
            // 
            // totalResultLabel
            // 
            this.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalResultLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResultLabel.Location = new System.Drawing.Point(151, 133);
            this.totalResultLabel.Name = "totalResultLabel";
            this.totalResultLabel.Size = new System.Drawing.Size(87, 34);
            this.totalResultLabel.TabIndex = 0;
            this.totalResultLabel.Click += new System.EventHandler(this.totalResultLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(6, 133);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(139, 34);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total Fee:";
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(320, 76);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(122, 42);
            this.furTrimmingCheckBox.TabIndex = 11;
            this.furTrimmingCheckBox.Text = "Fur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shampooCheckBox.Location = new System.Drawing.Point(320, 28);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(122, 42);
            this.shampooCheckBox.TabIndex = 9;
            this.shampooCheckBox.Text = "Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nailClippingCheckBox.Location = new System.Drawing.Point(6, 76);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(139, 42);
            this.nailClippingCheckBox.TabIndex = 10;
            this.nailClippingCheckBox.Text = "Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(6, 28);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(139, 42);
            this.fleaRemovalCheckBox.TabIndex = 8;
            this.fleaRemovalCheckBox.Text = "Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(12, 573);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(192, 50);
            this.totalButton.TabIndex = 12;
            this.totalButton.Text = "T&otal";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(243, 573);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(192, 50);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(486, 573);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(192, 50);
            this.quitButton.TabIndex = 14;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // petBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 635);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.serviceGroup);
            this.Controls.Add(this.petGroup);
            this.Controls.Add(this.petOwnerGroup);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "petBoutique";
            this.Text = "Pet Boutique - Service Form";
            this.petOwnerGroup.ResumeLayout(false);
            this.petOwnerGroup.PerformLayout();
            this.petGroup.ResumeLayout(false);
            this.petGroup.PerformLayout();
            this.serviceGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petOwnerGroup;
        private System.Windows.Forms.GroupBox petGroup;
        private System.Windows.Forms.GroupBox serviceGroup;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.MaskedTextBox orderPhoneTextBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label orderPhoneLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.MaskedTextBox petDOBTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Label petTypeLabel;
        private System.Windows.Forms.Label petDOBLabel;
        private System.Windows.Forms.Label petNameLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.Label totalResultLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label furTrimmingLabel;
        private System.Windows.Forms.Label shampooLabel;
        private System.Windows.Forms.Label nailClippingLabel;
        private System.Windows.Forms.Label fleaRemovalLabel;
    }
}


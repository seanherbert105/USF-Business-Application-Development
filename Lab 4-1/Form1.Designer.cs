namespace Lab_4_1
{
    partial class realEstateCalculator
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
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.residentalRadioButton = new System.Windows.Forms.RadioButton();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.propertyPriceLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stateSalesTax = new System.Windows.Forms.Label();
            this.countySalesTax = new System.Windows.Forms.Label();
            this.commission = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Label();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.countyGroupBox = new System.Windows.Forms.GroupBox();
            this.propertyTypeGroupBox.SuspendLayout();
            this.countyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleDateLabel.Location = new System.Drawing.Point(27, 25);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(160, 26);
            this.saleDateLabel.TabIndex = 0;
            this.saleDateLabel.Text = "Sales Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(193, 23);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(181, 26);
            this.dateTextBox.TabIndex = 1;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            this.dateTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dateTextBox_MaskInputRejected);
            // 
            // residentalRadioButton
            // 
            this.residentalRadioButton.Checked = true;
            this.residentalRadioButton.Location = new System.Drawing.Point(6, 25);
            this.residentalRadioButton.Name = "residentalRadioButton";
            this.residentalRadioButton.Size = new System.Drawing.Size(160, 27);
            this.residentalRadioButton.TabIndex = 3;
            this.residentalRadioButton.TabStop = true;
            this.residentalRadioButton.Text = "Residental";
            this.residentalRadioButton.UseVisualStyleBackColor = true;
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.Location = new System.Drawing.Point(8, 58);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(160, 27);
            this.commercialRadioButton.TabIndex = 4;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(6, 27);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(160, 27);
            this.hillsboroughRadioButton.TabIndex = 6;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hillsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.Location = new System.Drawing.Point(6, 60);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(160, 27);
            this.pascoRadioButton.TabIndex = 7;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.Location = new System.Drawing.Point(6, 93);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(160, 27);
            this.polkRadioButton.TabIndex = 8;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // propertyPriceLabel
            // 
            this.propertyPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propertyPriceLabel.Location = new System.Drawing.Point(27, 290);
            this.propertyPriceLabel.Name = "propertyPriceLabel";
            this.propertyPriceLabel.Size = new System.Drawing.Size(160, 26);
            this.propertyPriceLabel.TabIndex = 9;
            this.propertyPriceLabel.Text = "Property Price:";
            this.propertyPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(27, 319);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(160, 48);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "&Update Property Price";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(193, 290);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(181, 26);
            this.propertyPriceTextBox.TabIndex = 11;
            this.propertyPriceTextBox.Text = "0.00";
            this.propertyPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(27, 370);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(160, 26);
            this.stateSalesTaxLabel.TabIndex = 12;
            this.stateSalesTaxLabel.Text = "State Sales Tax:";
            this.stateSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(27, 396);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(160, 26);
            this.countySalesTaxLabel.TabIndex = 13;
            this.countySalesTaxLabel.Text = "County Sales Tax:";
            this.countySalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commissionLabel
            // 
            this.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionLabel.Location = new System.Drawing.Point(27, 422);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(160, 26);
            this.commissionLabel.TabIndex = 14;
            this.commissionLabel.Text = "Commission:";
            this.commissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(27, 498);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(160, 26);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveButton.Location = new System.Drawing.Point(27, 552);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 34);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(150, 552);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 34);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(268, 552);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 34);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateSalesTax
            // 
            this.stateSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTax.Location = new System.Drawing.Point(193, 370);
            this.stateSalesTax.Name = "stateSalesTax";
            this.stateSalesTax.Size = new System.Drawing.Size(181, 26);
            this.stateSalesTax.TabIndex = 19;
            this.stateSalesTax.Text = "$0.00";
            this.stateSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countySalesTax
            // 
            this.countySalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTax.Location = new System.Drawing.Point(193, 396);
            this.countySalesTax.Name = "countySalesTax";
            this.countySalesTax.Size = new System.Drawing.Size(181, 26);
            this.countySalesTax.TabIndex = 20;
            this.countySalesTax.Text = "$0.00";
            this.countySalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commission
            // 
            this.commission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commission.Location = new System.Drawing.Point(193, 422);
            this.commission.Name = "commission";
            this.commission.Size = new System.Drawing.Size(181, 26);
            this.commission.TabIndex = 21;
            this.commission.Text = "$0.00";
            this.commission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPrice
            // 
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPrice.Location = new System.Drawing.Point(193, 498);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(181, 26);
            this.totalPrice.TabIndex = 22;
            this.totalPrice.Text = "$0.00";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.SystemColors.ControlText;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(27, 469);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(347, 10);
            this.border.TabIndex = 23;
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.residentalRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(27, 54);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(160, 99);
            this.propertyTypeGroupBox.TabIndex = 24;
            this.propertyTypeGroupBox.TabStop = false;
            this.propertyTypeGroupBox.Text = "Property Type";
            // 
            // countyGroupBox
            // 
            this.countyGroupBox.Controls.Add(this.hillsboroughRadioButton);
            this.countyGroupBox.Controls.Add(this.pascoRadioButton);
            this.countyGroupBox.Controls.Add(this.polkRadioButton);
            this.countyGroupBox.Location = new System.Drawing.Point(27, 159);
            this.countyGroupBox.Name = "countyGroupBox";
            this.countyGroupBox.Size = new System.Drawing.Size(160, 128);
            this.countyGroupBox.TabIndex = 25;
            this.countyGroupBox.TabStop = false;
            this.countyGroupBox.Text = "County";
            // 
            // realEstateCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 607);
            this.Controls.Add(this.countyGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.border);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.commission);
            this.Controls.Add(this.countySalesTax);
            this.Controls.Add(this.stateSalesTax);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.propertyPriceLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.saleDateLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "realEstateCalculator";
            this.Text = "Real Estate Calculator";
            this.Load += new System.EventHandler(this.realEstateCalculator_Load);
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.countyGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.RadioButton residentalRadioButton;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.Label propertyPriceLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label stateSalesTax;
        private System.Windows.Forms.Label countySalesTax;
        private System.Windows.Forms.Label commission;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.GroupBox countyGroupBox;
    }
}


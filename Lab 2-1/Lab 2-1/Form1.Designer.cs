namespace Lab_2_1
{
    partial class Form1
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
            this.carpetCalculator = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.GroupBox();
            this.carpetLengthText = new System.Windows.Forms.TextBox();
            this.carpetWidthText = new System.Windows.Forms.TextBox();
            this.carpetLengthLabel = new System.Windows.Forms.Label();
            this.carpetWidthLabel = new System.Windows.Forms.Label();
            this.carpetPriceLabel = new System.Windows.Forms.Label();
            this.carpetAreaLabel = new System.Windows.Forms.Label();
            this.carpetChargeLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.laborChargeLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.carpetAreaBlank = new System.Windows.Forms.Label();
            this.carpetChargeBlank = new System.Windows.Forms.Label();
            this.salesTaxBlank = new System.Windows.Forms.Label();
            this.laborChargeBlank = new System.Windows.Forms.Label();
            this.orderTotalBlank = new System.Windows.Forms.Label();
            this.divider2 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.carpetPriceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carpetCalculator
            // 
            this.carpetCalculator.BackColor = System.Drawing.Color.White;
            this.carpetCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetCalculator.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetCalculator.Location = new System.Drawing.Point(61, 9);
            this.carpetCalculator.Name = "carpetCalculator";
            this.carpetCalculator.Size = new System.Drawing.Size(387, 33);
            this.carpetCalculator.TabIndex = 0;
            this.carpetCalculator.Text = "Carpet Calculator";
            this.carpetCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.carpetCalculator.Click += new System.EventHandler(this.carpetCalculator_Click);
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.Black;
            this.divider1.Location = new System.Drawing.Point(-3, 130);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(738, 3);
            this.divider1.TabIndex = 1;
            this.divider1.TabStop = false;
            this.divider1.Enter += new System.EventHandler(this.divider1_Enter);
            // 
            // carpetLengthText
            // 
            this.carpetLengthText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetLengthText.Location = new System.Drawing.Point(61, 98);
            this.carpetLengthText.Name = "carpetLengthText";
            this.carpetLengthText.Size = new System.Drawing.Size(87, 22);
            this.carpetLengthText.TabIndex = 1;
            this.carpetLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.carpetLengthText.TextChanged += new System.EventHandler(this.carpetLengthText_TextChanged);
            // 
            // carpetWidthText
            // 
            this.carpetWidthText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetWidthText.Location = new System.Drawing.Point(206, 98);
            this.carpetWidthText.Name = "carpetWidthText";
            this.carpetWidthText.Size = new System.Drawing.Size(87, 22);
            this.carpetWidthText.TabIndex = 2;
            this.carpetWidthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.carpetWidthText.TextChanged += new System.EventHandler(this.carpetWidthText_TextChanged);
            // 
            // carpetLengthLabel
            // 
            this.carpetLengthLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetLengthLabel.Location = new System.Drawing.Point(58, 57);
            this.carpetLengthLabel.Name = "carpetLengthLabel";
            this.carpetLengthLabel.Size = new System.Drawing.Size(90, 38);
            this.carpetLengthLabel.TabIndex = 0;
            this.carpetLengthLabel.Text = "Carpet Length (feet)";
            this.carpetLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carpetLengthLabel.Click += new System.EventHandler(this.carpetLengthLabel_Click);
            // 
            // carpetWidthLabel
            // 
            this.carpetWidthLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetWidthLabel.Location = new System.Drawing.Point(203, 57);
            this.carpetWidthLabel.Name = "carpetWidthLabel";
            this.carpetWidthLabel.Size = new System.Drawing.Size(90, 38);
            this.carpetWidthLabel.TabIndex = 0;
            this.carpetWidthLabel.Text = "Carpet Width (feet)";
            this.carpetWidthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carpetWidthLabel.Click += new System.EventHandler(this.carpetWidthLabel_Click);
            // 
            // carpetPriceLabel
            // 
            this.carpetPriceLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetPriceLabel.Location = new System.Drawing.Point(358, 57);
            this.carpetPriceLabel.Name = "carpetPriceLabel";
            this.carpetPriceLabel.Size = new System.Drawing.Size(90, 38);
            this.carpetPriceLabel.TabIndex = 0;
            this.carpetPriceLabel.Text = "Carpet Price ($/sq. ft.)";
            this.carpetPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carpetPriceLabel.Click += new System.EventHandler(this.carpetPriceLabel_Click);
            // 
            // carpetAreaLabel
            // 
            this.carpetAreaLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetAreaLabel.Location = new System.Drawing.Point(58, 153);
            this.carpetAreaLabel.Name = "carpetAreaLabel";
            this.carpetAreaLabel.Size = new System.Drawing.Size(186, 38);
            this.carpetAreaLabel.TabIndex = 0;
            this.carpetAreaLabel.Text = "Carpet Area (sq. ft.)";
            this.carpetAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carpetAreaLabel.Click += new System.EventHandler(this.carpetAreaLabel_Click);
            // 
            // carpetChargeLabel
            // 
            this.carpetChargeLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetChargeLabel.Location = new System.Drawing.Point(58, 204);
            this.carpetChargeLabel.Name = "carpetChargeLabel";
            this.carpetChargeLabel.Size = new System.Drawing.Size(186, 38);
            this.carpetChargeLabel.TabIndex = 0;
            this.carpetChargeLabel.Text = "Carpet Charge";
            this.carpetChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carpetChargeLabel.Click += new System.EventHandler(this.carpetChargeLabel_Click);
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxLabel.Location = new System.Drawing.Point(58, 257);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(186, 38);
            this.salesTaxLabel.TabIndex = 0;
            this.salesTaxLabel.Text = "Sales Tax (7.0%) on Carpet";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salesTaxLabel.Click += new System.EventHandler(this.salesTaxLabel_Click);
            // 
            // laborChargeLabel
            // 
            this.laborChargeLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborChargeLabel.Location = new System.Drawing.Point(58, 317);
            this.laborChargeLabel.Name = "laborChargeLabel";
            this.laborChargeLabel.Size = new System.Drawing.Size(186, 38);
            this.laborChargeLabel.TabIndex = 0;
            this.laborChargeLabel.Text = "Labor Charge ($0.50/ sq. ft.)";
            this.laborChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laborChargeLabel.Click += new System.EventHandler(this.laborChargeLabel_Click);
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalLabel.Location = new System.Drawing.Point(58, 373);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(186, 38);
            this.orderTotalLabel.TabIndex = 0;
            this.orderTotalLabel.Text = "Order Total";
            this.orderTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.orderTotalLabel.Click += new System.EventHandler(this.orderTotalLabel_Click);
            // 
            // carpetAreaBlank
            // 
            this.carpetAreaBlank.BackColor = System.Drawing.Color.White;
            this.carpetAreaBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetAreaBlank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetAreaBlank.Location = new System.Drawing.Point(268, 156);
            this.carpetAreaBlank.Name = "carpetAreaBlank";
            this.carpetAreaBlank.Size = new System.Drawing.Size(88, 33);
            this.carpetAreaBlank.TabIndex = 0;
            this.carpetAreaBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carpetAreaBlank.Click += new System.EventHandler(this.carpetAreaBlank_Click);
            // 
            // carpetChargeBlank
            // 
            this.carpetChargeBlank.BackColor = System.Drawing.Color.White;
            this.carpetChargeBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetChargeBlank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetChargeBlank.Location = new System.Drawing.Point(268, 207);
            this.carpetChargeBlank.Name = "carpetChargeBlank";
            this.carpetChargeBlank.Size = new System.Drawing.Size(88, 33);
            this.carpetChargeBlank.TabIndex = 0;
            this.carpetChargeBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carpetChargeBlank.Click += new System.EventHandler(this.carpetChargeBlank_Click);
            // 
            // salesTaxBlank
            // 
            this.salesTaxBlank.BackColor = System.Drawing.Color.White;
            this.salesTaxBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxBlank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxBlank.Location = new System.Drawing.Point(268, 260);
            this.salesTaxBlank.Name = "salesTaxBlank";
            this.salesTaxBlank.Size = new System.Drawing.Size(88, 33);
            this.salesTaxBlank.TabIndex = 0;
            this.salesTaxBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salesTaxBlank.Click += new System.EventHandler(this.salesTaxBlank_Click);
            // 
            // laborChargeBlank
            // 
            this.laborChargeBlank.BackColor = System.Drawing.Color.White;
            this.laborChargeBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborChargeBlank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborChargeBlank.Location = new System.Drawing.Point(268, 320);
            this.laborChargeBlank.Name = "laborChargeBlank";
            this.laborChargeBlank.Size = new System.Drawing.Size(88, 33);
            this.laborChargeBlank.TabIndex = 0;
            this.laborChargeBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laborChargeBlank.Click += new System.EventHandler(this.laborChargeBlank_Click);
            // 
            // orderTotalBlank
            // 
            this.orderTotalBlank.BackColor = System.Drawing.Color.White;
            this.orderTotalBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderTotalBlank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalBlank.Location = new System.Drawing.Point(268, 376);
            this.orderTotalBlank.Name = "orderTotalBlank";
            this.orderTotalBlank.Size = new System.Drawing.Size(88, 33);
            this.orderTotalBlank.TabIndex = 0;
            this.orderTotalBlank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.orderTotalBlank.Click += new System.EventHandler(this.orderTotalBlank_Click);
            // 
            // divider2
            // 
            this.divider2.BackColor = System.Drawing.Color.Black;
            this.divider2.Location = new System.Drawing.Point(-3, 426);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(738, 3);
            this.divider2.TabIndex = 18;
            this.divider2.TabStop = false;
            this.divider2.Enter += new System.EventHandler(this.divider2_Enter);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(29, 458);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 38);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(206, 458);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 38);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(380, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // carpetPriceText
            // 
            this.carpetPriceText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetPriceText.Location = new System.Drawing.Point(361, 98);
            this.carpetPriceText.Name = "carpetPriceText";
            this.carpetPriceText.Size = new System.Drawing.Size(87, 22);
            this.carpetPriceText.TabIndex = 3;
            this.carpetPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.carpetPriceText.TextChanged += new System.EventHandler(this.carpetPriceText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 559);
            this.Controls.Add(this.carpetPriceText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.divider2);
            this.Controls.Add(this.orderTotalBlank);
            this.Controls.Add(this.laborChargeBlank);
            this.Controls.Add(this.salesTaxBlank);
            this.Controls.Add(this.carpetChargeBlank);
            this.Controls.Add(this.carpetAreaBlank);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.laborChargeLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.carpetChargeLabel);
            this.Controls.Add(this.carpetAreaLabel);
            this.Controls.Add(this.carpetPriceLabel);
            this.Controls.Add(this.carpetWidthLabel);
            this.Controls.Add(this.carpetLengthLabel);
            this.Controls.Add(this.carpetWidthText);
            this.Controls.Add(this.carpetLengthText);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.carpetCalculator);
            this.Name = "Form1";
            this.Text = "Carpet Kingdom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carpetCalculator;
        private System.Windows.Forms.GroupBox divider1;
        private System.Windows.Forms.TextBox carpetLengthText;
        private System.Windows.Forms.TextBox carpetWidthText;
        private System.Windows.Forms.Label carpetLengthLabel;
        private System.Windows.Forms.Label carpetWidthLabel;
        private System.Windows.Forms.Label carpetPriceLabel;
        private System.Windows.Forms.Label carpetAreaLabel;
        private System.Windows.Forms.Label carpetChargeLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label laborChargeLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label carpetAreaBlank;
        private System.Windows.Forms.Label carpetChargeBlank;
        private System.Windows.Forms.Label salesTaxBlank;
        private System.Windows.Forms.Label laborChargeBlank;
        private System.Windows.Forms.Label orderTotalBlank;
        private System.Windows.Forms.GroupBox divider2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox carpetPriceText;
    }
}


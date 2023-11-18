namespace Lab_5_1
{
    partial class joeIceCreamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(joeIceCreamForm));
            this.iceCreamPicture = new System.Windows.Forms.PictureBox();
            this.coneTypeLabel = new System.Windows.Forms.Label();
            this.iceCreamFlavorLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.iceCreamFlavorComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.sugarConeRadioButton = new System.Windows.Forms.RadioButton();
            this.waffleConeRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iceCreamPicture
            // 
            this.iceCreamPicture.Image = ((System.Drawing.Image)(resources.GetObject("iceCreamPicture.Image")));
            this.iceCreamPicture.Location = new System.Drawing.Point(18, 18);
            this.iceCreamPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iceCreamPicture.Name = "iceCreamPicture";
            this.iceCreamPicture.Size = new System.Drawing.Size(420, 341);
            this.iceCreamPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iceCreamPicture.TabIndex = 0;
            this.iceCreamPicture.TabStop = false;
            // 
            // coneTypeLabel
            // 
            this.coneTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coneTypeLabel.Location = new System.Drawing.Point(18, 375);
            this.coneTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coneTypeLabel.Name = "coneTypeLabel";
            this.coneTypeLabel.Size = new System.Drawing.Size(136, 33);
            this.coneTypeLabel.TabIndex = 1;
            this.coneTypeLabel.Text = "Cone Type";
            // 
            // iceCreamFlavorLabel
            // 
            this.iceCreamFlavorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iceCreamFlavorLabel.Location = new System.Drawing.Point(18, 431);
            this.iceCreamFlavorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iceCreamFlavorLabel.Name = "iceCreamFlavorLabel";
            this.iceCreamFlavorLabel.Size = new System.Drawing.Size(136, 33);
            this.iceCreamFlavorLabel.TabIndex = 2;
            this.iceCreamFlavorLabel.Text = "Ice Cream Flavor";
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppingsLabel.Location = new System.Drawing.Point(18, 489);
            this.toppingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(136, 33);
            this.toppingsLabel.TabIndex = 3;
            this.toppingsLabel.Text = "Toppings";
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.ItemHeight = 19;
            this.toppingsListBox.Location = new System.Drawing.Point(161, 489);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(170, 137);
            this.toppingsListBox.TabIndex = 4;
            // 
            // iceCreamFlavorComboBox
            // 
            this.iceCreamFlavorComboBox.FormattingEnabled = true;
            this.iceCreamFlavorComboBox.Location = new System.Drawing.Point(161, 437);
            this.iceCreamFlavorComboBox.Name = "iceCreamFlavorComboBox";
            this.iceCreamFlavorComboBox.Size = new System.Drawing.Size(170, 27);
            this.iceCreamFlavorComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(18, 670);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 37);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(302, 670);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 37);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sugarConeRadioButton
            // 
            this.sugarConeRadioButton.Checked = true;
            this.sugarConeRadioButton.Location = new System.Drawing.Point(161, 378);
            this.sugarConeRadioButton.Name = "sugarConeRadioButton";
            this.sugarConeRadioButton.Size = new System.Drawing.Size(107, 30);
            this.sugarConeRadioButton.TabIndex = 8;
            this.sugarConeRadioButton.TabStop = true;
            this.sugarConeRadioButton.Text = "Sugar Cone";
            this.sugarConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // waffleConeRadioButton
            // 
            this.waffleConeRadioButton.Location = new System.Drawing.Point(297, 378);
            this.waffleConeRadioButton.Name = "waffleConeRadioButton";
            this.waffleConeRadioButton.Size = new System.Drawing.Size(107, 30);
            this.waffleConeRadioButton.TabIndex = 9;
            this.waffleConeRadioButton.Text = "Waffle Cone";
            this.waffleConeRadioButton.UseVisualStyleBackColor = true;
            // 
            // joeIceCreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 724);
            this.Controls.Add(this.waffleConeRadioButton);
            this.Controls.Add(this.sugarConeRadioButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.iceCreamFlavorComboBox);
            this.Controls.Add(this.toppingsListBox);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.iceCreamFlavorLabel);
            this.Controls.Add(this.coneTypeLabel);
            this.Controls.Add(this.iceCreamPicture);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "joeIceCreamForm";
            this.Text = "Joe\'s Ice Cream Emporium";
            this.Load += new System.EventHandler(this.joeIceCreamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iceCreamPicture;
        private System.Windows.Forms.Label coneTypeLabel;
        private System.Windows.Forms.Label iceCreamFlavorLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.ComboBox iceCreamFlavorComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton sugarConeRadioButton;
        private System.Windows.Forms.RadioButton waffleConeRadioButton;
    }
}


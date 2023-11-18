namespace Lab_1_2
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.fallButton = new System.Windows.Forms.Button();
            this.winterButton = new System.Windows.Forms.Button();
            this.springButton = new System.Windows.Forms.Button();
            this.summerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.seasonsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(58, 46);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(128, 32);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Choose a Season";
            this.instructionLabel.Click += new System.EventHandler(this.instructionLabel_Click);
            // 
            // fallButton
            // 
            this.fallButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallButton.Location = new System.Drawing.Point(62, 81);
            this.fallButton.Name = "fallButton";
            this.fallButton.Size = new System.Drawing.Size(114, 36);
            this.fallButton.TabIndex = 1;
            this.fallButton.Text = "Fall";
            this.fallButton.UseVisualStyleBackColor = true;
            this.fallButton.Click += new System.EventHandler(this.fallButton_Click);
            // 
            // winterButton
            // 
            this.winterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winterButton.Location = new System.Drawing.Point(62, 132);
            this.winterButton.Name = "winterButton";
            this.winterButton.Size = new System.Drawing.Size(114, 35);
            this.winterButton.TabIndex = 2;
            this.winterButton.Text = "Winter";
            this.winterButton.UseVisualStyleBackColor = true;
            this.winterButton.Click += new System.EventHandler(this.winterButton_Click);
            // 
            // springButton
            // 
            this.springButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.springButton.Location = new System.Drawing.Point(62, 184);
            this.springButton.Name = "springButton";
            this.springButton.Size = new System.Drawing.Size(114, 37);
            this.springButton.TabIndex = 3;
            this.springButton.Text = "Spring";
            this.springButton.UseVisualStyleBackColor = true;
            this.springButton.Click += new System.EventHandler(this.springButton_Click);
            // 
            // summerButton
            // 
            this.summerButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerButton.Location = new System.Drawing.Point(62, 239);
            this.summerButton.Name = "summerButton";
            this.summerButton.Size = new System.Drawing.Size(114, 38);
            this.summerButton.TabIndex = 4;
            this.summerButton.Text = "Summer";
            this.summerButton.UseVisualStyleBackColor = true;
            this.summerButton.Click += new System.EventHandler(this.summerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(201, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // seasonsPictureBox
            // 
            this.seasonsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seasonsPictureBox.InitialImage = global::Lab_1_2.Properties.Resources.Fall;
            this.seasonsPictureBox.Location = new System.Drawing.Point(201, 46);
            this.seasonsPictureBox.Name = "seasonsPictureBox";
            this.seasonsPictureBox.Size = new System.Drawing.Size(285, 284);
            this.seasonsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.seasonsPictureBox.TabIndex = 6;
            this.seasonsPictureBox.TabStop = false;
            this.seasonsPictureBox.Click += new System.EventHandler(this.seasonsPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seasonsPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summerButton);
            this.Controls.Add(this.springButton);
            this.Controls.Add(this.winterButton);
            this.Controls.Add(this.fallButton);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.seasonsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button fallButton;
        private System.Windows.Forms.Button winterButton;
        private System.Windows.Forms.Button springButton;
        private System.Windows.Forms.Button summerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox seasonsPictureBox;
    }
}


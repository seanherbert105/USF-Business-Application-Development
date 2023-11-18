namespace Lab_1_1
{
    partial class FirstProject
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
            this.greetingButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // greetingButton
            // 
            this.greetingButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingButton.Location = new System.Drawing.Point(248, 167);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(130, 44);
            this.greetingButton.TabIndex = 0;
            this.greetingButton.Text = "Greeting";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(248, 236);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 40);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(198, 28);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(238, 69);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = "Enter your first name in the box below and then click on the Greeting Button.";
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(162, 100);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(322, 26);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // FirstProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.greetingButton);
            this.Name = "FirstProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
    }
}


namespace KriptoNote
{
    partial class Encrypt
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
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordstrengthProgressBar = new System.Windows.Forms.ProgressBar();
            this.passwordstrengthLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(120, 11);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(371, 20);
            this.fileTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(497, 6);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 15);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(29, 13);
            this.fileLabel.TabIndex = 2;
            this.fileLabel.Text = "File: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password: ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(120, 50);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(371, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(497, 48);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate...";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordstrengthProgressBar
            // 
            this.passwordstrengthProgressBar.Location = new System.Drawing.Point(120, 76);
            this.passwordstrengthProgressBar.Name = "passwordstrengthProgressBar";
            this.passwordstrengthProgressBar.Size = new System.Drawing.Size(452, 23);
            this.passwordstrengthProgressBar.TabIndex = 6;
            // 
            // passwordstrengthLabel
            // 
            this.passwordstrengthLabel.AutoSize = true;
            this.passwordstrengthLabel.Location = new System.Drawing.Point(12, 76);
            this.passwordstrengthLabel.Name = "passwordstrengthLabel";
            this.passwordstrengthLabel.Size = new System.Drawing.Size(102, 13);
            this.passwordstrengthLabel.TabIndex = 7;
            this.passwordstrengthLabel.Text = "Password Strength: \r\n";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(497, 126);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 8;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(416, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.passwordstrengthLabel);
            this.Controls.Add(this.passwordstrengthProgressBar);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.fileTextBox);
            this.Name = "Encrypt";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ProgressBar passwordstrengthProgressBar;
        private System.Windows.Forms.Label passwordstrengthLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
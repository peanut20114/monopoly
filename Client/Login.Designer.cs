namespace Client
{
    partial class Login
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
            this.AccountInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.RichTextBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountInput
            // 
            this.AccountInput.Location = new System.Drawing.Point(272, 394);
            this.AccountInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountInput.Name = "AccountInput";
            this.AccountInput.Size = new System.Drawing.Size(604, 52);
            this.AccountInput.TabIndex = 0;
            this.AccountInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your email or user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 472);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.HideSelection = false;
            this.PasswordInput.Location = new System.Drawing.Point(272, 531);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(604, 52);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.Text = "";
            // 
            // continueBtn
            // 
            this.continueBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.Location = new System.Drawing.Point(475, 611);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(220, 61);
            this.continueBtn.TabIndex = 4;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.Help;
            this.ClientSize = new System.Drawing.Size(1168, 694);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AccountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox PasswordInput;
        private System.Windows.Forms.Button continueBtn;
    }
}
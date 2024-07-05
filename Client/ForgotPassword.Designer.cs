namespace Client
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.Error = new System.Windows.Forms.Label();
            this.otpBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendCodeBtn = new System.Windows.Forms.Button();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorOTP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(132, 89);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 18);
            this.Error.TabIndex = 15;
            // 
            // otpBox
            // 
            this.otpBox.HideSelection = false;
            this.otpBox.Location = new System.Drawing.Point(126, 117);
            this.otpBox.Margin = new System.Windows.Forms.Padding(2);
            this.otpBox.Name = "otpBox";
            this.otpBox.Size = new System.Drawing.Size(170, 20);
            this.otpBox.TabIndex = 13;
            this.otpBox.TextChanged += new System.EventHandler(this.otpBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(126, 51);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(253, 20);
            this.emailBox.TabIndex = 12;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(170, 170);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(152, 32);
            this.changeBtn.TabIndex = 11;
            this.changeBtn.Text = "Change Password";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Your registration email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "One-Time Password code:";
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCodeBtn.Location = new System.Drawing.Point(300, 109);
            this.sendCodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(79, 32);
            this.sendCodeBtn.TabIndex = 24;
            this.sendCodeBtn.Text = "Send";
            this.sendCodeBtn.UseVisualStyleBackColor = true;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.BackColor = System.Drawing.Color.Transparent;
            this.errorEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.Brown;
            this.errorEmail.Location = new System.Drawing.Point(137, 73);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(0, 20);
            this.errorEmail.TabIndex = 25;
            // 
            // errorOTP
            // 
            this.errorOTP.AutoSize = true;
            this.errorOTP.BackColor = System.Drawing.Color.Transparent;
            this.errorOTP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorOTP.ForeColor = System.Drawing.Color.Brown;
            this.errorOTP.Location = new System.Drawing.Point(137, 139);
            this.errorOTP.Name = "errorOTP";
            this.errorOTP.Size = new System.Drawing.Size(0, 20);
            this.errorOTP.TabIndex = 26;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(490, 220);
            this.Controls.Add(this.errorOTP);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.otpBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.changeBtn);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.TextBox otpBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendCodeBtn;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorOTP;
    }
}
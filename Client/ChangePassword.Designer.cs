namespace Client
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.oldPassBox = new System.Windows.Forms.RichTextBox();
            this.newPassBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passAuthBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.errorOldPass = new System.Windows.Forms.Label();
            this.errorNewPass = new System.Windows.Forms.Label();
            this.errorPassAuth = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // oldPassBox
            // 
            this.oldPassBox.Location = new System.Drawing.Point(46, 32);
            this.oldPassBox.Name = "oldPassBox";
            this.oldPassBox.Size = new System.Drawing.Size(168, 20);
            this.oldPassBox.TabIndex = 8;
            this.oldPassBox.Text = "";
            this.oldPassBox.TextChanged += new System.EventHandler(this.oldPassBox_TextChanged);
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(46, 89);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(168, 20);
            this.newPassBox.TabIndex = 9;
            this.newPassBox.Text = "";
            this.newPassBox.TextChanged += new System.EventHandler(this.newPassBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Old Password:";
            // 
            // passAuthBox
            // 
            this.passAuthBox.Location = new System.Drawing.Point(46, 148);
            this.passAuthBox.Name = "passAuthBox";
            this.passAuthBox.Size = new System.Drawing.Size(168, 20);
            this.passAuthBox.TabIndex = 11;
            this.passAuthBox.Text = "";
            this.passAuthBox.TextChanged += new System.EventHandler(this.passAuthBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm New Password:";
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(274, 140);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(110, 32);
            this.changeBtn.TabIndex = 15;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // errorOldPass
            // 
            this.errorOldPass.AutoSize = true;
            this.errorOldPass.BackColor = System.Drawing.Color.Transparent;
            this.errorOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorOldPass.ForeColor = System.Drawing.Color.Red;
            this.errorOldPass.Location = new System.Drawing.Point(57, 52);
            this.errorOldPass.Name = "errorOldPass";
            this.errorOldPass.Size = new System.Drawing.Size(0, 16);
            this.errorOldPass.TabIndex = 16;
            // 
            // errorNewPass
            // 
            this.errorNewPass.AutoSize = true;
            this.errorNewPass.BackColor = System.Drawing.Color.Transparent;
            this.errorNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNewPass.ForeColor = System.Drawing.Color.Red;
            this.errorNewPass.Location = new System.Drawing.Point(75, 110);
            this.errorNewPass.Name = "errorNewPass";
            this.errorNewPass.Size = new System.Drawing.Size(0, 16);
            this.errorNewPass.TabIndex = 17;
            // 
            // errorPassAuth
            // 
            this.errorPassAuth.AutoSize = true;
            this.errorPassAuth.BackColor = System.Drawing.Color.Transparent;
            this.errorPassAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassAuth.ForeColor = System.Drawing.Color.Red;
            this.errorPassAuth.Location = new System.Drawing.Point(45, 169);
            this.errorPassAuth.Name = "errorPassAuth";
            this.errorPassAuth.Size = new System.Drawing.Size(0, 16);
            this.errorPassAuth.TabIndex = 18;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(249, 32);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(157, 77);
            this.errorBox.TabIndex = 19;
            this.errorBox.Text = "";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 197);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.errorPassAuth);
            this.Controls.Add(this.errorNewPass);
            this.Controls.Add(this.errorOldPass);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passAuthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.oldPassBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePassword_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox oldPassBox;
        private System.Windows.Forms.RichTextBox newPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox passAuthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label errorOldPass;
        private System.Windows.Forms.Label errorNewPass;
        private System.Windows.Forms.Label errorPassAuth;
        private System.Windows.Forms.RichTextBox errorBox;
    }
}
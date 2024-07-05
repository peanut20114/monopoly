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
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.passAuthBox = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorNewPass = new System.Windows.Forms.Label();
            this.errorPassAuth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(34, 35);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Size = new System.Drawing.Size(191, 20);
            this.newPassBox.TabIndex = 0;
            // 
            // passAuthBox
            // 
            this.passAuthBox.Location = new System.Drawing.Point(34, 97);
            this.passAuthBox.Name = "passAuthBox";
            this.passAuthBox.Size = new System.Drawing.Size(191, 20);
            this.passAuthBox.TabIndex = 1;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(245, 12);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(161, 63);
            this.errorBox.TabIndex = 2;
            this.errorBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm New Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // errorNewPass
            // 
            this.errorNewPass.AutoSize = true;
            this.errorNewPass.BackColor = System.Drawing.Color.Transparent;
            this.errorNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNewPass.ForeColor = System.Drawing.Color.Brown;
            this.errorNewPass.Location = new System.Drawing.Point(33, 57);
            this.errorNewPass.Name = "errorNewPass";
            this.errorNewPass.Size = new System.Drawing.Size(0, 18);
            this.errorNewPass.TabIndex = 6;
            this.errorNewPass.TextChanged += new System.EventHandler(this.newPassBox_TextChanged);
            // 
            // errorPassAuth
            // 
            this.errorPassAuth.AutoSize = true;
            this.errorPassAuth.BackColor = System.Drawing.Color.Transparent;
            this.errorPassAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassAuth.ForeColor = System.Drawing.Color.Brown;
            this.errorPassAuth.Location = new System.Drawing.Point(33, 120);
            this.errorPassAuth.Name = "errorPassAuth";
            this.errorPassAuth.Size = new System.Drawing.Size(0, 18);
            this.errorPassAuth.TabIndex = 7;
            this.errorPassAuth.TextChanged += new System.EventHandler(this.passAuthBox_TextChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 197);
            this.Controls.Add(this.errorPassAuth);
            this.Controls.Add(this.errorNewPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.passAuthBox);
            this.Controls.Add(this.newPassBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newPassBox;
        private System.Windows.Forms.TextBox passAuthBox;
        private System.Windows.Forms.RichTextBox errorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorNewPass;
        private System.Windows.Forms.Label errorPassAuth;
    }
}
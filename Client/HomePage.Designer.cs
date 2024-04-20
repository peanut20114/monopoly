namespace Client
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_PlayGame = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_Friends = new System.Windows.Forms.Button();
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(618, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_PlayGame
            // 
            this.btn_PlayGame.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PlayGame.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayGame.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_PlayGame.Location = new System.Drawing.Point(656, 519);
            this.btn_PlayGame.Name = "btn_PlayGame";
            this.btn_PlayGame.Size = new System.Drawing.Size(131, 39);
            this.btn_PlayGame.TabIndex = 2;
            this.btn_PlayGame.Text = "Play Game";
            this.btn_PlayGame.UseVisualStyleBackColor = false;
            this.btn_PlayGame.Click += new System.EventHandler(this.btn_PlayGame_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_LogOut.Location = new System.Drawing.Point(802, 519);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(133, 39);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Twenty Team: Board Game Monopoly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "RANKINGS";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(655, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 170);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Friends
            // 
            this.btn_Friends.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Friends.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Friends.Location = new System.Drawing.Point(811, 386);
            this.btn_Friends.Name = "btn_Friends";
            this.btn_Friends.Size = new System.Drawing.Size(127, 35);
            this.btn_Friends.TabIndex = 7;
            this.btn_Friends.Text = "Friends";
            this.btn_Friends.UseVisualStyleBackColor = true;
            this.btn_Friends.Click += new System.EventHandler(this.btn_Friends_Click);
            // 
            // btn_Messages
            // 
            this.btn_Messages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Messages.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Messages.Location = new System.Drawing.Point(811, 430);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Size = new System.Drawing.Size(127, 35);
            this.btn_Messages.TabIndex = 8;
            this.btn_Messages.Text = "Event";
            this.btn_Messages.UseVisualStyleBackColor = true;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Profile.Location = new System.Drawing.Point(650, 386);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(127, 35);
            this.btn_Profile.TabIndex = 9;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_History
            // 
            this.btn_History.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_History.Location = new System.Drawing.Point(650, 430);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(127, 35);
            this.btn_History.TabIndex = 10;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.btn_Messages);
            this.Controls.Add(this.btn_Friends);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_PlayGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_PlayGame;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Friends;
        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_History;
    }
}
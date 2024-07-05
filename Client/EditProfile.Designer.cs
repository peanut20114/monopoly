namespace Client
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.nameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorOldPass = new System.Windows.Forms.Label();
            this.errorNewPass = new System.Windows.Forms.Label();
            this.errorPassAuth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.introBox = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(16, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(168, 20);
            this.nameBox.TabIndex = 19;
            this.nameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username:";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(261, 30);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(174, 20);
            this.countryBox.TabIndex = 22;
            this.countryBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Country:";
            // 
            // errorOldPass
            // 
            this.errorOldPass.AutoSize = true;
            this.errorOldPass.BackColor = System.Drawing.Color.Transparent;
            this.errorOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorOldPass.ForeColor = System.Drawing.Color.Red;
            this.errorOldPass.Location = new System.Drawing.Point(162, 42);
            this.errorOldPass.Name = "errorOldPass";
            this.errorOldPass.Size = new System.Drawing.Size(0, 16);
            this.errorOldPass.TabIndex = 25;
            // 
            // errorNewPass
            // 
            this.errorNewPass.AutoSize = true;
            this.errorNewPass.BackColor = System.Drawing.Color.Transparent;
            this.errorNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNewPass.ForeColor = System.Drawing.Color.Red;
            this.errorNewPass.Location = new System.Drawing.Point(179, 33);
            this.errorNewPass.Name = "errorNewPass";
            this.errorNewPass.Size = new System.Drawing.Size(0, 16);
            this.errorNewPass.TabIndex = 26;
            // 
            // errorPassAuth
            // 
            this.errorPassAuth.AutoSize = true;
            this.errorPassAuth.BackColor = System.Drawing.Color.Transparent;
            this.errorPassAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassAuth.ForeColor = System.Drawing.Color.Red;
            this.errorPassAuth.Location = new System.Drawing.Point(146, 99);
            this.errorPassAuth.Name = "errorPassAuth";
            this.errorPassAuth.Size = new System.Drawing.Size(0, 16);
            this.errorPassAuth.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox.Location = new System.Drawing.Point(16, 75);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(57, 21);
            this.dayBox.TabIndex = 29;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(79, 75);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(105, 21);
            this.monthBox.TabIndex = 30;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.yearBox.Location = new System.Drawing.Point(190, 75);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(75, 21);
            this.yearBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "About me:";
            // 
            // introBox
            // 
            this.introBox.Location = new System.Drawing.Point(16, 125);
            this.introBox.Name = "introBox";
            this.introBox.Size = new System.Drawing.Size(419, 77);
            this.introBox.TabIndex = 33;
            this.introBox.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(471, 170);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(110, 32);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 217);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.introBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorPassAuth);
            this.Controls.Add(this.errorNewPass);
            this.Controls.Add(this.errorOldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox countryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorOldPass;
        private System.Windows.Forms.Label errorNewPass;
        private System.Windows.Forms.Label errorPassAuth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox introBox;
        private System.Windows.Forms.Button saveBtn;
    }
}
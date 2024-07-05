namespace Client
{
    partial class Mission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission));
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.claimBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.pointCol,
            this.statusCol});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 104);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1116, 348);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Missions";
            this.nameCol.Width = 300;
            // 
            // pointCol
            // 
            this.pointCol.Text = "Bonus Point";
            this.pointCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointCol.Width = 110;
            // 
            // statusCol
            // 
            this.statusCol.Text = "Progress";
            this.statusCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusCol.Width = 110;
            // 
            // claimBtn
            // 
            this.claimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimBtn.Location = new System.Drawing.Point(976, 23);
            this.claimBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.claimBtn.Name = "claimBtn";
            this.claimBtn.Size = new System.Drawing.Size(168, 56);
            this.claimBtn.TabIndex = 3;
            this.claimBtn.Text = "Claim";
            this.claimBtn.UseVisualStyleBackColor = true;
            this.claimBtn.Click += new System.EventHandler(this.claimBtn_Click);
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1168, 479);
            this.Controls.Add(this.claimBtn);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Mission";
            this.Text = "Daily Mission";
            this.Load += new System.EventHandler(this.Mission_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader pointCol;
        private System.Windows.Forms.ColumnHeader statusCol;
        private System.Windows.Forms.Button claimBtn;
    }
}
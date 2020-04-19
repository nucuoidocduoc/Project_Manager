namespace QLDA.View.Common
{
    partial class XemTheoDuAnLv1
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvDanhSachLv1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvDuAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvDanhSachLv1
            // 
            this.lvDanhSachLv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachLv1.FullRowSelect = true;
            this.lvDanhSachLv1.HideSelection = false;
            this.lvDanhSachLv1.Location = new System.Drawing.Point(258, 0);
            this.lvDanhSachLv1.MultiSelect = false;
            this.lvDanhSachLv1.Name = "lvDanhSachLv1";
            this.lvDanhSachLv1.Size = new System.Drawing.Size(948, 592);
            this.lvDanhSachLv1.TabIndex = 5;
            this.lvDanhSachLv1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(190, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 592);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lvDuAn
            // 
            this.lvDuAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDuAn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvDuAn.FullRowSelect = true;
            this.lvDuAn.HideSelection = false;
            this.lvDuAn.Location = new System.Drawing.Point(0, 0);
            this.lvDuAn.MultiSelect = false;
            this.lvDuAn.Name = "lvDuAn";
            this.lvDuAn.Size = new System.Drawing.Size(190, 592);
            this.lvDuAn.TabIndex = 3;
            this.lvDuAn.UseCompatibleStateImageBehavior = false;
            this.lvDuAn.View = System.Windows.Forms.View.Details;
            this.lvDuAn.SelectedIndexChanged += new System.EventHandler(this.lvDuAn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dự án";
            this.columnHeader1.Width = 186;
            // 
            // XemTheoDuAnLv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.lvDanhSachLv1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvDuAn);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "XemTheoDuAnLv1";
            this.Size = new System.Drawing.Size(1206, 592);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDanhSachLv1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvDuAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

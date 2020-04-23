namespace QLDA.View.QuanLyDuAn.ThanhToan.CheDoXem
{
    partial class XemThanhToanTheoDuAn
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
            this.lvDuAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxHopDong = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContent2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuaThanhToan = new MetroFramework.Controls.MetroTextBox();
            this.txtDaThanhToan = new MetroFramework.Controls.MetroTextBox();
            this.txtTongGiaTri = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lvThanhToan = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelContent2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lvDuAn
            // 
            this.lvDuAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDuAn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvDuAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDuAn.FullRowSelect = true;
            this.lvDuAn.HideSelection = false;
            this.lvDuAn.Location = new System.Drawing.Point(0, 0);
            this.lvDuAn.MultiSelect = false;
            this.lvDuAn.Name = "lvDuAn";
            this.lvDuAn.OwnerDraw = true;
            this.lvDuAn.Size = new System.Drawing.Size(190, 592);
            this.lvDuAn.TabIndex = 3;
            this.lvDuAn.UseCompatibleStateImageBehavior = false;
            this.lvDuAn.View = System.Windows.Forms.View.Details;
            this.lvDuAn.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvDuAn_DrawColumnHeader);
            this.lvDuAn.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvDuAn_DrawSubItem);
            this.lvDuAn.SelectedIndexChanged += new System.EventHandler(this.lvDuAn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dự án";
            this.columnHeader1.Width = 184;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(190, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 592);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxHopDong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 45);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(649, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn hợp đồng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxHopDong
            // 
            this.cbxHopDong.FormattingEnabled = true;
            this.cbxHopDong.ItemHeight = 23;
            this.cbxHopDong.Location = new System.Drawing.Point(789, 10);
            this.cbxHopDong.Name = "cbxHopDong";
            this.cbxHopDong.Size = new System.Drawing.Size(184, 29);
            this.cbxHopDong.TabIndex = 2;
            this.cbxHopDong.UseSelectable = true;
            this.cbxHopDong.SelectedIndexChanged += new System.EventHandler(this.cbxHopDong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách thanh toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelContent2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 547);
            this.panel3.TabIndex = 7;
            // 
            // panelContent2
            // 
            this.panelContent2.Controls.Add(this.label7);
            this.panelContent2.Controls.Add(this.label6);
            this.panelContent2.Controls.Add(this.label3);
            this.panelContent2.Controls.Add(this.lvThanhToan);
            this.panelContent2.Controls.Add(this.label8);
            this.panelContent2.Controls.Add(this.label5);
            this.panelContent2.Controls.Add(this.label4);
            this.panelContent2.Controls.Add(this.txtChuaThanhToan);
            this.panelContent2.Controls.Add(this.txtDaThanhToan);
            this.panelContent2.Controls.Add(this.txtTongGiaTri);
            this.panelContent2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent2.Location = new System.Drawing.Point(0, 0);
            this.panelContent2.Name = "panelContent2";
            this.panelContent2.Size = new System.Drawing.Size(990, 547);
            this.panelContent2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(608, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(608, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(608, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "VND";
            // 
            // txtChuaThanhToan
            // 
            // 
            // 
            // 
            this.txtChuaThanhToan.CustomButton.Image = null;
            this.txtChuaThanhToan.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtChuaThanhToan.CustomButton.Name = "";
            this.txtChuaThanhToan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChuaThanhToan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChuaThanhToan.CustomButton.TabIndex = 1;
            this.txtChuaThanhToan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChuaThanhToan.CustomButton.UseSelectable = true;
            this.txtChuaThanhToan.CustomButton.Visible = false;
            this.txtChuaThanhToan.Lines = new string[0];
            this.txtChuaThanhToan.Location = new System.Drawing.Point(318, 496);
            this.txtChuaThanhToan.MaxLength = 32767;
            this.txtChuaThanhToan.Name = "txtChuaThanhToan";
            this.txtChuaThanhToan.PasswordChar = '\0';
            this.txtChuaThanhToan.ReadOnly = true;
            this.txtChuaThanhToan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChuaThanhToan.SelectedText = "";
            this.txtChuaThanhToan.SelectionLength = 0;
            this.txtChuaThanhToan.SelectionStart = 0;
            this.txtChuaThanhToan.ShortcutsEnabled = true;
            this.txtChuaThanhToan.Size = new System.Drawing.Size(276, 23);
            this.txtChuaThanhToan.TabIndex = 2;
            this.txtChuaThanhToan.UseSelectable = true;
            this.txtChuaThanhToan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChuaThanhToan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDaThanhToan
            // 
            // 
            // 
            // 
            this.txtDaThanhToan.CustomButton.Image = null;
            this.txtDaThanhToan.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtDaThanhToan.CustomButton.Name = "";
            this.txtDaThanhToan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDaThanhToan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDaThanhToan.CustomButton.TabIndex = 1;
            this.txtDaThanhToan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDaThanhToan.CustomButton.UseSelectable = true;
            this.txtDaThanhToan.CustomButton.Visible = false;
            this.txtDaThanhToan.Lines = new string[0];
            this.txtDaThanhToan.Location = new System.Drawing.Point(318, 445);
            this.txtDaThanhToan.MaxLength = 32767;
            this.txtDaThanhToan.Name = "txtDaThanhToan";
            this.txtDaThanhToan.PasswordChar = '\0';
            this.txtDaThanhToan.ReadOnly = true;
            this.txtDaThanhToan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDaThanhToan.SelectedText = "";
            this.txtDaThanhToan.SelectionLength = 0;
            this.txtDaThanhToan.SelectionStart = 0;
            this.txtDaThanhToan.ShortcutsEnabled = true;
            this.txtDaThanhToan.Size = new System.Drawing.Size(276, 23);
            this.txtDaThanhToan.TabIndex = 1;
            this.txtDaThanhToan.UseSelectable = true;
            this.txtDaThanhToan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDaThanhToan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTongGiaTri
            // 
            // 
            // 
            // 
            this.txtTongGiaTri.CustomButton.Image = null;
            this.txtTongGiaTri.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtTongGiaTri.CustomButton.Name = "";
            this.txtTongGiaTri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTongGiaTri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTongGiaTri.CustomButton.TabIndex = 1;
            this.txtTongGiaTri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTongGiaTri.CustomButton.UseSelectable = true;
            this.txtTongGiaTri.CustomButton.Visible = false;
            this.txtTongGiaTri.Lines = new string[0];
            this.txtTongGiaTri.Location = new System.Drawing.Point(318, 399);
            this.txtTongGiaTri.MaxLength = 32767;
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.PasswordChar = '\0';
            this.txtTongGiaTri.ReadOnly = true;
            this.txtTongGiaTri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTongGiaTri.SelectedText = "";
            this.txtTongGiaTri.SelectionLength = 0;
            this.txtTongGiaTri.SelectionStart = 0;
            this.txtTongGiaTri.ShortcutsEnabled = true;
            this.txtTongGiaTri.Size = new System.Drawing.Size(276, 23);
            this.txtTongGiaTri.TabIndex = 0;
            this.txtTongGiaTri.UseSelectable = true;
            this.txtTongGiaTri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTongGiaTri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 592);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1193, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 592);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lvThanhToan
            // 
            this.lvThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThanhToan.FullRowSelect = true;
            this.lvThanhToan.HideSelection = false;
            this.lvThanhToan.Location = new System.Drawing.Point(0, 0);
            this.lvThanhToan.MultiSelect = false;
            this.lvThanhToan.Name = "lvThanhToan";
            this.lvThanhToan.OwnerDraw = true;
            this.lvThanhToan.Size = new System.Drawing.Size(990, 368);
            this.lvThanhToan.TabIndex = 6;
            this.lvThanhToan.UseCompatibleStateImageBehavior = false;
            this.lvThanhToan.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvThanhToan_DrawColumnHeader);
            this.lvThanhToan.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvThanhToan_DrawSubItem);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng giá trị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(184, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đã thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(184, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Chưa thanh toán";
            // 
            // XemThanhToanTheoDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvDuAn);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "XemThanhToanTheoDuAn";
            this.Size = new System.Drawing.Size(1206, 592);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelContent2.ResumeLayout(false);
            this.panelContent2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDuAn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cbxHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelContent2;
        private MetroFramework.Controls.MetroTextBox txtChuaThanhToan;
        private MetroFramework.Controls.MetroTextBox txtDaThanhToan;
        private MetroFramework.Controls.MetroTextBox txtTongGiaTri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvThanhToan;
    }
}

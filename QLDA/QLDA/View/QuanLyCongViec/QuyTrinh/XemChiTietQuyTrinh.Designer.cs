namespace QLDA.View.QuanLyCongViec.QuyTrinh
{
    partial class XemChiTietQuyTrinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDanhSachDA = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.dtStartDate = new MetroFramework.Controls.MetroDateTime();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiQT = new MetroFramework.Controls.MetroTextBox();
            this.txtNV = new MetroFramework.Controls.MetroTextBox();
            this.txtDuAn = new MetroFramework.Controls.MetroTextBox();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.lvCv = new System.Windows.Forms.ListView();
            this.panelMain.SuspendLayout();
            this.panelDanhSachDA.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.panelMain.Controls.Add(this.panelDanhSachDA);
            this.panelMain.Controls.Add(this.panelThongTin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(688, 607);
            this.panelMain.TabIndex = 1;
            // 
            // panelDanhSachDA
            // 
            this.panelDanhSachDA.Controls.Add(this.lvCv);
            this.panelDanhSachDA.Controls.Add(this.label8);
            this.panelDanhSachDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachDA.Location = new System.Drawing.Point(0, 361);
            this.panelDanhSachDA.Name = "panelDanhSachDA";
            this.panelDanhSachDA.Size = new System.Drawing.Size(688, 246);
            this.panelDanhSachDA.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(688, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chi tiết các công việc";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.panelContent);
            this.panelThongTin.Controls.Add(this.panelLabel);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(688, 361);
            this.panelThongTin.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.txtStatus);
            this.panelContent.Controls.Add(this.txtDuAn);
            this.panelContent.Controls.Add(this.txtNV);
            this.panelContent.Controls.Add(this.txtLoaiQT);
            this.panelContent.Controls.Add(this.dtEndDate);
            this.panelContent.Controls.Add(this.dtStartDate);
            this.panelContent.Controls.Add(this.txtTen);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(226, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(462, 361);
            this.panelContent.TabIndex = 1;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Enabled = false;
            this.dtEndDate.Location = new System.Drawing.Point(17, 264);
            this.dtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 29);
            this.dtEndDate.TabIndex = 11;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Enabled = false;
            this.dtStartDate.Location = new System.Drawing.Point(17, 212);
            this.dtStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 29);
            this.dtStartDate.TabIndex = 10;
            // 
            // txtTen
            // 
            // 
            // 
            // 
            this.txtTen.CustomButton.Image = null;
            this.txtTen.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtTen.CustomButton.Name = "";
            this.txtTen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTen.CustomButton.TabIndex = 1;
            this.txtTen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTen.CustomButton.UseSelectable = true;
            this.txtTen.CustomButton.Visible = false;
            this.txtTen.Enabled = false;
            this.txtTen.Lines = new string[0];
            this.txtTen.Location = new System.Drawing.Point(17, 12);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.ReadOnly = true;
            this.txtTen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTen.SelectedText = "";
            this.txtTen.SelectionLength = 0;
            this.txtTen.SelectionStart = 0;
            this.txtTen.ShortcutsEnabled = true;
            this.txtTen.Size = new System.Drawing.Size(240, 23);
            this.txtTen.TabIndex = 0;
            this.txtTen.UseSelectable = true;
            this.txtTen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.label7);
            this.panelLabel.Controls.Add(this.label6);
            this.panelLabel.Controls.Add(this.label5);
            this.panelLabel.Controls.Add(this.label4);
            this.panelLabel.Controls.Add(this.label3);
            this.panelLabel.Controls.Add(this.label2);
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLabel.Location = new System.Drawing.Point(0, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(226, 361);
            this.panelLabel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(0, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng thái";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(0, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thời gian kết thúc";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(0, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian bắt đầu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dự án";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chủ nhiệm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại quy trình";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên quy trình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLoaiQT
            // 
            // 
            // 
            // 
            this.txtLoaiQT.CustomButton.Image = null;
            this.txtLoaiQT.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtLoaiQT.CustomButton.Name = "";
            this.txtLoaiQT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoaiQT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoaiQT.CustomButton.TabIndex = 1;
            this.txtLoaiQT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoaiQT.CustomButton.UseSelectable = true;
            this.txtLoaiQT.CustomButton.Visible = false;
            this.txtLoaiQT.Enabled = false;
            this.txtLoaiQT.Lines = new string[0];
            this.txtLoaiQT.Location = new System.Drawing.Point(17, 63);
            this.txtLoaiQT.MaxLength = 32767;
            this.txtLoaiQT.Name = "txtLoaiQT";
            this.txtLoaiQT.PasswordChar = '\0';
            this.txtLoaiQT.ReadOnly = true;
            this.txtLoaiQT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoaiQT.SelectedText = "";
            this.txtLoaiQT.SelectionLength = 0;
            this.txtLoaiQT.SelectionStart = 0;
            this.txtLoaiQT.ShortcutsEnabled = true;
            this.txtLoaiQT.Size = new System.Drawing.Size(240, 23);
            this.txtLoaiQT.TabIndex = 13;
            this.txtLoaiQT.UseSelectable = true;
            this.txtLoaiQT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoaiQT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNV
            // 
            // 
            // 
            // 
            this.txtNV.CustomButton.Image = null;
            this.txtNV.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtNV.CustomButton.Name = "";
            this.txtNV.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNV.CustomButton.TabIndex = 1;
            this.txtNV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNV.CustomButton.UseSelectable = true;
            this.txtNV.CustomButton.Visible = false;
            this.txtNV.Enabled = false;
            this.txtNV.Lines = new string[0];
            this.txtNV.Location = new System.Drawing.Point(17, 114);
            this.txtNV.MaxLength = 32767;
            this.txtNV.Name = "txtNV";
            this.txtNV.PasswordChar = '\0';
            this.txtNV.ReadOnly = true;
            this.txtNV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNV.SelectedText = "";
            this.txtNV.SelectionLength = 0;
            this.txtNV.SelectionStart = 0;
            this.txtNV.ShortcutsEnabled = true;
            this.txtNV.Size = new System.Drawing.Size(240, 23);
            this.txtNV.TabIndex = 14;
            this.txtNV.UseSelectable = true;
            this.txtNV.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNV.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDuAn
            // 
            // 
            // 
            // 
            this.txtDuAn.CustomButton.Image = null;
            this.txtDuAn.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtDuAn.CustomButton.Name = "";
            this.txtDuAn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDuAn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDuAn.CustomButton.TabIndex = 1;
            this.txtDuAn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDuAn.CustomButton.UseSelectable = true;
            this.txtDuAn.CustomButton.Visible = false;
            this.txtDuAn.Enabled = false;
            this.txtDuAn.Lines = new string[0];
            this.txtDuAn.Location = new System.Drawing.Point(17, 165);
            this.txtDuAn.MaxLength = 32767;
            this.txtDuAn.Name = "txtDuAn";
            this.txtDuAn.PasswordChar = '\0';
            this.txtDuAn.ReadOnly = true;
            this.txtDuAn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDuAn.SelectedText = "";
            this.txtDuAn.SelectionLength = 0;
            this.txtDuAn.SelectionStart = 0;
            this.txtDuAn.ShortcutsEnabled = true;
            this.txtDuAn.Size = new System.Drawing.Size(240, 23);
            this.txtDuAn.TabIndex = 15;
            this.txtDuAn.UseSelectable = true;
            this.txtDuAn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDuAn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.CustomButton.Visible = false;
            this.txtStatus.Enabled = false;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(17, 315);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.ShortcutsEnabled = true;
            this.txtStatus.Size = new System.Drawing.Size(240, 23);
            this.txtStatus.TabIndex = 16;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lvCv
            // 
            this.lvCv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCv.HideSelection = false;
            this.lvCv.Location = new System.Drawing.Point(0, 35);
            this.lvCv.Name = "lvCv";
            this.lvCv.Size = new System.Drawing.Size(688, 211);
            this.lvCv.TabIndex = 9;
            this.lvCv.UseCompatibleStateImageBehavior = false;
            // 
            // XemChiTietQuyTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(688, 607);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "XemChiTietQuyTrinh";
            this.Text = "TaoHoacCapNhatQT";
            this.panelMain.ResumeLayout(false);
            this.panelDanhSachDA.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDanhSachDA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelContent;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtEndDate;
        private MetroFramework.Controls.MetroDateTime dtStartDate;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroTextBox txtDuAn;
        private MetroFramework.Controls.MetroTextBox txtNV;
        private MetroFramework.Controls.MetroTextBox txtLoaiQT;
        private System.Windows.Forms.ListView lvCv;
    }
}
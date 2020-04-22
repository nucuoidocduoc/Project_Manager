namespace QLDA.View.DanhMuc.KhachHang
{
    partial class XemChiTietKH
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
            this.lvDSDA = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.txtTenNH = new MetroFramework.Controls.MetroTextBox();
            this.txtTKNH = new MetroFramework.Controls.MetroTextBox();
            this.txtSDT = new MetroFramework.Controls.MetroTextBox();
            this.txtMST = new MetroFramework.Controls.MetroTextBox();
            this.txtDC = new MetroFramework.Controls.MetroTextBox();
            this.txtTenKH = new MetroFramework.Controls.MetroTextBox();
            this.txtMaKH = new MetroFramework.Controls.MetroTextBox();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelDanhSachDA.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelDanhSachDA);
            this.panelMain.Controls.Add(this.panelThongTin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(688, 607);
            this.panelMain.TabIndex = 0;
            // 
            // panelDanhSachDA
            // 
            this.panelDanhSachDA.Controls.Add(this.lvDSDA);
            this.panelDanhSachDA.Controls.Add(this.label8);
            this.panelDanhSachDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachDA.Location = new System.Drawing.Point(0, 361);
            this.panelDanhSachDA.Name = "panelDanhSachDA";
            this.panelDanhSachDA.Size = new System.Drawing.Size(688, 246);
            this.panelDanhSachDA.TabIndex = 1;
            // 
            // lvDSDA
            // 
            this.lvDSDA.HideSelection = false;
            this.lvDSDA.Location = new System.Drawing.Point(31, 35);
            this.lvDSDA.Name = "lvDSDA";
            this.lvDSDA.Size = new System.Drawing.Size(629, 185);
            this.lvDSDA.TabIndex = 9;
            this.lvDSDA.UseCompatibleStateImageBehavior = false;
            this.lvDSDA.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvDSDA_DrawColumnHeader);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(688, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Danh sách dự án của khách hàng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.Transparent;
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
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.txtTenNH);
            this.panelContent.Controls.Add(this.txtTKNH);
            this.panelContent.Controls.Add(this.txtSDT);
            this.panelContent.Controls.Add(this.txtMST);
            this.panelContent.Controls.Add(this.txtDC);
            this.panelContent.Controls.Add(this.txtTenKH);
            this.panelContent.Controls.Add(this.txtMaKH);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(226, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(462, 361);
            this.panelContent.TabIndex = 1;
            // 
            // txtTenNH
            // 
            // 
            // 
            // 
            this.txtTenNH.CustomButton.Image = null;
            this.txtTenNH.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtTenNH.CustomButton.Name = "";
            this.txtTenNH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenNH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenNH.CustomButton.TabIndex = 1;
            this.txtTenNH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenNH.CustomButton.UseSelectable = true;
            this.txtTenNH.CustomButton.Visible = false;
            this.txtTenNH.Lines = new string[0];
            this.txtTenNH.Location = new System.Drawing.Point(17, 315);
            this.txtTenNH.MaxLength = 32767;
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.PasswordChar = '\0';
            this.txtTenNH.ReadOnly = true;
            this.txtTenNH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenNH.SelectedText = "";
            this.txtTenNH.SelectionLength = 0;
            this.txtTenNH.SelectionStart = 0;
            this.txtTenNH.ShortcutsEnabled = true;
            this.txtTenNH.Size = new System.Drawing.Size(240, 23);
            this.txtTenNH.TabIndex = 6;
            this.txtTenNH.UseSelectable = true;
            this.txtTenNH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenNH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTKNH
            // 
            // 
            // 
            // 
            this.txtTKNH.CustomButton.Image = null;
            this.txtTKNH.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtTKNH.CustomButton.Name = "";
            this.txtTKNH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTKNH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTKNH.CustomButton.TabIndex = 1;
            this.txtTKNH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTKNH.CustomButton.UseSelectable = true;
            this.txtTKNH.CustomButton.Visible = false;
            this.txtTKNH.Lines = new string[0];
            this.txtTKNH.Location = new System.Drawing.Point(17, 265);
            this.txtTKNH.MaxLength = 32767;
            this.txtTKNH.Name = "txtTKNH";
            this.txtTKNH.PasswordChar = '\0';
            this.txtTKNH.ReadOnly = true;
            this.txtTKNH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTKNH.SelectedText = "";
            this.txtTKNH.SelectionLength = 0;
            this.txtTKNH.SelectionStart = 0;
            this.txtTKNH.ShortcutsEnabled = true;
            this.txtTKNH.Size = new System.Drawing.Size(240, 23);
            this.txtTKNH.TabIndex = 5;
            this.txtTKNH.UseSelectable = true;
            this.txtTKNH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTKNH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSDT
            // 
            // 
            // 
            // 
            this.txtSDT.CustomButton.Image = null;
            this.txtSDT.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtSDT.CustomButton.Name = "";
            this.txtSDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSDT.CustomButton.TabIndex = 1;
            this.txtSDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSDT.CustomButton.UseSelectable = true;
            this.txtSDT.CustomButton.Visible = false;
            this.txtSDT.Lines = new string[0];
            this.txtSDT.Location = new System.Drawing.Point(17, 214);
            this.txtSDT.MaxLength = 32767;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.ReadOnly = true;
            this.txtSDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSDT.SelectedText = "";
            this.txtSDT.SelectionLength = 0;
            this.txtSDT.SelectionStart = 0;
            this.txtSDT.ShortcutsEnabled = true;
            this.txtSDT.Size = new System.Drawing.Size(240, 23);
            this.txtSDT.TabIndex = 4;
            this.txtSDT.UseSelectable = true;
            this.txtSDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMST
            // 
            // 
            // 
            // 
            this.txtMST.CustomButton.Image = null;
            this.txtMST.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtMST.CustomButton.Name = "";
            this.txtMST.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMST.CustomButton.TabIndex = 1;
            this.txtMST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMST.CustomButton.UseSelectable = true;
            this.txtMST.CustomButton.Visible = false;
            this.txtMST.Lines = new string[0];
            this.txtMST.Location = new System.Drawing.Point(17, 162);
            this.txtMST.MaxLength = 32767;
            this.txtMST.Name = "txtMST";
            this.txtMST.PasswordChar = '\0';
            this.txtMST.ReadOnly = true;
            this.txtMST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMST.SelectedText = "";
            this.txtMST.SelectionLength = 0;
            this.txtMST.SelectionStart = 0;
            this.txtMST.ShortcutsEnabled = true;
            this.txtMST.Size = new System.Drawing.Size(240, 23);
            this.txtMST.TabIndex = 3;
            this.txtMST.UseSelectable = true;
            this.txtMST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDC
            // 
            // 
            // 
            // 
            this.txtDC.CustomButton.Image = null;
            this.txtDC.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtDC.CustomButton.Name = "";
            this.txtDC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDC.CustomButton.TabIndex = 1;
            this.txtDC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDC.CustomButton.UseSelectable = true;
            this.txtDC.CustomButton.Visible = false;
            this.txtDC.Lines = new string[0];
            this.txtDC.Location = new System.Drawing.Point(17, 113);
            this.txtDC.MaxLength = 32767;
            this.txtDC.Name = "txtDC";
            this.txtDC.PasswordChar = '\0';
            this.txtDC.ReadOnly = true;
            this.txtDC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDC.SelectedText = "";
            this.txtDC.SelectionLength = 0;
            this.txtDC.SelectionStart = 0;
            this.txtDC.ShortcutsEnabled = true;
            this.txtDC.Size = new System.Drawing.Size(240, 23);
            this.txtDC.TabIndex = 2;
            this.txtDC.UseSelectable = true;
            this.txtDC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenKH
            // 
            // 
            // 
            // 
            this.txtTenKH.CustomButton.Image = null;
            this.txtTenKH.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtTenKH.CustomButton.Name = "";
            this.txtTenKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenKH.CustomButton.TabIndex = 1;
            this.txtTenKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenKH.CustomButton.UseSelectable = true;
            this.txtTenKH.CustomButton.Visible = false;
            this.txtTenKH.Lines = new string[0];
            this.txtTenKH.Location = new System.Drawing.Point(17, 62);
            this.txtTenKH.MaxLength = 32767;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.SelectionLength = 0;
            this.txtTenKH.SelectionStart = 0;
            this.txtTenKH.ShortcutsEnabled = true;
            this.txtTenKH.Size = new System.Drawing.Size(240, 23);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.UseSelectable = true;
            this.txtTenKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.CustomButton.Image = null;
            this.txtMaKH.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtMaKH.CustomButton.Name = "";
            this.txtMaKH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaKH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKH.CustomButton.TabIndex = 1;
            this.txtMaKH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKH.CustomButton.UseSelectable = true;
            this.txtMaKH.CustomButton.Visible = false;
            this.txtMaKH.Lines = new string[0];
            this.txtMaKH.Location = new System.Drawing.Point(17, 12);
            this.txtMaKH.MaxLength = 32767;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.SelectionLength = 0;
            this.txtMaKH.SelectionStart = 0;
            this.txtMaKH.ShortcutsEnabled = true;
            this.txtMaKH.Size = new System.Drawing.Size(240, 23);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.UseSelectable = true;
            this.txtMaKH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tên ngâng hàng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tài khoản ngân hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã số thuế";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XemChiTietKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(688, 607);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XemChiTietKH";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
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
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtTenNH;
        private MetroFramework.Controls.MetroTextBox txtTKNH;
        private MetroFramework.Controls.MetroTextBox txtSDT;
        private MetroFramework.Controls.MetroTextBox txtMST;
        private MetroFramework.Controls.MetroTextBox txtDC;
        private MetroFramework.Controls.MetroTextBox txtTenKH;
        private MetroFramework.Controls.MetroTextBox txtMaKH;
        private System.Windows.Forms.ListView lvDSDA;
    }
}
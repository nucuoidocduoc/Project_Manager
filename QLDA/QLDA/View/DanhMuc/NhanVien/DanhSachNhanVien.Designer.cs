namespace QLDA.View.DanhMuc.NhanVien
{
    partial class DanhSachNhanVien
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.lvDanhSachNV = new MetroFramework.Controls.MetroListView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelDSNV = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnThemMoi);
            this.panelFooter.Controls.Add(this.btnCapNhat);
            this.panelFooter.Controls.Add(this.btnXoa);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFooter.Location = new System.Drawing.Point(0, 713);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1206, 40);
            this.panelFooter.TabIndex = 4;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(835, 7);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseSelectable = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(934, 7);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1036, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // lvDanhSachNV
            // 
            this.lvDanhSachNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvDanhSachNV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDanhSachNV.FullRowSelect = true;
            this.lvDanhSachNV.Location = new System.Drawing.Point(0, 38);
            this.lvDanhSachNV.Name = "lvDanhSachNV";
            this.lvDanhSachNV.OwnerDraw = true;
            this.lvDanhSachNV.Size = new System.Drawing.Size(1206, 675);
            this.lvDanhSachNV.TabIndex = 2;
            this.lvDanhSachNV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachNV.UseSelectable = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelDSNV);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1206, 38);
            this.panelHeader.TabIndex = 3;
            // 
            // labelDSNV
            // 
            this.labelDSNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDSNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDSNV.Location = new System.Drawing.Point(0, 0);
            this.labelDSNV.Name = "labelDSNV";
            this.labelDSNV.Size = new System.Drawing.Size(242, 38);
            this.labelDSNV.TabIndex = 0;
            this.labelDSNV.Text = "Danh sách nhân viên";
            this.labelDSNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.lvDanhSachNV);
            this.Controls.Add(this.panelHeader);
            this.Name = "DanhSachNhanVien";
            this.Size = new System.Drawing.Size(1206, 753);
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private MetroFramework.Controls.MetroButton btnThemMoi;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroListView lvDanhSachNV;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDSNV;
    }
}

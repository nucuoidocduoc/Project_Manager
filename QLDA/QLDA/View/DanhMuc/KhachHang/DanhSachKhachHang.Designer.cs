namespace QLDA.View.DanhMuc.KhachHang
{
    partial class DanhSachKhachHang
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelDSKH = new System.Windows.Forms.Label();
            this.lvDanhSachKH = new MetroFramework.Controls.MetroListView();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.btnXemChiTiet = new MetroFramework.Controls.MetroButton();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelDSKH);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1206, 38);
            this.panelHeader.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnXemChiTiet);
            this.panelFooter.Controls.Add(this.btnThemMoi);
            this.panelFooter.Controls.Add(this.btnCapNhat);
            this.panelFooter.Controls.Add(this.btnXoa);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 713);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1206, 40);
            this.panelFooter.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.lvDanhSachKH);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 38);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1206, 675);
            this.panelBody.TabIndex = 2;
            // 
            // labelDSKH
            // 
            this.labelDSKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDSKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDSKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSKH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDSKH.Location = new System.Drawing.Point(0, 0);
            this.labelDSKH.Name = "labelDSKH";
            this.labelDSKH.Size = new System.Drawing.Size(242, 38);
            this.labelDSKH.TabIndex = 0;
            this.labelDSKH.Text = "Danh sách khách hàng";
            this.labelDSKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvDanhSachKH
            // 
            this.lvDanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachKH.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDanhSachKH.FullRowSelect = true;
            this.lvDanhSachKH.Location = new System.Drawing.Point(0, 0);
            this.lvDanhSachKH.Name = "lvDanhSachKH";
            this.lvDanhSachKH.OwnerDraw = true;
            this.lvDanhSachKH.Size = new System.Drawing.Size(1206, 675);
            this.lvDanhSachKH.TabIndex = 0;
            this.lvDanhSachKH.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachKH.UseSelectable = true;
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
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(934, 7);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseSelectable = true;
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
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(739, 6);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 3;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseSelectable = true;
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Name = "DanhSachKhachHang";
            this.Size = new System.Drawing.Size(1206, 753);
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelDSKH;
        private MetroFramework.Controls.MetroButton btnXemChiTiet;
        private MetroFramework.Controls.MetroButton btnThemMoi;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroListView lvDanhSachKH;
    }
}

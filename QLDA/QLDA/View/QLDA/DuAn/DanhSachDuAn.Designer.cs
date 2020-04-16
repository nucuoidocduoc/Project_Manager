namespace QLDA.View.QLDA.DuAn
{
    partial class DanhSachDuAn
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
            this.btnXemChiTiet = new MetroFramework.Controls.MetroButton();
            this.btnThemMoi = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.lvDanhSachDA = new MetroFramework.Controls.MetroListView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelDSDA = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
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
            this.panelFooter.TabIndex = 4;
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
            // lvDanhSachDA
            // 
            this.lvDanhSachDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachDA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDanhSachDA.FullRowSelect = true;
            this.lvDanhSachDA.Location = new System.Drawing.Point(0, 38);
            this.lvDanhSachDA.Name = "lvDanhSachDA";
            this.lvDanhSachDA.OwnerDraw = true;
            this.lvDanhSachDA.Size = new System.Drawing.Size(1206, 715);
            this.lvDanhSachDA.TabIndex = 2;
            this.lvDanhSachDA.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDA.UseSelectable = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelDSDA);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1206, 38);
            this.panelHeader.TabIndex = 3;
            // 
            // labelDSDA
            // 
            this.labelDSDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDSDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDSDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSDA.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDSDA.Location = new System.Drawing.Point(0, 0);
            this.labelDSDA.Name = "labelDSDA";
            this.labelDSDA.Size = new System.Drawing.Size(242, 38);
            this.labelDSDA.TabIndex = 0;
            this.labelDSDA.Text = "Danh sách dự án";
            this.labelDSDA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DanhSachDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.lvDanhSachDA);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "DanhSachDuAn";
            this.Size = new System.Drawing.Size(1206, 753);
            this.panelFooter.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private MetroFramework.Controls.MetroButton btnXemChiTiet;
        private MetroFramework.Controls.MetroButton btnThemMoi;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroListView lvDanhSachDA;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDSDA;
    }
}

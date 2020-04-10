namespace QLBH2019
{
    partial class FormDMHH
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
            this.components = new System.ComponentModel.Container();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDMHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ktqd2019DataSet = new QLBH2019.ktqd2019DataSet();
            this.tblDMHHTableAdapter = new QLBH2019.ktqd2019DataSetTableAdapters.tblDMHHTableAdapter();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocDL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnIndsNh = new System.Windows.Forms.Button();
            this.btnInSx = new System.Windows.Forms.Button();
            this.btnInNhom = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.cbmTruong = new System.Windows.Forms.ComboBox();
            this.cbmGiaTri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktqd2019DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.DGvnd,
            this.SanXuat});
            this.grdData.Location = new System.Drawing.Point(3, 12);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(567, 304);
            this.grdData.TabIndex = 0;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã nhóm";
            this.MaNhom.Name = "MaNhom";
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng";
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 200;
            // 
            // Dvt
            // 
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đơn vị";
            this.Dvt.Name = "Dvt";
            // 
            // DGvnd
            // 
            this.DGvnd.DataPropertyName = "DGvnd";
            this.DGvnd.HeaderText = "Đơn giá";
            this.DGvnd.Name = "DGvnd";
            // 
            // SanXuat
            // 
            this.SanXuat.DataPropertyName = "SanXuat";
            this.SanXuat.HeaderText = "Nước SX";
            this.SanXuat.Name = "SanXuat";
            // 
            // tblDMHHBindingSource
            // 
            this.tblDMHHBindingSource.DataMember = "tblDMHH";
            this.tblDMHHBindingSource.DataSource = this.ktqd2019DataSet;
            // 
            // ktqd2019DataSet
            // 
            this.ktqd2019DataSet.DataSetName = "ktqd2019DataSet";
            this.ktqd2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDMHHTableAdapter
            // 
            this.tblDMHHTableAdapter.ClearBeforeFill = true;
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(42, 411);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(75, 23);
            this.btnDau.TabIndex = 1;
            this.btnDau.Text = "Đầu";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(123, 411);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnTruoc.TabIndex = 2;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(204, 411);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 3;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(285, 411);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(75, 23);
            this.btnCuoi.TabIndex = 4;
            this.btnCuoi.Text = "Cuối";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lọc dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên trường";
            // 
            // btnLocDL
            // 
            this.btnLocDL.Location = new System.Drawing.Point(656, 117);
            this.btnLocDL.Name = "btnLocDL";
            this.btnLocDL.Size = new System.Drawing.Size(75, 23);
            this.btnLocDL.TabIndex = 10;
            this.btnLocDL.Text = "Lọc dữ liệu";
            this.btnLocDL.UseVisualStyleBackColor = true;
            this.btnLocDL.Click += new System.EventHandler(this.btnLocDL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtNuocSX);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaNhom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(575, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(80, 57);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(150, 20);
            this.txtMaHang.TabIndex = 11;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(81, 188);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(149, 20);
            this.txtNuocSX.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(81, 156);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(149, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(81, 128);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(149, 20);
            this.txtDonVi.TabIndex = 8;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(80, 91);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(150, 20);
            this.txtTenHang.TabIndex = 7;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(80, 17);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(150, 20);
            this.txtMaNhom.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nước SX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhóm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(497, 388);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 12;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(591, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(682, 388);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(774, 388);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 15;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // btnIndsNh
            // 
            this.btnIndsNh.Location = new System.Drawing.Point(27, 337);
            this.btnIndsNh.Name = "btnIndsNh";
            this.btnIndsNh.Size = new System.Drawing.Size(157, 23);
            this.btnIndsNh.TabIndex = 16;
            this.btnIndsNh.Text = "In danh sách theo nhóm hàng";
            this.btnIndsNh.UseVisualStyleBackColor = true;
            this.btnIndsNh.Click += new System.EventHandler(this.btnIndsNh_Click);
            // 
            // btnInSx
            // 
            this.btnInSx.Location = new System.Drawing.Point(214, 337);
            this.btnInSx.Name = "btnInSx";
            this.btnInSx.Size = new System.Drawing.Size(109, 23);
            this.btnInSx.TabIndex = 17;
            this.btnInSx.Text = "In theo nước SX";
            this.btnInSx.UseVisualStyleBackColor = true;
            // 
            // btnInNhom
            // 
            this.btnInNhom.Location = new System.Drawing.Point(349, 337);
            this.btnInNhom.Name = "btnInNhom";
            this.btnInNhom.Size = new System.Drawing.Size(97, 23);
            this.btnInNhom.TabIndex = 18;
            this.btnInNhom.Text = "In theo nhóm";
            this.btnInNhom.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(774, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // cbmTruong
            // 
            this.cbmTruong.FormattingEnabled = true;
            this.cbmTruong.Items.AddRange(new object[] {
            "MaNhom",
            "MaHH",
            "SanXuat"});
            this.cbmTruong.Location = new System.Drawing.Point(577, 74);
            this.cbmTruong.Name = "cbmTruong";
            this.cbmTruong.Size = new System.Drawing.Size(116, 21);
            this.cbmTruong.TabIndex = 20;
            this.cbmTruong.SelectedIndexChanged += new System.EventHandler(this.cbmTruong_SelectedIndexChanged);
            // 
            // cbmGiaTri
            // 
            this.cbmGiaTri.FormattingEnabled = true;
            this.cbmGiaTri.Location = new System.Drawing.Point(711, 73);
            this.cbmGiaTri.Name = "cbmGiaTri";
            this.cbmGiaTri.Size = new System.Drawing.Size(121, 21);
            this.cbmGiaTri.TabIndex = 21;
            // 
            // FormDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 434);
            this.Controls.Add(this.cbmGiaTri);
            this.Controls.Add(this.cbmTruong);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnInNhom);
            this.Controls.Add(this.btnInSx);
            this.Controls.Add(this.btnIndsNh);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLocDL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.grdData);
            this.Name = "FormDMHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDMHH";
            this.Load += new System.EventHandler(this.FormDMHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktqd2019DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private ktqd2019DataSet ktqd2019DataSet;
        private System.Windows.Forms.BindingSource tblDMHHBindingSource;
        private ktqd2019DataSetTableAdapters.tblDMHHTableAdapter tblDMHHTableAdapter;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocDL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnIndsNh;
        private System.Windows.Forms.Button btnInSx;
        private System.Windows.Forms.Button btnInNhom;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cbmTruong;
        private System.Windows.Forms.ComboBox cbmGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanXuat;
    }
}
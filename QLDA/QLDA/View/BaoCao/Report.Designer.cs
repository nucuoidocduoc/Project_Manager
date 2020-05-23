namespace QLDA.View.BaoCao
{
    partial class Report
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
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new MetroFramework.Controls.MetroButton();
            this.panelCDT = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCV = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHD = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDA = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2DT = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCDT.SuspendLayout();
            this.panelCV.SuspendLayout();
            this.panelHD.SuspendLayout();
            this.panelDA.SuspendLayout();
            this.panel2DT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(107, 41);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(141, 29);
            this.dtFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To date:";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(107, 111);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(141, 29);
            this.dtTo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 669);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện lọc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(305, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 669);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn loại báo cáo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.panelCDT);
            this.panel1.Controls.Add(this.panelCV);
            this.panel1.Controls.Add(this.panelHD);
            this.panel1.Controls.Add(this.panelDA);
            this.panel1.Controls.Add(this.panel2DT);
            this.panel1.Location = new System.Drawing.Point(19, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 589);
            this.panel1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(288, 440);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(209, 57);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseSelectable = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panelCDT
            // 
            this.panelCDT.Controls.Add(this.label7);
            this.panelCDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCDT.Location = new System.Drawing.Point(0, 248);
            this.panelCDT.Name = "panelCDT";
            this.panelCDT.Size = new System.Drawing.Size(786, 62);
            this.panelCDT.TabIndex = 4;
            this.panelCDT.Visible = false;
            this.panelCDT.Click += new System.EventHandler(this.panelCDT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chủ đầu tư";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panelCV
            // 
            this.panelCV.Controls.Add(this.label6);
            this.panelCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCV.Location = new System.Drawing.Point(0, 186);
            this.panelCV.Name = "panelCV";
            this.panelCV.Size = new System.Drawing.Size(786, 62);
            this.panelCV.TabIndex = 3;
            this.panelCV.Click += new System.EventHandler(this.panelCV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Báo cáo công việc";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelHD
            // 
            this.panelHD.Controls.Add(this.label5);
            this.panelHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHD.Location = new System.Drawing.Point(0, 124);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(786, 62);
            this.panelHD.TabIndex = 2;
            this.panelHD.Click += new System.EventHandler(this.panelHD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách hợp đồng đang thực hiện";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelDA
            // 
            this.panelDA.Controls.Add(this.label4);
            this.panelDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDA.Location = new System.Drawing.Point(0, 62);
            this.panelDA.Name = "panelDA";
            this.panelDA.Size = new System.Drawing.Size(786, 62);
            this.panelDA.TabIndex = 1;
            this.panelDA.Click += new System.EventHandler(this.panelDA_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách dự án đang thực hiện";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2DT
            // 
            this.panel2DT.Controls.Add(this.label3);
            this.panel2DT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2DT.Location = new System.Drawing.Point(0, 0);
            this.panel2DT.Name = "panel2DT";
            this.panel2DT.Size = new System.Drawing.Size(786, 62);
            this.panel2DT.TabIndex = 0;
            this.panel2DT.Click += new System.EventHandler(this.panel2DT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doanh thu kinh doanh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(83)))), ((int)(((byte)(139)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1145, 695);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCDT.ResumeLayout(false);
            this.panelCDT.PerformLayout();
            this.panelCV.ResumeLayout(false);
            this.panelCV.PerformLayout();
            this.panelHD.ResumeLayout(false);
            this.panelHD.PerformLayout();
            this.panelDA.ResumeLayout(false);
            this.panelDA.PerformLayout();
            this.panel2DT.ResumeLayout(false);
            this.panel2DT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnXem;
        private System.Windows.Forms.Panel panelCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCDT;
        private System.Windows.Forms.Label label7;
    }
}

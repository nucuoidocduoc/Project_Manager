namespace QLDA.View.QuanLyCongViec.CongViec.CheDoXem
{
    partial class XemCongViecTheoDuAn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvCv = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxQT = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvDuAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvCv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 603);
            this.panel1.TabIndex = 11;
            // 
            // lvCv
            // 
            this.lvCv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCv.FullRowSelect = true;
            this.lvCv.HideSelection = false;
            this.lvCv.Location = new System.Drawing.Point(0, 39);
            this.lvCv.Name = "lvCv";
            this.lvCv.OwnerDraw = true;
            this.lvCv.Size = new System.Drawing.Size(963, 564);
            this.lvCv.TabIndex = 6;
            this.lvCv.UseCompatibleStateImageBehavior = false;
            this.lvCv.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvCv_DrawColumnHeader);
            this.lvCv.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvCv_DrawSubItem);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxQT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 39);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(618, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn quy trình";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxQT
            // 
            this.cbxQT.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbxQT.FormattingEnabled = true;
            this.cbxQT.ItemHeight = 19;
            this.cbxQT.Location = new System.Drawing.Point(764, 6);
            this.cbxQT.Name = "cbxQT";
            this.cbxQT.Size = new System.Drawing.Size(184, 25);
            this.cbxQT.TabIndex = 2;
            this.cbxQT.UseSelectable = true;
            this.cbxQT.SelectedIndexChanged += new System.EventHandler(this.cbxQT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách công việc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(154, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 603);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.lvDuAn.Size = new System.Drawing.Size(154, 603);
            this.lvDuAn.TabIndex = 9;
            this.lvDuAn.UseCompatibleStateImageBehavior = false;
            this.lvDuAn.View = System.Windows.Forms.View.Details;
            this.lvDuAn.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvDuAn_DrawColumnHeader);
            this.lvDuAn.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvDuAn_DrawSubItem);
            this.lvDuAn.SelectedIndexChanged += new System.EventHandler(this.lvDuAn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dự án";
            this.columnHeader1.Width = 150;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1131, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 603);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // XemCongViecTheoDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvDuAn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "XemCongViecTheoDuAn";
            this.Size = new System.Drawing.Size(1145, 603);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvCv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cbxQT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvDuAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

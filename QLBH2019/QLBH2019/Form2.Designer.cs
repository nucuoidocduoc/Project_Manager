namespace QLBH2019
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoHang1 = new System.Windows.Forms.TextBox();
            this.txtSoHang2 = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.cboDau = new System.Windows.Forms.ComboBox();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập phép tính";
            // 
            // txtSoHang1
            // 
            this.txtSoHang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHang1.Location = new System.Drawing.Point(15, 89);
            this.txtSoHang1.Multiline = true;
            this.txtSoHang1.Name = "txtSoHang1";
            this.txtSoHang1.Size = new System.Drawing.Size(80, 29);
            this.txtSoHang1.TabIndex = 1;
            this.txtSoHang1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoHang2
            // 
            this.txtSoHang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHang2.Location = new System.Drawing.Point(158, 89);
            this.txtSoHang2.Multiline = true;
            this.txtSoHang2.Name = "txtSoHang2";
            this.txtSoHang2.Size = new System.Drawing.Size(80, 29);
            this.txtSoHang2.TabIndex = 2;
            this.txtSoHang2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(325, 89);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(117, 29);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboDau
            // 
            this.cboDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDau.FormattingEnabled = true;
            this.cboDau.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboDau.Location = new System.Drawing.Point(102, 89);
            this.cboDau.Name = "cboDau";
            this.cboDau.Size = new System.Drawing.Size(50, 26);
            this.cboDau.TabIndex = 4;
            // 
            // btnBang
            // 
            this.btnBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(244, 89);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(75, 29);
            this.btnBang.TabIndex = 5;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(102, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(279, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 236);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.cboDau);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoHang2);
            this.Controls.Add(this.txtSoHang1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoHang1;
        private System.Windows.Forms.TextBox txtSoHang2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ComboBox cboDau;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}
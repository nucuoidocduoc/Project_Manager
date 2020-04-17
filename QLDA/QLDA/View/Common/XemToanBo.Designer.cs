namespace QLDA.View.Common
{
    partial class XemToanBo
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
            this.lvDanhSachToanBo = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // lvDanhSachToanBo
            // 
            this.lvDanhSachToanBo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachToanBo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvDanhSachToanBo.FullRowSelect = true;
            this.lvDanhSachToanBo.Location = new System.Drawing.Point(0, 0);
            this.lvDanhSachToanBo.Name = "lvDanhSachToanBo";
            this.lvDanhSachToanBo.OwnerDraw = true;
            this.lvDanhSachToanBo.Size = new System.Drawing.Size(1206, 592);
            this.lvDanhSachToanBo.TabIndex = 0;
            this.lvDanhSachToanBo.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachToanBo.UseSelectable = true;
            // 
            // XemToanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.lvDanhSachToanBo);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "XemToanBo";
            this.Size = new System.Drawing.Size(1206, 592);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvDanhSachToanBo;
    }
}

namespace QLDA.View.Common
{
    partial class XemTatCa
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
            this.lvXemTatCa = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvXemTatCa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 592);
            this.panel1.TabIndex = 0;
            // 
            // lvXemTatCa
            // 
            this.lvXemTatCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvXemTatCa.FullRowSelect = true;
            this.lvXemTatCa.HideSelection = false;
            this.lvXemTatCa.Location = new System.Drawing.Point(0, 0);
            this.lvXemTatCa.MultiSelect = false;
            this.lvXemTatCa.Name = "lvXemTatCa";
            this.lvXemTatCa.Size = new System.Drawing.Size(1206, 592);
            this.lvXemTatCa.TabIndex = 0;
            this.lvXemTatCa.UseCompatibleStateImageBehavior = false;
            this.lvXemTatCa.View = System.Windows.Forms.View.Details;
            // 
            // XemTatCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "XemTatCa";
            this.Size = new System.Drawing.Size(1206, 592);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvXemTatCa;
    }
}

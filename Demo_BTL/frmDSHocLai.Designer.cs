namespace Demo_BTL
{
    partial class frmDSdiem
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
            this.crvDSdiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDSdiem
            // 
            this.crvDSdiem.ActiveViewIndex = -1;
            this.crvDSdiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSdiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDSdiem.Location = new System.Drawing.Point(0, 0);
            this.crvDSdiem.Name = "crvDSdiem";
            this.crvDSdiem.Size = new System.Drawing.Size(800, 450);
            this.crvDSdiem.TabIndex = 0;
            this.crvDSdiem.Load += new System.EventHandler(this.crvDSdiem_Load);
            // 
            // frmDSdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvDSdiem);
            this.Name = "frmDSdiem";
            this.Text = "Bảng điểm chi tiết";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSdiem;
    }
}
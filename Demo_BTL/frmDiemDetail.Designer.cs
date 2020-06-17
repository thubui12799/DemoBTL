namespace Demo_BTL
{
    partial class frmDiemDetail
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
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvDiemdetail = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(317, 121);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvDiemdetail
            // 
            this.dgvDiemdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.MaMon,
            this.DiemCC,
            this.DiemKT,
            this.DiemTH,
            this.DiemThi1,
            this.DiemThi2});
            this.dgvDiemdetail.Location = new System.Drawing.Point(-1, 163);
            this.dgvDiemdetail.Name = "dgvDiemdetail";
            this.dgvDiemdetail.Size = new System.Drawing.Size(799, 205);
            this.dgvDiemdetail.TabIndex = 1;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ tên";
            this.TenSV.Name = "TenSV";
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Học phần";
            this.MaMon.Name = "MaMon";
            // 
            // DiemCC
            // 
            this.DiemCC.DataPropertyName = "DiemCC";
            this.DiemCC.HeaderText = "Chuyên cần";
            this.DiemCC.Name = "DiemCC";
            // 
            // DiemKT
            // 
            this.DiemKT.DataPropertyName = "DiemKT";
            this.DiemKT.HeaderText = "Kiểm tra";
            this.DiemKT.Name = "DiemKT";
            // 
            // DiemTH
            // 
            this.DiemTH.DataPropertyName = "DiemTH";
            this.DiemTH.HeaderText = "Thực hành";
            this.DiemTH.Name = "DiemTH";
            // 
            // DiemThi1
            // 
            this.DiemThi1.DataPropertyName = "DiemThi1";
            this.DiemThi1.HeaderText = "Điểm thi 1";
            this.DiemThi1.Name = "DiemThi1";
            // 
            // DiemThi2
            // 
            this.DiemThi2.DataPropertyName = "DiemThi2";
            this.DiemThi2.HeaderText = "Điểm thi 2";
            this.DiemThi2.Name = "DiemThi2";
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(293, 51);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 21);
            this.cbbMon.TabIndex = 2;
            // 
            // frmDiemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.dgvDiemdetail);
            this.Controls.Add(this.btnXem);
            this.Name = "frmDiemDetail";
            this.Text = "00000";
            this.Load += new System.EventHandler(this.frmDiemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemdetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvDiemdetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi2;
        private System.Windows.Forms.ComboBox cbbMon;
    }
}
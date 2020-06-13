namespace Demo_BTL
{
    partial class frmDSDiemThi
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
            this.dgvDSDiemThi = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP MỚI ĐIỂM SINH VIÊN";
            // 
            // dgvDSDiemThi
            // 
            this.dgvDSDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.MaMon,
            this.DiemCC,
            this.DiemKT,
            this.DiemThi1,
            this.DiemThi2});
            this.dgvDSDiemThi.Location = new System.Drawing.Point(35, 144);
            this.dgvDSDiemThi.Name = "dgvDSDiemThi";
            this.dgvDSDiemThi.Size = new System.Drawing.Size(733, 185);
            this.dgvDSDiemThi.TabIndex = 1;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ Tên";
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
            // DiemThi1
            // 
            this.DiemThi1.DataPropertyName = "DiemThi1";
            this.DiemThi1.HeaderText = "Điểm thi lần 1";
            this.DiemThi1.Name = "DiemThi1";
            // 
            // DiemThi2
            // 
            this.DiemThi2.DataPropertyName = "DiemThi2";
            this.DiemThi2.HeaderText = "Điểm thi lần 2";
            this.DiemThi2.Name = "DiemThi2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học phần";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(85, 75);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(100, 20);
            this.txtLop.TabIndex = 4;
            // 
            // txtMon
            // 
            this.txtMon.Location = new System.Drawing.Point(446, 74);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(100, 20);
            this.txtMon.TabIndex = 5;
            // 
            // frmDSDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSDiemThi);
            this.Controls.Add(this.label1);
            this.Name = "frmDSDiemThi";
            this.Text = "frmDSDiemThi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDiemThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMon;
    }
}
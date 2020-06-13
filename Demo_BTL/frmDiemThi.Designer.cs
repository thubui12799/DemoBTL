namespace Demo_BTL
{
    partial class frmDiemThi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.dgvDiemThi = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT ĐIỂM THI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Học phần";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(362, 64);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(92, 21);
            this.cbbLop.TabIndex = 6;
            this.cbbLop.SelectedValueChanged += new System.EventHandler(this.cbbLop_SelectedValueChanged);
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(597, 59);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(94, 21);
            this.cbbMon.TabIndex = 7;
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.DiemCC,
            this.DiemKT,
            this.DiemThi1,
            this.DiemThi2});
            this.dgvDiemThi.Location = new System.Drawing.Point(37, 176);
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.Size = new System.Drawing.Size(654, 241);
            this.dgvDiemThi.TabIndex = 9;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(217, 123);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(325, 124);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(515, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(418, 124);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(118, 64);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(98, 21);
            this.cbbKhoa.TabIndex = 5;
            this.cbbKhoa.SelectedValueChanged += new System.EventHandler(this.cbbKhoa_SelectedValueChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(635, 124);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 14;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(118, 124);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 15;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
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
            // frmDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDiemThi);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDiemThi";
            this.Text = "Cập nhật điểm thi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.DataGridView dgvDiemThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi2;
    }
}
namespace Demo_BTL
{
    partial class frmQLDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.cbbTen = new System.Windows.Forms.ComboBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "CẬP NHẬT ĐIỂM SINH VIÊN ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Chuyên cần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Điểm kiểm tra";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(769, 59);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 28;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(769, 107);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 29;
            this.btnNhap.Text = "Nhập điểm";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(769, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(769, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Học phần";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(77, 64);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbbKhoa.TabIndex = 35;
            this.cbbKhoa.SelectedValueChanged += new System.EventHandler(this.cbbKhoa_SelectedValueChanged);
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(324, 61);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(121, 21);
            this.cbbLop.TabIndex = 36;
            this.cbbLop.SelectedValueChanged += new System.EventHandler(this.cbbLop_SelectedValueChanged);
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(602, 61);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 21);
            this.cbbMon.TabIndex = 37;
            // 
            // cbbTen
            // 
            this.cbbTen.FormattingEnabled = true;
            this.cbbTen.Location = new System.Drawing.Point(77, 117);
            this.cbbTen.Name = "cbbTen";
            this.cbbTen.Size = new System.Drawing.Size(121, 21);
            this.cbbTen.TabIndex = 38;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(116, 176);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(71, 20);
            this.txtCC.TabIndex = 40;
            // 
            // txtKT
            // 
            this.txtKT.Location = new System.Drawing.Point(363, 174);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(82, 20);
            this.txtKT.TabIndex = 41;
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(92, 303);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(696, 150);
            this.dgvDiem.TabIndex = 45;
            this.dgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellContentClick_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Điểm thực hành";
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(642, 176);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(81, 20);
            this.txtTH.TabIndex = 49;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 495);
            this.Controls.Add(this.txtTH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.txtKT);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.cbbTen);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQLDiem";
            this.Text = "Quản lí điểm";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbTen;
    }
}
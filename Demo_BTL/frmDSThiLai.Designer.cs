namespace Demo_BTL
{
    partial class frmDSThiLai
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMon = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN CHƯA ĐẠT THEO CÁC HỌC PHẦN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(127, 64);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(121, 21);
            this.cbbLop.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn học";
            // 
            // cbbMon
            // 
            this.cbbMon.FormattingEnabled = true;
            this.cbbMon.Location = new System.Drawing.Point(517, 63);
            this.cbbMon.Name = "cbbMon";
            this.cbbMon.Size = new System.Drawing.Size(121, 21);
            this.cbbMon.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMon,
            this.DiemCC,
            this.DiemKT,
            this.DiemThi1,
            this.DiemThi2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(39, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 235);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(299, 117);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
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
            this.DiemThi1.HeaderText = "Điểm thi 1";
            this.DiemThi1.Name = "DiemThi1";
            this.DiemThi1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DiemThi2
            // 
            this.DiemThi2.DataPropertyName = "DiemThi2";
            this.DiemThi2.HeaderText = "Điểm thi 2";
            this.DiemThi2.Name = "DiemThi2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // frmDSThiLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDSThiLai";
            this.Text = "Danh sách thi lại";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_BTL
{
    public partial class frmQLSV : Form
    {
        string str = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Quanlydiem;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQLSV()
        {
            InitializeComponent();
            load_cbbKhoa();
            load_cbbLop();
            load_gridDSSV();
        }
        private void load_gridDSSV()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblSINH_VIEN", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvDSSV.DataSource = table;
        }
        private void load_cbbKhoa()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKHOA", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            DataRow dr = table.NewRow();
            dr["MaKhoa"] = "";
            dr["TenKhoa"] = "---Chọn Khoa---";
            table.Rows.InsertAt(dr, 0);
            cbbKhoaSearch.DataSource = table;
            cbbKhoaSearch.DisplayMember = "TenKhoa";
            cbbKhoaSearch.ValueMember = "MaKhoa";
        }
        private void load_cbbLop()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblLOP", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            DataRow dr = table.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "---Chọn Lớp---";
            table.Rows.InsertAt(dr, 0);
            cboMalop.DataSource = table;
            cboMalop.DisplayMember = "TenLop";
            cboMalop.ValueMember = "MaLop";
        }

        private void dgrDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgvDSSV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvDSSV.CurrentRow.Cells[1].Value.ToString();
            mskNgaySinh.Text = dgvDSSV.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgvDSSV.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDSSV.CurrentRow.Cells[4].Value.ToString();
            cboMalop.Text = dgvDSSV.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From tblSINH_VIEN where Masv='" + txtMaSV.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            }
            else if (cboMalop.Text == "")
            {
                errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");
            }
            else if (reader.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã sinh viên ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                cmd.Dispose();
                reader.Dispose();
            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblSINH_VIEN(MaSV,HoTen,Ngaysinh,Gioitinh,DiaChi,Malop)" +
                                "Values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" +
                                mskNgaySinh.Text + "',N'" + cboGioiTinh.Text + "',N'" + txtDiaChi.Text + "','" +
                                cboMalop.Text + "')", connection);
                cmdINSERT.ExecuteNonQuery();
                load_gridDSSV();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            cmd.Dispose();
            reader.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select MaSv from tblKET_QUA where MaSv='" + txtMaSV.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Sinh viên " + txtMaSV.Text + " từ bảng Kết quả học tập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdDELETE = new SqlCommand("delete from tblSINH_VIEN where MaSv='" + txtMaSV.Text + "'", connection);
                cmdDELETE.ExecuteNonQuery();
                load_gridDSSV();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmdDELETE.Dispose();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaSV.Text == "")
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            else if (cboMalop.Text == "")
                errorProvider1.SetError(cboMalop, "Mã lớp không để trống!");
            else
            {
                SqlCommand cmd = new SqlCommand("Update tblSINH_VIEN Set HoTen=N'" + txtHoTen.Text + "',NgaySinh='" +
                                mskNgaySinh.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',DiaChi=N'" +
                                txtDiaChi.Text + "',MaLop='" + cboMalop.Text + "'where MaSV='" + txtMaSV.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridDSSV();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

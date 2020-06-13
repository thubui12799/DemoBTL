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
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=DiemSV;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQLSV()
        {
            InitializeComponent();
            load_cbbKhoa();
           
            load_gridDSSV();
        }
        private void load_gridDSSV()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SINH_VIEN", connection);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOA", connection);
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
            SqlCommand cmd = new SqlCommand("Select * From SINH_VIEN where Masv='" + txtMaSV.Text + "'", connection);
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
                SqlCommand cmdINSERT = new SqlCommand("Insert Into SINH_VIEN(MaSV,TenSV,Ngaysinh,Gioitinh,QueQuan,Malop)" +
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
            SqlCommand cmd = new SqlCommand("Select MaSV from DIEM_QUA_TRINH where MaSV='" + txtMaSV.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Sinh viên " + txtMaSV.Text + " từ bảng Điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdDELETE = new SqlCommand("delete from SINH_VIEN where MaSV='" + txtMaSV.Text + "'", connection);
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
                SqlCommand cmd = new SqlCommand("Update SINH_VIEN Set TenSV=N'" + txtHoTen.Text + "',NgaySinh='" +
                                mskNgaySinh.Text + "',GioiTinh=N'" + cboGioiTinh.Text + "',QueQuan=N'" +
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

        private void cbbKhoaSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            string v = cbbKhoaSearch.SelectedValue.ToString();
            string p_khoa = v;
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP where MaKhoa = N'"+p_khoa+"'", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            DataRow dr = table.NewRow();
            dr["MaLop"] = "";
           // dr["TenLop"] = "---Chọn Lớp---";
            table.Rows.InsertAt(dr, 0);
            cbbLopSearch.DataSource = table;
            cbbLopSearch.DisplayMember = "MaLop";
            cbbLopSearch.ValueMember = "MaLop";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string p_lop = cbbKhoaSearch.SelectedValue.ToString();
            



            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("search_sinhvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = p_lop;
            

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDSSV.DataSource = dt;
            dgvDSSV.Refresh();
            conn.Close();
        }
    }
}

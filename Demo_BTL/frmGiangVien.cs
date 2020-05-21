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
    public partial class frmGiangVien : Form
    {
        string str = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmGiangVien()
        {
            InitializeComponent();
            load_gridGV();
        }
        private void load_gridGV()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblGIANG_VIEN", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvGiangvien.DataSource = table;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblGIANG_VIEN where MaGV='" + txtMaGV.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaGV.Text == "")
            {
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            }

            else if (reader.Read())
            {
                MessageBox.Show("Bạn đã nhập trùng mã giảng viên", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                cmd.Dispose();
                reader.Dispose();
            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblGIANG_VIEN(MaGV,TenGV,Gioitinh,Phone,Email)" +
                                "Values('" + txtMaGV.Text + "',N'" + txtHoTen.Text + "',N'" + cboGioiTinh.Text + "','" +
                                mskPhone.Text + "','" + txtEmail.Text + "')", connection);

                cmdINSERT.ExecuteNonQuery();
                load_gridGV();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            cmd.Dispose();
            reader.Dispose();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaGV.Text == "")
                errorProvider1.SetError(txtMaGV, "Mã giảng viên không để trống!");
            else
            {
                SqlCommand cmd = new SqlCommand("Update tblGIANG_VIEN Set TenGV=N'" + txtHoTen.Text + "',GioiTinh=N'" +
                                cboGioiTinh.Text + "',Phone='" + mskPhone.Text + "',Email='" +
                                txtEmail.Text + "' where MaGV='" + txtMaGV.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridGV();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void dgvGiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvGiangvien.CurrentRow.Index;
            txtMaGV.Text = dgvGiangvien.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvGiangvien.Rows[i].Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvGiangvien.Rows[i].Cells[2].Value.ToString();
            mskPhone.Text = dgvGiangvien.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvGiangvien.Rows[i].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from tblGIANG_VIEN where MaGV='" + txtMaGV.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridGV();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

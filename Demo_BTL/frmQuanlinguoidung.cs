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
    public partial class frmQuanlinguoidung : Form
    {
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQuanlinguoidung()
        {
            InitializeComponent();
            load_gridLogin();
        }
        private void load_gridLogin()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblLOGIN", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvLogin.DataSource = table;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From tblLOGIN where TenDN='" + txtTaikhoan.Text + "'", connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
            {
                errorProvider1.SetError(txtTaikhoan, "Tên tài khoản không  để trống !");
                txtTaikhoan.Focus();
            }
            else if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "Bạn chưa nhập mật khẩu !");
                txtMK.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider1.SetError(txtConfimMk, "Bạn chưa nhập lại mật khẩu !");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMK.Text)

                MessageBox.Show("Bạn nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (reader.Read())
            {
                MessageBox.Show("Tài khoản " + txtTaikhoan.Text + " đã tồn tại", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
                cmd.Dispose();
                reader.Dispose();
            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                string insert = "Insert Into tblLOGIN(TenDN,MatKhau,HoTen,Quyen)" +
                                "Values('" + txtTaikhoan.Text + "','" + txtMK.Text + "',N'" + txtHoTen.Text + "',N'" + cboQuyen.Text + "')";
                SqlCommand cmdINSERT = new SqlCommand(insert, connection);
                cmdINSERT.ExecuteNonQuery();
                load_gridLogin();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            cmd.Dispose();
            reader.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Tên tài khoản không để trống!");
            else
            {
                SqlCommand cmd = new SqlCommand("Update tblLOGIN Set MatKhau=N'" + txtMK.Text + "',HoTen=N'" + txtHoTen.Text + "',Quyen=N'" + cboQuyen.Text + "' where TenDN='" + txtTaikhoan.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridLogin();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void dgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLogin.CurrentRow.Index;
            txtTaikhoan.Text = dgvLogin.Rows[i].Cells[0].Value.ToString();
            txtMK.Text = dgvLogin.Rows[i].Cells[1].Value.ToString();
            txtHoTen.Text = dgvLogin.Rows[i].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from tblLOGIN where TenDN='" + txtTaikhoan.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridLogin();
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

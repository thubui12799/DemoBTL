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
    public partial class frmDoimatkhau : Form
    {
        string str = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblLOGIN where TenDN='" + txtTaikhoan.Text + "' and MatKhau='" + txtMKcu.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Chưa nhập tên tài khoản !");
            else if (txtMKcu.Text == "")
            {
                errorProvider1.SetError(txtMKcu, "Nhập mật khẩu cũ vào nè!");
                txtMKcu.Focus();
            }
            else if (txtMKmoi.Text == "")
            {
                errorProvider1.SetError(txtMKmoi, "Mật khẩu mới cậu ơi!");
                txtMKmoi.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider1.SetError(txtConfimMk, "Chỗ này vẫn chưa nhập nè!");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMKmoi.Text)
                MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (reader.Read())
            {
                cmd.Dispose();
                reader.Dispose();
                SqlCommand cmdUPDATE = new SqlCommand("Update tblLOGIN Set MatKhau='" + txtMKmoi.Text + "' where TenDN='" + txtTaikhoan.Text + "'", connection);
                cmdUPDATE.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmdUPDATE.Dispose();
            }
            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();
            }
            cmd.Dispose();
            reader.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


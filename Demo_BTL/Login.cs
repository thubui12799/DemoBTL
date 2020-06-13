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
    public partial class Login : Form
    {
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tbllogin where TenDN='" + txtTenDN.Text + "' and MatKhau='" + txtMatKhau.Text + "' and Quyen='Admin'", connection);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                frmMain frm = new frmMain();
                frm.Show();
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

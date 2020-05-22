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
    public partial class frmKhoa : Form
    {
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmKhoa()
        {
            InitializeComponent();
            load_gridKhoa();
        }
        private void load_gridKhoa()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKHOA", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvKhoa.DataSource = table;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblKHOA where MaKhoa='" + txtMaKhoa.Text + "'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaKhoa.Text == "")
            {
                errorProvider1.SetError(txtMaKhoa, "Mã Khoa không để trống!");
            }

            else if (reader.Read())
            {
                MessageBox.Show("Thông tin bạn nhập đã có rồi", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                cmd.Dispose();
                reader.Dispose();
            }
            else
            {
                cmd.Dispose();
                reader.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblKHOA(MaKhoa,TenKhoa)" +
                                "Values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')", connection);

                cmdINSERT.ExecuteNonQuery();
                load_gridKhoa();
                MessageBox.Show("Thêm mới thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            cmd.Dispose();
            reader.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtMaKhoa.Text == "")
                errorProvider1.SetError(txtMaKhoa, "Mã Khoa không để trống!");
            else
            {
                SqlCommand cmd = new SqlCommand("Update tblKHOA Set TenKhoa=N'" + txtTenKhoa.Text + "' where MaKhoa='" + txtMaKhoa.Text + "'", connection);
                cmd.ExecuteNonQuery();
                load_gridKhoa();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhoa.CurrentRow.Index;
            txtMaKhoa.Text = dgvKhoa.Rows[i].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[i].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select MaKhoa from tblLOP where MaKhoa='" + txtMaKhoa.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Mã Khoa " + txtMaKhoa.Text + " từ bảng Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdDELETE = new SqlCommand("delete from tblKHOA where MaKhoa='" + txtMaKhoa.Text + "'", connection);
                cmdDELETE.ExecuteNonQuery();
                load_gridKhoa();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmdDELETE.Dispose();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

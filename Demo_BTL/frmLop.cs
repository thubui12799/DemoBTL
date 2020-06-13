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
    public partial class frmLop : Form
    {
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmLop()
        {
            InitializeComponent();
            load_gridLop();
            load_cbbKhoa();
        }
        private void load_gridLop()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblLOP", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvLop.DataSource = table;
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
           // dr["TenKhoa"] = "---Chọn Khoa---";
            table.Rows.InsertAt(dr, 0);
            cboKhoa.DataSource = table;
            cboKhoa.DisplayMember = "MaKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select MaKhoa from tblKHOA where MaKhoa='" + cboKhoa.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaLop.Text == "")
            {
                errorProvider1.SetError(txtMaLop, "!");
                txtMaLop.Focus();
            }
            else if (txtMaLop.Text == dgvLop.CurrentRow.Cells[1].Value.ToString())
            {
                errorProvider1.SetError(txtMaLop, "!");
                MessageBox.Show("Mã lớp đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
            }
            else if (reader.Read())
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblLOP(MaLop,TenLop,Makhoa)" +
                                       "Values('" + txtMaLop.Text + "',N'" + txtTenlop.Text + "','" + cboKhoa.Text + "')", connection);
                cmdINSERT.ExecuteNonQuery();
                load_gridLop();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            else
            {
                MessageBox.Show("Nhập mã khoa không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoa.Focus();
                reader.Dispose();
                cmd.Dispose();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLop.CurrentRow.Index;
            cboKhoa.Text = dgvLop.Rows[i].Cells[2].Value.ToString();
            txtMaLop.Text = dgvLop.Rows[i].Cells[0].Value.ToString();
            txtTenlop.Text = dgvLop.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update tblLOP Set MaKhoa='" + cboKhoa.Text + "',MaLop='" + txtMaLop.Text + "',TenLop='" +
                            txtTenlop.Text + "' where MaLop='" + txtMaLop.Text + "' ", connection);
            cmd.ExecuteNonQuery();
            load_gridLop();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
                SqlCommand cmdDELETE = new SqlCommand("delete from tblLOP where MaLop='" + txtMaLop.Text + "'", conn);
                cmdDELETE.ExecuteNonQuery();
                
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmdDELETE.Dispose();
            load_gridLop();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

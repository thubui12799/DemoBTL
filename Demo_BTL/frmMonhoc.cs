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
    public partial class frmMonhoc : Form
    {
        string str = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmMonhoc()
        {
            InitializeComponent();
            load_cbbKhoa();
            load_gridMon();
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
            cboKhoa.DataSource = table;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }
        private void load_gridMon()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblMON", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvMON.DataSource = table;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select MaMon from tblMON where MaMon='" + txtMaMon.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaMon.Text == "")
            {
                errorProvider1.SetError(txtMaMon, "Mã môn không để trống!");
            }
            else if (reader.Read())
            {
                {
                    MessageBox.Show("Bạn đã nhập thông tin cho môn: " + txtTenMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMon.Focus();
                }
                reader.Dispose();
                cmd.Dispose();
            }
            else
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblMON(MaMon,TenMon,SoDVHT,MaGV,MaKhoa)" +
                                       "Values('" + txtMaMon.Text + "',N'" + txtTenMon.Text + "','" + txtSDVHT.Text + "','" +
                                       txtMaGV.Text + "','" + cboKhoa.SelectedValue.ToString() + "')", connection);
                cmdINSERT.ExecuteNonQuery();
                load_gridMon();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update tblMON Set TenMon=N'" + txtTenMon.Text + "',SoDVHT='" +
                            txtSDVHT.Text + "',MaGV='" + txtMaGV.Text + "',MaKhoa='" + cboKhoa.Text + "' where MaMon='" + txtMaMon.Text + "' ", connection);
            cmd.ExecuteNonQuery();
            load_gridMon();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.Dispose();
        }

        private void dgvMON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMON.CurrentRow.Index;
            txtMaMon.Text = dgvMON.Rows[i].Cells[0].Value.ToString();
            txtTenMon.Text = dgvMON.Rows[i].Cells[1].Value.ToString();
            txtSDVHT.Text = dgvMON.Rows[i].Cells[2].Value.ToString();
            txtMaGV.Text = dgvMON.Rows[i].Cells[3].Value.ToString();
            cboKhoa.Text = dgvMON.Rows[i].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tblMON where MaMon='" + txtMaMon.Text + "' ", connection);
            cmd.ExecuteNonQuery();
            load_gridMon();
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
            cmd.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

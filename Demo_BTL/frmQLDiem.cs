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
    public partial class frmQLDiem : Form
    {
        string str = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQLDiem()
        {
            InitializeComponent();
            load_gridDiem();
            load_cbbLop();
            load_cbbMon();
        }
        private void load_gridDiem()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblKET_QUA", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dgvDiem.DataSource = table;
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
            cbbLop.DataSource = table;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }
        private void load_cbbMon()
        {
            connection = new SqlConnection(str);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblMON", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            DataRow dr = table.NewRow();
            dr["MaMon"] = "";
            dr["TenMon"] = "---Chọn Môn---";
            table.Rows.InsertAt(dr, 0);
            cbbMon.DataSource = table;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "MaMon";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select MaSV from tblSINH_VIEN where MaSV=N'" + txtMaSV.Text + "' and Hoten=N'" + txtHoTen.Text + "' ", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            errorProvider1.Clear();
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
                txtMaSV.Focus();
            }
            else if (txtMaSV.Text == dgvDiem.CurrentRow.Cells[0].Value.ToString() && cbbMon.Text == dgvDiem.CurrentRow.Cells[3].Value.ToString())
            {
                {
                    MessageBox.Show("Sinh viên này đã được nhập điểm môn: " + cbbMon.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                }
            }
            else if (cbbLop.Text == "")
            {
                errorProvider1.SetError(cbbLop, "Mã lớp không để trống!");
                cbbLop.Focus();
            }
            else if (cbbMon.Text == "")
            {
                errorProvider1.SetError(cbbMon, "Mã môn không để trống!");
                cbbMon.Focus();
            }
            else if (reader.Read())
            {
                reader.Dispose();
                cmd.Dispose();
                SqlCommand cmdINSERT = new SqlCommand("Insert Into tblKET_QUA(MaSV,HoTen,MaLop,MaMon,DiemCC,DiemGK,DiemCK,DiemTK,GhiChu)" +
                                                      "Values('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" + cbbLop.SelectedValue.ToString() + "',N'" + cbbMon.SelectedValue.ToString() + "','" + txtDiemCC.Text + "','" +
                                                      txtDiemGK.Text + "','" + txtDiemCK.Text + "',N'" + txtDiemTK.Text + "',N'" + txtGhiChu.Text + "')", connection);
                cmdINSERT.ExecuteNonQuery();
                load_gridDiem();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");
                cmdINSERT.Dispose();
            }
            else
            {
                {
                    MessageBox.Show("Nhập mã sinh viên không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Focus();
                }
                reader.Dispose();
                cmd.Dispose();
            }
            reader.Dispose();
            cmd.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không để trống!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update tblKET_QUA Set HoTen=N'" + txtHoTen.Text + "',MaMon=N'" + cbbMon.SelectedValue.ToString() + "',MaLop='" +
                                cbbLop.SelectedValue.ToString() + "',DiemCC='" + txtDiemCC.Text + "',DiemGK='" + txtDiemGK.Text + "' ,DiemCK='" +
                                txtDiemCK.Text + "',DiemTK='" + txtDiemTK.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaSV='" + txtMaSV.Text + "' and MaMon=N'" + cbbMon.SelectedValue.ToString() + "'", connection); ;
                cmd.ExecuteNonQuery();
                load_gridDiem();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from tblKET_QUA where MaSV='" + txtMaSV.Text + "' and MaMon='" + cbbMon.Text + "' ", connection);
                cmd.ExecuteNonQuery();
                load_gridDiem();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmd.Dispose();
            }
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDiem.CurrentRow.Index;
            txtMaSV.Text = dgvDiem.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDiem.Rows[i].Cells[1].Value.ToString();
            cbbLop.Text = dgvDiem.Rows[i].Cells[2].Value.ToString();
            cbbMon.Text = dgvDiem.Rows[i].Cells[3].Value.ToString();
            txtDiemCC.Text = dgvDiem.Rows[i].Cells[4].Value.ToString();
            txtDiemGK.Text = dgvDiem.Rows[i].Cells[5].Value.ToString();
            txtDiemCK.Text = dgvDiem.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float DIEMCC = float.Parse(txtDiemCC.Text);
            float DIEMGK = float.Parse(txtDiemGK.Text);
            float DIEMCK = float.Parse(txtDiemCK.Text);
            txtDiemTK.Text = Convert.ToString(0.1 * DIEMCC + 0.2 * DIEMGK + 0.7 * DIEMCK);
            float DIEMTK = float.Parse(this.txtDiemTK.Text);
            if ((DIEMTK <= 4.0))
            {
                this.txtGhiChu.Text = "Thi lại";
            }
            else
            {
                this.txtGhiChu.Text = "";
            }
        }
    }
}

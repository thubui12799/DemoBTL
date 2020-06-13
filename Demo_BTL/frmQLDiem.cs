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
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLSV_BTL;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQLDiem()
        {
            InitializeComponent();
            load_gridDiem();
            load_khoa();
            load_Mon();
            
           
        }
        private void load_gridDiem()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblKET_QUA", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable tb = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(tb);
            dgvDiem.DataSource = tb;
            dgvDiem.Refresh();

        }

        private void load_khoa()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblKHOA", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaKhoa"] = "";
            dr["TenKhoa"] = "--Chọn khoa--";
            dt.Rows.InsertAt(dr, 0);
            cbbKhoa.DataSource = dt;
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
            
            conn.Close();
        }
        private void load_Mon()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblMON", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["MaMon"] = "--------------";
 
            dt.Rows.InsertAt(dr, 0);
            cbbMon.DataSource = dt;
            cbbMon.DisplayMember = "MaMon";
            cbbMon.ValueMember = "MaMon";
            conn.Close();
        }
       
       
        private void frmQLDiem_Load(object sender, EventArgs e)
        {

        }

        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_khoa = cbbKhoa.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tblLOP where MaKhoa = N'" + p_khoa + "'", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["MaLop"] = "--Chọn lớp--";
            dt.Rows.InsertAt(dr, 0);
            cbbLop.DataSource = dt;
            cbbLop.ValueMember = "MaLop";
        }

     /*   private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_lop = cbbLop.SelectedValue.ToString();

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblSINH_VIEN where MaLop = N'" + p_lop + "'", conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaSV"] = "";
            dr["HoTen"] = "--Chọn sv--";
            
            dt.Rows.InsertAt(dr, 0);
            cbbTen.DataSource = dt;
            cbbTen.ValueMember = "MaSV";
            cbbTen.DisplayMember = "HoTen";
            conn.Close();
        }*/
       /* private void load_ten()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblSINH_VIEN ", conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaSV"] = "";
            dr["HoTen"] = "--Chọn sv--";

            dt.Rows.InsertAt(dr, 0);
            cbbTen.DataSource = dt;
            cbbTen.ValueMember = "MaSV";
            cbbTen.DisplayMember = "HoTen";
            conn.Close();
        }*/

        

        private void btnNhap_Click(object sender, EventArgs e)
        {
          string p_masv = cbbTen.SelectedValue.ToString();
            string p_hoten = cbbTen.Text;
            string p_lop = cbbLop.SelectedValue.ToString();
            string p_mon = cbbMon.SelectedValue.ToString();
            string p_CC = txtCC.Text;
            string p_KT = txtKT.Text;
            string p_TH = txtTH.Text;

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into tblKET_QUA (MaSV, HoTen, MaLop, MaMon, DiemCC, DiemGK,  DiemTH)" +
                                       "Values ( N'" + p_masv + "',N'" + p_hoten + "','" + p_lop + "',N'" + p_mon + "','" + p_CC + "','" + p_KT + "',  '" + p_TH + "')", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Thêm mới thành công!", "Thông báo");
            load_gridDiem();
        }

        private void dgvDiem_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            cbbTen.Text = dgvDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbTen.Text = dgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbLop.Text = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbMon.Text = dgvDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCC.Text = dgvDiem.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtKT.Text = dgvDiem.Rows[e.RowIndex].Cells[5].Value.ToString();
           

            cbbTen.Enabled = false;
            cbbLop.Enabled = false;
            cbbTen.Enabled = false;
            cbbKhoa.Enabled = false;
            cbbMon.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string p_CC = txtCC.Text;
            string p_KT = txtKT.Text;
      
            string p_masv = cbbTen.Text;
            string p_TH = txtTH.Text;

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update tblKET_QUA set DiemCC = '" + p_CC + "', DiemGK = '" + p_KT + "' ,DiemTH = '" + p_TH + "' where MaSV = '" + p_masv+"' ", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
           MessageBox.Show("Cập nhật thành công!", "Thông báo");
            load_gridDiem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string p_masv = cbbTen.Text;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from tblKET_QUA where MaSV = '" + p_masv + "' ", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Đã xóa dữ liệu!", "Thông báo");
            load_gridDiem();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        { 
            string p_masv = cbbTen.SelectedValue.ToString();
            string p_hoten = cbbTen.SelectedValue.ToString();
            string p_lop = cbbLop.SelectedValue.ToString();
            string p_mon = cbbMon.SelectedValue.ToString();

            
                 
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Timkiem_ketqua", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50).Value = p_hoten;
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = p_lop;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;

            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDiem.DataSource = dt;
            dgvDiem.Refresh();
            conn.Close();
        }

        private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_lop = cbbLop.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblSINH_VIEN where MaLop = '"+p_lop+"'", conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaSV"] = "";
            dr["HoTen"] = "--Chọn sv--";

            dt.Rows.InsertAt(dr, 0);
            cbbTen.DataSource = dt;
            cbbTen.ValueMember = "MaSV";
            cbbTen.DisplayMember = "HoTen";
            conn.Close();
        }
    }
}

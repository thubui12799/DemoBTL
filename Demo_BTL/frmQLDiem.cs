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
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLD_Nhom3;Integrated Security=True";
        SqlConnection connection = new SqlConnection();
        public frmQLDiem()
        {
            InitializeComponent();
            load_gridDiem();
            load_khoa();



        }
        private void load_gridDiem()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaSV, MaMon, DiemCC, DiemKT, DiemTH from DIEM_QUA_TRINH", conn);
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
            SqlCommand cmd = new SqlCommand("Select * from KHOA", conn);
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

        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_khoa = cbbKhoa.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from LOP where MaKhoa = N'" + p_khoa + "'", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "--Chọn lớp--";
            dt.Rows.InsertAt(dr, 0);
            cbbLop.DataSource = dt;
            cbbLop.ValueMember = "MaLop";
            cbbLop.DisplayMember = "TenLop";


            SqlCommand cmd2 = new SqlCommand("Select * from MON_HOC where  MaKhoa = N'" + p_khoa + "'", conn);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            DataRow dr2 = dt2.NewRow();
            dr2["MaMon"] = "";
            dr2["TenMon"] = "--Chọn--";
            dt2.Rows.InsertAt(dr2, 0);
            cbbMon.DataSource = dt2;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "MaMon";
            conn.Close();


        }

        private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_lop = cbbLop.SelectedValue.ToString();

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SINH_VIEN where MaLop = N'" + p_lop + "'", conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaSV"] = "";
            dr["TenSV"] = "--Chọn sv--";

            dt.Rows.InsertAt(dr, 0);
            cbbTen.DataSource = dt;
            cbbTen.ValueMember = "MaSV";
            cbbTen.DisplayMember = "TenSV";
            conn.Close();
        }



        private void btnNhap_Click(object sender, EventArgs e)
        {
            string p_masv = cbbTen.SelectedValue.ToString();
            string p_lop = cbbLop.SelectedValue.ToString();
            string p_mon = cbbMon.SelectedValue.ToString();
            string p_CC = txtCC.Text;
            string p_KT = txtKT.Text;
            string p_TH = txtTH.Text;

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert_diemquatrinh", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;
            cmd.Parameters.Add("@DiemCC", SqlDbType.Float).Value = p_CC;
            cmd.Parameters.Add("@DiemKT", SqlDbType.Float).Value = p_KT;
            cmd.Parameters.Add("@DiemTH", SqlDbType.Float).Value = p_TH;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Thêm mới thành công!", "Thông báo");
            load_gridDiem();
        }

        private void dgvDiem_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            cbbTen.Text = dgvDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            //cbbTen.Text = dgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
            // cbbLop.Text = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbMon.Text = dgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCC.Text = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKT.Text = dgvDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTH.Text = dgvDiem.Rows[e.RowIndex].Cells[4].Value.ToString();


            cbbTen.Enabled = false;
            cbbLop.Enabled = false;
            cbbTen.Enabled = false;
            cbbKhoa.Enabled = false;
            cbbMon.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string p_masv = dgvDiem.CurrentRow.Cells["MaSV"].Value.ToString();
            string p_mamon = dgvDiem.CurrentRow.Cells["MaMon"].Value.ToString();
            float p_diemcc = float.Parse(dgvDiem.CurrentRow.Cells["DiemCC"].Value.ToString());
            float p_diemkt = float.Parse(dgvDiem.CurrentRow.Cells["DiemKT"].Value.ToString());
            float p_diemth = float.Parse(dgvDiem.CurrentRow.Cells["DiemTH"].Value.ToString());


            Sua_diemQT(p_masv, p_mamon, p_diemcc, p_diemkt, p_diemth);

            MessageBox.Show("Cập nhật dữ liệu thành công");
        }
        private void Sua_diemQT(string p_masv, string p_mamon, float p_diemcc, float p_diemkt, float p_diemth)
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update_diemQT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mamon;
            cmd.Parameters.Add("@DiemCC", SqlDbType.NVarChar, 50).Value = p_diemcc;
            cmd.Parameters.Add("@DiemKT", SqlDbType.NVarChar, 50).Value = p_diemkt;
            cmd.Parameters.Add("@DiemTH", SqlDbType.NVarChar, 50).Value = p_diemth;


            cmd.ExecuteNonQuery();
            dgvDiem.Refresh();
            cmd.Dispose();
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string p_masv = dgvDiem.CurrentRow.Cells["MaSV"].Value.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from DIEM_QUA_TRINH where MaSV = '" + p_masv + "' ", conn);
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
            SqlCommand cmd = new SqlCommand("timkiem_diemQT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            //cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50).Value = p_hoten;
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



        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DiemDetail CR = new DiemDetail();
            //SqlConnection conn = new SqlConnection(connect);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("DS_DIEM", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DS_DIEM f = new DS_DIEM();

            DS_DIEM form = new DS_DIEM();
            form.Show();
            
        }
    }
}

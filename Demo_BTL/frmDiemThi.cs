using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_BTL
{
    public partial class frmDiemThi : Form
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLD_Nhom3;Integrated Security=True";
        public frmDiemThi()
        {
            InitializeComponent();
            load_khoa();
            load_gridview();
            

        }
        private void load_khoa()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from KHOA ", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaKhoa"] = "";
            dr["TenKhoa"] = "---Chọn khoa---";
            dt.Rows.InsertAt(dr, 0);
            cbbKhoa.DataSource = dt;
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
        }
        private void load_gridview()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
       
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDiemThi.DataSource = dt;
            dgvDiemThi.Refresh();


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
   
        
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
           string p_masv = dgvDiemThi.CurrentRow.Cells["MaSV"].Value.ToString();
            string p_mon = dgvDiemThi.CurrentRow.Cells["MaMon"].Value.ToString();
            float p_diemthi1 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi1"].Value.ToString());
            float p_diemthi2 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi2"].Value.ToString());
            string p_ghichu = dgvDiemThi.CurrentRow.Cells["GhiChu"].Value.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update_diemthi", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;
            cmd.Parameters.Add("@DiemThi1", SqlDbType.Float).Value = p_diemthi1;
            cmd.Parameters.Add("@DiemThi2", SqlDbType.Float).Value = p_diemthi2;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = p_ghichu;
           
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Cập nhật dữ liệu thành công");

        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            string p_mon = cbbMon.SelectedValue.ToString();
            string p_masv = cbbTen.SelectedValue.ToString();
            float p_diemthi1 = float.Parse(txtDiemThi1.Text);
            float p_diemthi2 = float.Parse(txtDiemThi2.Text);
            string p_ghichu = txtGhiChu.Text;
            string p_ten = cbbTen.Text;
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
           // cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon ;
            cmd.Parameters.Add("@DiemThi1", SqlDbType.Float).Value = p_diemthi1;
            cmd.Parameters.Add("@DiemThi2", SqlDbType.Int).Value = p_diemthi2;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = p_ghichu;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            load_gridview();
            conn.Close();
            MessageBox.Show("Thêm dữ liệu thành công");


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string p_mon = dgvDiemThi.CurrentRow.Cells["MaMon"].Value.ToString();
            string p_masv = dgvDiemThi.CurrentRow.Cells["MaSV"].Value.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            load_gridview();
            conn.Close();
            MessageBox.Show("Xóa dữ liệu thành công!");
        }
    }

}

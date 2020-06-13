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
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=DiemSV;Integrated Security=True";
        public frmDiemThi()
        {
            InitializeComponent();
            load_khoa();
            

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


        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string p_khoa = cbbKhoa.SelectedValue.ToString();

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from LOP where MaKhoa = '" + p_khoa + "'", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.NewRow();
            dr["MaLop"] = "";
            dr["TenLop"] = "---Chọn lớp---";
            dt.Rows.InsertAt(dr, 0);
            cbbLop.DataSource = dt;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";


            
        }


        private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string p_lop = cbbLop.SelectedValue.ToString();
            
            SqlCommand cmd = new SqlCommand("select_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = p_lop;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDiemThi.DataSource = dt;

            SqlCommand cmd2 = new SqlCommand("Select * from MON_HOC where MaLop = '" + p_lop + "' ", conn);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            DataRow row = dt2.NewRow();
            row["MaMon"] = "";
            row["TenMon"] = "---Chọn học phần---";
            dt2.Rows.InsertAt(row, 0);
            cbbMon.DataSource = dt2;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "MaMon";
            conn.Close();


            
        }
   
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string p_masv = dgvDiemThi.CurrentRow.Cells["MaSV"].Value.ToString();
            string p_mamon = cbbMon.SelectedValue.ToString();
            float p_diemcc = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemCC"].Value.ToString());
            float p_diemkt = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemKT"].Value.ToString());
            float p_diemthi1 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi1"].Value.ToString());
            float p_diemthi2 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi2"].Value.ToString());
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("insert_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mamon;
            cmd.Parameters.Add("@DiemCC", SqlDbType.Float).Value = p_diemcc;
            cmd.Parameters.Add("@DiemKT", SqlDbType.Float).Value = p_diemkt;
            cmd.Parameters.Add("@DiemThi1", SqlDbType.Float).Value = p_diemthi1;
            cmd.Parameters.Add("@DiemThi2", SqlDbType.Float).Value = p_diemthi2;
                cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            

         
            MessageBox.Show("Cập nhật dữ liệu thành công");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string p_khoa = cbbKhoa.SelectedValue.ToString();
            string p_lop = cbbLop.SelectedValue.ToString();
            string p_mon = cbbMon.SelectedValue.ToString();
            //   string p_masv = cbbMaSV.SelectedValue.ToString();

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("timkiem_diemthi", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@lop", SqlDbType.NVarChar, 50).Value = p_lop;
            cmd.Parameters.Add("@mamon", SqlDbType.NVarChar, 50).Value = p_mon;
            //  cmd.Parameters.Add("@masv", SqlDbType.NVarChar, 50).Value = p_masv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
           dgvDiemThi.DataSource = dt;
           dgvDiemThi.Refresh();
            conn.Close();
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
           string p_masv = dgvDiemThi.CurrentRow.Cells["MaSV"].Value.ToString();
            string p_mamon = cbbMon.SelectedValue.ToString();
            float p_diemcc = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemCC"].Value.ToString());
            float p_diemkt = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemKT"].Value.ToString());
            float p_diemthi1 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi1"].Value.ToString());
            float p_diemthi2 = float.Parse(dgvDiemThi.CurrentRow.Cells["DiemThi2"].Value.ToString());

            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update_diemthi", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mamon;
            cmd.Parameters.Add("@DiemCC", SqlDbType.Float).Value = p_diemcc;
            cmd.Parameters.Add("@DiemKT", SqlDbType.Float).Value = p_diemkt;
            cmd.Parameters.Add("@DiemThi1", SqlDbType.Float).Value = p_diemthi1;
            cmd.Parameters.Add("@DiemThi2", SqlDbType.Float).Value = p_diemthi2;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            MessageBox.Show("Cập nhật dữ liệu thành công");

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string p_lop = cbbLop.Text;
            string p_mon = cbbMon.SelectedValue.ToString();
            frmDSDiemThi form = new frmDSDiemThi(p_lop, p_mon);
            form.Show();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string p_lop = cbbLop.SelectedValue.ToString();
            string p_mon = cbbMon.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("hienthi_diemthi", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = p_lop;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;
            
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            dgvDiemThi.DataSource = dt;
            conn.Close();
        }
    }

        
     /*    private void xoa_diemthi(string p_masv, string p_mamon)
         {

             SqlConnection conn = new SqlConnection(connect);
             conn.Open();
             SqlCommand cmd = new SqlCommand("delete_diemthi", conn);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 50).Value = p_masv;
             cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mamon;
             cmd.ExecuteNonQuery();
             load_gridview();
             cmd.Dispose();
             conn.Close();

         }

         private void btnXoa_Click(object sender, EventArgs e)
         {
             string p_masv = dgvDiemThi.CurrentRow.Cells["MaSV"].Value.ToString();
             string p_mamon = dgvDiemThi.CurrentRow.Cells["MaMon"].Value.ToString();
             xoa_diemthi(p_masv, p_mamon);
             MessageBox.Show("Xóa dữ liệu thành công");
         }*/
    
    
}

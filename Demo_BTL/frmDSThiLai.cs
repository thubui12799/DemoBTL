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
    public partial class frmDSThiLai : Form
    {
        String connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=DiemSV;Integrated Security=True";
        public frmDSThiLai()
        {
            InitializeComponent();
            load_lop();
            load_Mon();
        }

        private void load_lop()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from LOP ", conn);
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
        private void load_Mon()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from MON_HOC", conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["MaMon"] = "--------------";
            dr["TenMon"] = "--Chọn--";
            dt.Rows.InsertAt(dr, 0);
            cbbMon.DataSource = dt;
            cbbMon.DisplayMember = "TenMon";
            cbbMon.ValueMember = "MaMon";
            conn.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DiemHocphan_CHUADAT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = cbbLop.SelectedValue.ToString();
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = cbbMon.SelectedValue.ToString();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            conn.Close();

        }
    }
}

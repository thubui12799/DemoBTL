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
    public partial class frmDiemDetail : Form
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLD_Nhom3;Integrated Security=True";
        public frmDiemDetail()
        {
            InitializeComponent();
           // load_gridview();
            load_mon();
        }
        private void load_gridview()
        {
           

        }
        private void load_diemTK()
        {
            

        }
        private void load_mon()
        {
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd2 = new SqlCommand("Select * from MON_HOC ", conn);
            conn.Open();
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
        private void frmDiemDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string p_mon = cbbMon.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("hienthi_diemTK", conn);
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = p_mon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDiemdetail.DataSource = dt;
        }
    }
}

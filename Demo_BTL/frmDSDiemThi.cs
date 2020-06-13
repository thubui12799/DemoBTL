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
    public partial class frmDSDiemThi : Form
    {
        private string _lop;
        private string _mon;
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=DiemSV;Integrated Security=True";
        public frmDSDiemThi()
        {
            InitializeComponent();
            load_gridview();
        }
        public frmDSDiemThi(string p_lop, string p_mon) : this()
        {
           _lop = p_lop;
            txtLop.Text = _lop;
            _mon = p_mon;
            txtMon.Text = _mon;
        }
        private void load_gridview()
        {
            
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("hienthi_DSChuaCoDiem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 50).Value = _lop;
            cmd.Parameters.Add("@MaMon", SqlDbType.NVarChar, 50).Value = _mon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvDSDiemThi.DataSource = dt;

        }
    }
}

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
    public partial class DS_DIEM : Form
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLD_Nhom3;Integrated Security=True";
        public DS_DIEM()
        {
            InitializeComponent();
        }
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DiemDetail crp = new DiemDetail();
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DS_diem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            crp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crp;
        }
        
    }
}

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
    public partial class frmDSdiem : Form
    {
        string connect = @"Data Source=THANHTHU\SQLEXPRESS;Initial Catalog=QLD_Nhom3;Integrated Security=True";
        public frmDSdiem()
        {
            InitializeComponent();
        }

        private void crvDSdiem_Load(object sender, EventArgs e)
        {
            //CrystalReport_DSdiem crp = new CrystalReport_DSdiem();
            //SqlConnection conn = new SqlConnection(connect);
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("DS_diem", conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //crp.SetDataSource(dt);
            //crvDSdiem.ReportSource = crp;
        }
    }
}

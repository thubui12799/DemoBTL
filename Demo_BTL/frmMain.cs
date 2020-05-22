using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_BTL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private int childFormNumber = 0;
        public static bool kt1, kt2;

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau f = new frmDoimatkhau();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void quảnLíNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = frmMain.ActiveForm;
            foreach (Form form in f.MdiChildren)
            {
                if (f.Name == "frmQuanLinguoidung")
                {
                    f.Activate();
                    return;
                }
            }
            frmQuanlinguoidung frmND = new frmQuanlinguoidung();
            frmND.MdiParent = this;
            frmND.Show();
            frmND.Top = 0;
            frmND.Left = 0;
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmMonhoc")
                {
                    f.Activate();
                    return;
                }
            }
            frmMonhoc fMonhoc = new frmMonhoc();
            fMonhoc.MdiParent = this;
            fMonhoc.Show();
            fMonhoc.Top = 0;
            fMonhoc.Left = 0;
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLK = new frmKhoa();
            frmQLK.MdiParent = this;
            frmQLK.Show();
            frmQLK.Top = 0;
            frmQLK.Left = 0;
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmLop")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLL = new frmLop();
            frmQLL.MdiParent = this;
            frmQLL.Show();
            frmQLL.Top = 0;
            frmQLL.Left = 0;
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLSV")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLSV = new frmQLSV();
            frmQLSV.MdiParent = this;
            frmQLSV.Show();
            frmQLSV.Top = 0;
            frmQLSV.Left = 0;
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmGiangVien")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLGV = new frmGiangVien();
            frmQLGV.MdiParent = this;
            frmQLGV.Show();
            frmQLGV.Top = 0;
            frmQLGV.Left = 0;
        }

        private void điểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLDiem")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLD = new frmQLDiem();
            frmQLD.MdiParent = this;
            frmQLD.Show();
            frmQLD.Top = 0;
            frmQLD.Left = 0;
        }

        private void thiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmDiemThiLai")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmDTL = new frmDiemThiLai();
            frmDTL.MdiParent = this;
            frmDTL.Show();
            frmDTL.Top = 0;
            frmDTL.Left = 0;
        }

        private void danhSáchSVThiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmDSThiLai")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmDSTL = new frmDSThiLai();
            frmDSTL.MdiParent = this;
            frmDSTL.Show();
            frmDSTL.Top = 0;
            frmDSTL.Left = 0;
        }

        private void họcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmDSHocLai")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmHL = new frmDSHocLai();
            frmHL.MdiParent = this;
            frmHL.Show();
            frmHL.Top = 0;
            frmHL.Left = 0;
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLSV")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLSV = new frmQLSV();
            frmQLSV.MdiParent = this;
            frmQLSV.Show();
            frmQLSV.Top = 0;
            frmQLSV.Left = 0;
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmGiangVien")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLGV = new frmGiangVien();
            frmQLGV.MdiParent = this;
            frmQLGV.Show();
            frmQLGV.Top = 0;
            frmQLGV.Left = 0;
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmQLDiem")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLD = new frmQLDiem();
            frmQLD.MdiParent = this;
            frmQLD.Show();
            frmQLD.Top = 0;
            frmQLD.Left = 0;
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLK = new frmKhoa();
            frmQLK.MdiParent = this;
            frmQLK.Show();
            frmQLK.Top = 0;
            frmQLK.Left = 0;
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmLop")
                {
                    f.Activate();
                    return;
                }
            }
            Form frmQLL = new frmLop();
            frmQLL.MdiParent = this;
            frmQLL.Show();
            frmQLL.Top = 0;
            frmQLL.Left = 0;
        }

        private void btnQLMon_Click(object sender, EventArgs e)
        {
            Form frm = frmMain.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "frmMonhoc")
                {
                    f.Activate();
                    return;
                }
            }
            frmMonhoc fMonhoc = new frmMonhoc();
            fMonhoc.MdiParent = this;
            fMonhoc.Show();
            fMonhoc.Top = 0;
            fMonhoc.Left = 0;
        }

        

        private void menuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = menuBarToolStripMenuItem.Checked;
           
            btnQLDiem.Visible = menuBarToolStripMenuItem.Checked;
            btnQLGV.Visible = menuBarToolStripMenuItem.Checked;
            btnQLKhoa.Visible = menuBarToolStripMenuItem.Checked;
            btnQLLop.Visible = menuBarToolStripMenuItem.Checked;
            btnQLMon.Visible = menuBarToolStripMenuItem.Checked;
            btnQLSV.Visible = menuBarToolStripMenuItem.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

    }
}

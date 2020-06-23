using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChuongTrinhQuanLyTrungTamTinHoc : MetroFramework.Forms.MetroForm
    {
        public frmChuongTrinhQuanLyTrungTamTinHoc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // Tọa độ x của góc trên bên trái
           int nTopRect,      // Tọa độ y của góc trên bên trái
           int nRightRect,    // Tọa độ x của góc dưới bên phải
           int nBottomRect,   // Tọa độ y của góc dưới bên phải
           int nWidthEllipse, // Chiều Cao ellipse
           int nHeightEllipse // Chiều Rộng ellipse
        );

        private void pnlKhoaHoc_MouseEnter(object sender, EventArgs e)
        {
            pnlKhoaHoc.BackColor = Color.PowderBlue;
        }

        private void pnlKhoaHoc_MouseLeave(object sender, EventArgs e)
        {
            pnlKhoaHoc.BackColor = Color.White;
        }

        private void pnlPhongHoc_MouseEnter(object sender, EventArgs e)
        {
            pnlPhongHoc.BackColor = Color.PowderBlue;
        }

        private void pnlPhongHoc_MouseLeave(object sender, EventArgs e)
        {
            pnlPhongHoc.BackColor = Color.White;
        }

        private void pnlGiangVien_MouseEnter(object sender, EventArgs e)
        {
            pnlGiangVien.BackColor = Color.PowderBlue;
        }

        private void pnlGiangVien_MouseLeave(object sender, EventArgs e)
        {
            pnlGiangVien.BackColor = Color.White;
        }

        private void pnlCongNo_MouseEnter(object sender, EventArgs e)
        {
            pnlCongNo.BackColor = Color.PowderBlue;
        }

        private void pnlCongNo_MouseLeave(object sender, EventArgs e)
        {
            pnlCongNo.BackColor = Color.White;
        }

        private void pnlBaoLuu_MouseEnter(object sender, EventArgs e)
        {
            pnlBaoLuu.BackColor = Color.PowderBlue;
        }

        private void pnlBaoLuu_MouseLeave(object sender, EventArgs e)
        {
            pnlBaoLuu.BackColor = Color.White;
        }

        private void pnlHocVien_MouseEnter(object sender, EventArgs e)
        {
            pnlHocVien.BackColor = Color.PowderBlue;
        }

        private void pnlHocVien_MouseLeave(object sender, EventArgs e)
        {
            pnlHocVien.BackColor = Color.White;
        }

        private void pnlKhoaHoc_Click(object sender, EventArgs e)
        {
            frmKhoaHoc fkh = new frmKhoaHoc();
            fkh.ShowDialog();
        }

        private void pnlPhongHoc_Click(object sender, EventArgs e)
        {
            frmPhongHoc fph = new frmPhongHoc();
            fph.ShowDialog();
        }

        private void pnlGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien fgv = new frmGiangVien();
            fgv.ShowDialog();
        }

        private void pnlCongNo_Click(object sender, EventArgs e)
        {
            frmCongNo fcn = new frmCongNo();
            fcn.ShowDialog();
        }

        private void pnlBaoLuu_Click(object sender, EventArgs e)
        {
            frmBaoLuu fbl = new frmBaoLuu();
            fbl.ShowDialog();
        }

        private void pnlHocVien_Click(object sender, EventArgs e)
        {
            frmHocVien fhv = new frmHocVien();
            fhv.ShowDialog();
        }

        public int btnWasClicked = 0;

        private void btnRptKH_Click(object sender, EventArgs e)
        {
            btnWasClicked = 1;
            frmKH_PH_GV_Report frmpt = new frmKH_PH_GV_Report();
            frmpt.ShowDialog(this);
        }

        private void btnRptPH_Click(object sender, EventArgs e)
        {
            btnWasClicked = 2;
            frmKH_PH_GV_Report frmpt = new frmKH_PH_GV_Report();
            frmpt.ShowDialog(this);
        }

        private void btnRptGV_Click(object sender, EventArgs e)
        {
            btnWasClicked = 3;
            frmKH_PH_GV_Report frmpt = new frmKH_PH_GV_Report();
            frmpt.ShowDialog(this);
        }

        private void btnRptCN_Click(object sender, EventArgs e)
        {
            frm_rptCongNo frmcn = new frm_rptCongNo();
            frmcn.ShowDialog(this);
        }

        private void btnRptBL_Click(object sender, EventArgs e)
        {
            frm_rptBaoLuu frmbl = new frm_rptBaoLuu();
            frmbl.ShowDialog(this);
        }

        private void btnRptHV_Click(object sender, EventArgs e)
        {
            frm_rptHocVien frmhv = new frm_rptHocVien();
            frmhv.ShowDialog(this);
        }

        private void btnRptKH_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.PowderBlue;
        }

        private void btnRptKH_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
        }

        private void btnRptLH_Click(object sender, EventArgs e)
        {
            frmReport frmlh = new frmReport();
            frmlh.ShowDialog(this);
        }

        private void pnlLopHoc_MouseEnter(object sender, EventArgs e)
        {
            pnlBaoLuu.BackColor = Color.PowderBlue;
        }

        private void pnlLopHoc_MouseLeave(object sender, EventArgs e)
        {
            pnlHocVien.BackColor = Color.White;
        }

        private void pnlLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc flh = new frmLopHoc();
            flh.ShowDialog();
        }
    }
}
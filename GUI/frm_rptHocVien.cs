using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_rptHocVien : Form
    {
        public frm_rptHocVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                Close();
        }

        private void frm_rptHocVien_Load(object sender, EventArgs e)
        {
            rptHocVien rpt = new rptHocVien();
            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
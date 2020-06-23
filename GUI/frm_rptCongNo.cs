using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_rptCongNo : Form
    {
        public frm_rptCongNo()
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

        private void frm_rptCongNo_Load(object sender, EventArgs e)
        {
            rptCongNo rpt = new rptCongNo();
            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
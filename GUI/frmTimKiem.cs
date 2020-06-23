using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private KhoaHoc kh = new KhoaHoc();

        private PhongHoc ph = new PhongHoc();

        private GiangVien gv = new GiangVien();

        private UtilitiesBLL xuly = new UtilitiesBLL();

        private void pictureExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn thực sự muốn thoát khỏi phần tìm kiếm?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            if (this.Owner is frmKhoaHoc)
                lblTimKiem.Text = "Khóa học cần tìm";
            if (this.Owner is frmPhongHoc)
                lblTimKiem.Text = "Phòng học cần tìm";
            if (this.Owner is frmGiangVien)
                lblTimKiem.Text = "Giảng viên cần tìm";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.Owner is frmKhoaHoc)
            {
                List<KhoaHoc> dskh = xuly.timkiemKhoaHoc(txtTimKiem.Text.Trim());
                Form fkh = Application.OpenForms["frmKhoaHoc"];
                ((frmKhoaHoc)fkh).dgvKhoaHoc.DataSource = dskh;
                this.Close();
            }
            else if (this.Owner is frmPhongHoc)
            {
                List<PhongHoc> dsph = xuly.timkiemPhongHoc(txtTimKiem.Text.Trim());
                Form fph = Application.OpenForms["frmPhongHoc"];
                ((frmPhongHoc)fph).dgvPhongHoc.DataSource = dsph;
                this.Close();
            }
            else if (this.Owner is frmGiangVien)
            {
                List<GiangVien> dsgv = xuly.timkiemGiangVien(txtTimKiem.Text.Trim());
                Form fgv = Application.OpenForms["frmGiangVien"];
                ((frmGiangVien)fgv).dgvGiangVien.DataSource = dsgv;
                this.Close();
            }
        }
    }
}
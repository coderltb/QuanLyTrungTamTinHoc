using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhoaHoc : Form
    {
        public frmKhoaHoc()
        {
            InitializeComponent();
        }

        private void frmKhoaHoc_Load(object sender, EventArgs e)
        {
            HienThiLenDataGridView();
            loadComboBoxTenKH();
            loadComboBoxThoiLuong();
            loadComboBoxSLHVToiDa();
            loadComboBoxSLHVToiThieu();
            gbThemKhoaHoc.Enabled = false;
        }

        private KhoaHoc kh = new KhoaHoc();

        private UtilitiesBLL xuly = new UtilitiesBLL();

        private void HienThiLenDataGridView()
        {
            dgvKhoaHoc.DataSource = xuly.LayToanBoKhoaHoc();
        }

        private void loadComboBoxTenKH()
        {
            List<KhoaHoc> dskh = xuly.LayToanBoKhoaHoc();
            KhoaHoc item = new KhoaHoc();
            item.maKH = 0;
            item.tenKH = "Tất cả khóa học";
            dskh.Insert(0, item);
            cboTenKH.DataSource = dskh;
            cboTenKH.DisplayMember = "TenKH";
            cboTenKH.ValueMember = "MaKH";
        }

        private void loadComboBoxThoiLuong()
        {
            int[] dulieuChoThoiLuong = { 30, 40 };
            cboThoiLuong.DataSource = dulieuChoThoiLuong;
        }

        private void loadComboBoxThemThoiLuong()
        {
            int[] dulieuChoThoiLuong = { 30, 40 };
            cboThemTL.DataSource = dulieuChoThoiLuong;
        }

        private void loadComboBoxSLHVToiDa()
        {
            int[] dulieuChoSLHVToiDa = { 30, 40 };
            cboSLHVToiDa.DataSource = dulieuChoSLHVToiDa;
        }

        private void loadComboBoxThemSLHVTD()
        {
            int[] dulieuChoSLHVToiDa = { 30, 40 };
            cboThemSLHVTD.DataSource = dulieuChoSLHVToiDa;
        }

        private void loadComboBoxSLHVToiThieu()
        {
            int[] dulieuChoSLHVToiThieu = { 10, 15 };
            cboSLHVToiThieu.DataSource = dulieuChoSLHVToiThieu;
        }

        private void loadComboBoxThemSLHVTT()
        {
            int[] dulieuChoSLHVToiThieu = { 10, 15 };
            cboThemSLHVTT.DataSource = dulieuChoSLHVToiThieu;
        }

        private void XoaThongTin()
        {
            cboTenKH.SelectedIndex = 0;
            cboSLHVToiDa.SelectedIndex = 0;
            cboSLHVToiThieu.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (gbThemKhoaHoc.Enabled == false)
            {
                MessageBox.Show("Bạn phải nhấn vào nút khóa học mới và điền đầy đủ thông tin cho khóa học mới này!");
                return;
            }
            if (string.IsNullOrEmpty(txtThemKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tiến hành thêm khóa học!");
                return;
            }
            kh.tenKH = txtThemKH.Text.Trim();
            kh.soLuongHVTD = int.Parse(cboThemSLHVTD.Text.Trim());
            kh.thoiLuong = int.Parse(cboThemTL.Text.Trim());
            kh.soLuongHVTT = int.Parse(cboThemSLHVTT.Text.Trim());

            List<KhoaHoc> dskh = xuly.LayToanBoKhoaHoc();

            foreach (KhoaHoc item in dskh)
            {
                if (item.tenKH.Equals(kh.tenKH))
                {
                    MessageBox.Show("Khóa học này đã tồn tại!");
                    return;
                }
            }

            bool kq = xuly.themKhoaHoc(kh);
            if (kq == true)
            {
                MessageBox.Show("Thêm thành công!");
                HienThiLenDataGridView();
                loadComboBoxTenKH();
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được.");
            }
            XoaThongTin();
            btnThemKhoaHocMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboTenKH.Text.Trim().Equals("Tất cả khóa học"))
            {
                MessageBox.Show("Vui lòng chọn một khóa học cụ thể để tiến hành xóa!");
                return;
            }
            kh.maKH = int.Parse(cboTenKH.SelectedValue.ToString());
            bool kq = xuly.xoaKhoaHoc(kh.maKH.ToString());
            if (kq == true)
            {
                MessageBox.Show("Xóa thành công!");
                loadComboBoxTenKH();
                HienThiLenDataGridView();
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được.");
            }
            XoaThongTin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboTenKH.Text.Trim().Equals("Tất cả khóa học"))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tiến hành cập nhật!");
                return;
            }

            kh.maKH = int.Parse(cboTenKH.SelectedValue.ToString());
            kh.tenKH = cboTenKH.Text.Trim();
            kh.soLuongHVTD = int.Parse(cboSLHVToiDa.Text.Trim());
            kh.thoiLuong = int.Parse(cboThoiLuong.Text.Trim());
            kh.soLuongHVTT = int.Parse(cboSLHVToiThieu.Text.Trim());

            bool kq = xuly.capnhatKhoaHoc(kh);

            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiLenDataGridView();
            }
            else
            {
                MessageBox.Show("Lỗi! Không cập nhật được.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem ftk = new frmTimKiem();
            ftk.ShowDialog(this);
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                Close();
        }

        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhoaHoc.Rows.Count > 0)
            {
                int vtHienTai = e.RowIndex;
                string makh = dgvKhoaHoc.Rows[vtHienTai].Cells[0].Value + "";
                string tenkh = dgvKhoaHoc.Rows[vtHienTai].Cells[1].Value + "";
                string soluongHVTD = dgvKhoaHoc.Rows[vtHienTai].Cells[2].Value + "";
                string thoiluong = dgvKhoaHoc.Rows[vtHienTai].Cells[3].Value + "";
                string soluongHVTT = dgvKhoaHoc.Rows[vtHienTai].Cells[4].Value + "";

                cboTenKH.Text = tenkh;
                cboSLHVToiDa.Text = soluongHVTD;
                cboThoiLuong.Text = thoiluong;
                cboSLHVToiThieu.Text = soluongHVTT;
            }
        }

        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKH.Text.Trim().Equals("Tất cả khóa học"))
            {
                HienThiLenDataGridView();
            }
            else
            {
                List<KhoaHoc> kh = xuly.timkiemKhoaHoc(cboTenKH.Text.Trim());
                dgvKhoaHoc.DataSource = kh;
            }
        }

        private void VoHieuHoa()
        {
            cboTenKH.Enabled = false;
            cboThoiLuong.Enabled = false;
            cboSLHVToiDa.Enabled = false;
            cboSLHVToiThieu.Enabled = false;
        }

        private void KickHoat()
        {
            cboTenKH.Enabled = true;
            cboThoiLuong.Enabled = true;
            cboSLHVToiDa.Enabled = true;
            cboSLHVToiThieu.Enabled = true;
        }

        private void btnThemKhoaHocMoi_Click(object sender, EventArgs e)
        {
            if (btnThemKhoaHocMoi.Text.Trim().Equals("Khóa học mới"))
            {
                btnThemKhoaHocMoi.Text = "Hủy";
                VoHieuHoa();
                gbThemKhoaHoc.Enabled = true;
                loadComboBoxThemThoiLuong();
                loadComboBoxThemSLHVTD();
                loadComboBoxThemSLHVTT();
            }
            else
            {
                btnThemKhoaHocMoi.Text = "Khóa học mới";
                txtThemKH.ResetText();
                cboThemTL.SelectedIndex = 0;
                cboThemSLHVTD.SelectedIndex = 0;
                cboThemSLHVTT.SelectedIndex = 0;
                gbThemKhoaHoc.Enabled = false;
                KickHoat();
            }
        }
    }
}
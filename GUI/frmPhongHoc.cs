using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhongHoc : Form
    {
        public frmPhongHoc()
        {
            InitializeComponent();
        }

        private PhongHoc ph = new PhongHoc();

        private UtilitiesBLL xuly = new UtilitiesBLL();

        private void hienthiDataGridView()
        {
            dgvPhongHoc.DataSource = xuly.LayToanBoPhongHoc();
        }

        private void frmPhongHoc_Load(object sender, EventArgs e)
        {
            hienthiDataGridView();
            loadComboBoxTenPH();
            loadComboBoxSoluong();
            gbThemPhongHoc.Enabled = false;
        }

        private void loadComboBoxTenPH()
        {
            List<PhongHoc> dsph = xuly.LayToanBoPhongHoc();
            PhongHoc item = new PhongHoc();
            item.maPH = 0;
            item.tenPG = "Tất cả phòng";
            dsph.Insert(0, item);
            cboTenPH.DataSource = dsph;
            cboTenPH.ValueMember = "MaPH";
            cboTenPH.DisplayMember = "tenPG";
        }

        private void loadComboBoxSoluong()
        {
            int[] quymoLopHoc = { 40, 50 };
            cboSoLuong.DataSource = quymoLopHoc;
        }

        private void loadComboBoxThemSL()
        {
            int[] quymoLopHoc = { 40, 50 };
            cboThemSL.DataSource = quymoLopHoc;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (gbThemPhongHoc.Enabled == false)
            {
                MessageBox.Show("Bạn phải nhấn vào nút phòng học mới và điền đầy đủ thông tin cho phòng học mới này!");
                return;
            }
            if (string.IsNullOrEmpty(txtThemPH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để thêm phòng mới");
                return;
            }
            ph.tenPG = txtThemPH.Text.Trim();
            ph.soLuong = int.Parse(cboThemSL.Text.Trim());

            List<PhongHoc> dsph = xuly.LayToanBoPhongHoc();

            foreach (PhongHoc item in dsph)
            {
                if (item.tenPG.Equals(ph.tenPG))
                {
                    MessageBox.Show("Phòng học này đã tồn tại!");
                    return;
                }
            }

            bool kq = xuly.themPhongHoc(ph);
            if (kq == true)
            {
                MessageBox.Show("Thêm thành công!");
                hienthiDataGridView();
                loadComboBoxTenPH();
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được.");
            }
            btnThemPhongHocMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ph.maPH = int.Parse(cboTenPH.SelectedValue.ToString());

            bool kq = xuly.xoaPhongHoc(ph.maPH.ToString());

            if (kq == true)
            {
                MessageBox.Show("Xóa thành công!");
                hienthiDataGridView();
                loadComboBoxTenPH();
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ph.maPH = int.Parse(cboTenPH.SelectedValue.ToString());
            ph.tenPG = cboTenPH.Text.Trim();
            ph.soLuong = int.Parse(cboSoLuong.Text.Trim());

            bool kq = xuly.capnhatPhongHoc(ph);
            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                hienthiDataGridView();
            }
            else
            {
                MessageBox.Show("Lỗi! Không cập nhật được.");
            }
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhongHoc.Rows.Count > 0)
            {
                int vtHienTai = e.RowIndex;
                string maph = dgvPhongHoc.Rows[vtHienTai].Cells[0].Value + "";
                string tenph = dgvPhongHoc.Rows[vtHienTai].Cells[1].Value + "";
                string soluong = dgvPhongHoc.Rows[vtHienTai].Cells[2].Value + "";

                cboTenPH.Text = tenph;
                cboSoLuong.Text = soluong;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem ftk = new frmTimKiem();
            ftk.ShowDialog();
        }

        private void cboTenPH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenPH.Text.Trim().Equals("Tất cả phòng"))
            {
                hienthiDataGridView();
            }
            else
            {
                List<PhongHoc> ph = xuly.timkiemPhongHoc(cboTenPH.Text.Trim());
                dgvPhongHoc.DataSource = ph;
            }
        }

        private void VoHieuHoa()
        {
            cboTenPH.Enabled = false;
            cboSoLuong.Enabled = false;
        }

        private void KickHoat()
        {
            cboTenPH.Enabled = true;
            cboSoLuong.Enabled = true;
        }

        private void btnPhongHocMoi_Click(object sender, EventArgs e)
        {
            if (btnThemPhongHocMoi.Text.Trim().Equals("Phòng học mới"))
            {
                btnThemPhongHocMoi.Text = "Hủy";
                VoHieuHoa();
                gbThemPhongHoc.Enabled = true;
                loadComboBoxThemSL();
            }
            else
            {
                btnThemPhongHocMoi.Text = "Phòng học mới";
                txtThemPH.ResetText();
                gbThemPhongHoc.Enabled = false;
                KickHoat();
            }
        }
    }
}
using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private GiangVien gv = new GiangVien();

        private UtilitiesBLL xuly = new UtilitiesBLL();

        private void hienthiDataGridView()
        {
            dgvGiangVien.DataSource = xuly.HienThiTatCaGiangVien();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            hienthiDataGridView();
            loadComboBoxTenGV();
            loadComboBoxTrinhDo();
            gbThemGiangVien.Enabled = false;
        }

        private void loadComboBoxTenGV()
        {
            List<GiangVien> dsgv = xuly.HienThiTatCaGiangVien();
            GiangVien item = new GiangVien();
            item.maGV = 0;
            item.tenGV = "Tất cả giảng viên";
            dsgv.Insert(0, item);

            cboTenGV.DataSource = dsgv;
            cboTenGV.ValueMember = "MaGV";
            cboTenGV.DisplayMember = "TenGV";
        }

        private void loadComboBoxTrinhDo()
        {
            string[] dulieuTrinhDo = { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "Phó giáo sư", "Giáo sư" };
            cboTrinhDo.DataSource = dulieuTrinhDo;
        }

        private void loadComboBoxThemTrinhDo()
        {
            string[] dulieuTrinhDo = { "Cử nhân", "Thạc sĩ", "Tiến sĩ", "Phó giáo sư", "Giáo sư" };
            cboThemTrinhDo.DataSource = dulieuTrinhDo;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtiNamSinh.Text.Trim()) || string.IsNullOrEmpty(txtThemTenGV.Text.Trim())
                || string.IsNullOrEmpty(txtThemDiaChi.Text.Trim()) || string.IsNullOrEmpty(txtThemMaGV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tiến hành thêm giảng viên!");
                return;
            }

            gv.maGV = int.Parse(txtThemMaGV.Text.Trim());
            gv.tenGV = txtThemTenGV.Text.Trim();
            try
            {
                DateTime kiemthu = DateTime.ParseExact(dtiNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Định dạng ngày tháng không hợp lệ!");
                return;
            }
            gv.namSinh = DateTime.ParseExact(dtiNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            gv.diaChi = txtThemDiaChi.Text.Trim();
            gv.sDT = txtThemSDT.Text.Trim();
            gv.trinhDo = cboThemTrinhDo.Text.Trim();

            List<GiangVien> dsgv = xuly.HienThiTatCaGiangVien();
            foreach (GiangVien item in dsgv)
            {
                if (item.maGV.Equals(gv.maGV))
                {
                    MessageBox.Show("Giáo viên này đã tồn tại!");
                    return;
                }
            }

            bool kq = xuly.themGiangVien(gv);

            if (kq == true)
            {
                MessageBox.Show("Thêm thành công!");
                hienthiDataGridView();
                loadComboBoxTenGV();
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được");
            }
            btnThemGiangVienMoi.PerformClick();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gv.maGV = int.Parse(cboTenGV.SelectedValue.ToString());
            bool kq = xuly.xoaGiangVien(gv.maGV.ToString());

            if (kq == true)
            {
                MessageBox.Show("Xóa thành công!");
                hienthiDataGridView();
                loadComboBoxTenGV();
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamSinh.Text.Trim()) || string.IsNullOrEmpty(txtDiaChi.Text.Trim()) || string.IsNullOrEmpty(txtDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tiến hành cập nhật!");
                return;
            }
            gv.maGV = int.Parse(cboTenGV.SelectedValue.ToString());
            try
            {
                DateTime kiemthu = DateTime.ParseExact(txtNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Định dạng ngày tháng không hợp lệ!");
                return;
            }
            gv.namSinh = DateTime.ParseExact(txtNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            gv.diaChi = txtDiaChi.Text.Trim();
            gv.sDT = txtDienThoai.Text.Trim();
            gv.trinhDo = cboTrinhDo.Text.Trim();

            bool kq = xuly.capnhatGiangVien(gv);

            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công!");
                hienthiDataGridView();
            }
            else
            {
                MessageBox.Show("Lỗi! Không cập nhật được");
            }
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGiangVien.Rows.Count > 0)
            {
                int vtHienTai = e.RowIndex;
                string magv = dgvGiangVien.Rows[vtHienTai].Cells[0].Value + "";
                string tengv = dgvGiangVien.Rows[vtHienTai].Cells[1].Value + "";
                DateTime namsinh = (DateTime)dgvGiangVien.Rows[vtHienTai].Cells[2].Value;
                string diachi = dgvGiangVien.Rows[vtHienTai].Cells[3].Value + "";
                string sdt = dgvGiangVien.Rows[vtHienTai].Cells[4].Value + "";
                string trinhdo = dgvGiangVien.Rows[vtHienTai].Cells[5].Value + "";

                cboTenGV.Text = tengv;
                txtNamSinh.Text = namsinh.ToString();
                txtDiaChi.Text = diachi;
                txtDienThoai.Text = sdt;
                cboTrinhDo.Text = trinhdo;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem ftk = new frmTimKiem();
            ftk.ShowDialog();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void cboTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenGV.Text.Trim().Equals("Tất cả giảng viên"))
            {
                hienthiDataGridView();
            }
            else
            {
                List<GiangVien> gv = xuly.timkiemGiangVien(cboTenGV.Text.Trim());
                dgvGiangVien.DataSource = gv;
            }
        }

        private void VoHieuHoa()
        {
            cboTenGV.Enabled = false;
            cboTrinhDo.Enabled = false;
            txtNamSinh.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;
        }

        private void KickHoat()
        {
            cboTenGV.Enabled = true;
            cboTrinhDo.Enabled = true;
            txtNamSinh.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnThemGiangVienMoi_Click(object sender, EventArgs e)
        {
            if (btnThemGiangVienMoi.Text.Trim().Equals("Giảng viên mới"))
            {
                btnThemGiangVienMoi.Text = "Hủy";
                VoHieuHoa();
                gbThemGiangVien.Enabled = true;
                loadComboBoxThemTrinhDo();
            }
            else
            {
                btnThemGiangVienMoi.Text = "Giảng viên mới";
                txtThemMaGV.ResetText();
                txtThemDiaChi.ResetText();
                txtThemSDT.ResetText();
                txtThemTenGV.ResetText();
                gbThemGiangVien.Enabled = false;
                KickHoat();
            }
        }
    }
}
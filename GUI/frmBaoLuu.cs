using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaoLuu : Form
    {
        // Cái vụ Reload combobox Mã Học viên khi chọn item trong Combobox Mã lớp t làm đang bị lỗi
        public frmBaoLuu()
        {
            InitializeComponent();
        }

        private List<LopHoc> dslh = new List<LopHoc>();

        private List<BaoLuu> dsbl = new List<BaoLuu>();

        private List<HocVien> dshv = new List<HocVien>();

        private UtilitiesBLL logic = new UtilitiesBLL();

        public void loadCboxMaLop()  //Chỉ sửa trong đây thôi,đừng động vào hàm khác
        {
            dslh = logic.layToanBoLopHoc();
            LopHoc lh = new LopHoc();
            lh.maLH = 00;
            lh.khoaHoc.tenKH = "Tất cả"; //Ở đây
            dslh.Insert(0, lh);
            cboxMaLopHoc.DataSource = dslh;
            cboxMaLopHoc.DisplayMember = "TENKH"; // Ở đây
            cboxMaLopHoc.ValueMember = "MALH";
        }

        public bool kiemTraNhapLieu()
        {
            foreach (Control c in pnlData.Controls)
            {
                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(MaskedTextBox) || c.GetType() == typeof(ComboBox))
                {
                    if (string.IsNullOrEmpty(c.Text.Trim()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void loadCboxMaHV()
        {
            cboxMaHocVien.DataSource = dshv;
            cboxMaHocVien.DisplayMember = "TENHV";
            cboxMaHocVien.ValueMember = "MAHV";
        }

        public void loadCboxMaBL()
        {
            dsbl = logic.HienThiTatCaBaoLuu();
            cboxMaBL.DataSource = dsbl;
            cboxMaBL.DisplayMember = "MABL";
            cboxMaBL.ValueMember = "MABL";
        }

        public void loadGridvBaoLuuTatCaLop()
        {
            dsbl = logic.HienThiTatCaBaoLuu();
            gridvBaoLuu.DataSource = dsbl;
        }

        public void loadGridvBaoLuuTheoLop(string malop)
        {
            dsbl = logic.HienThiTatCaBaoLuuTheoLop(malop);
            gridvBaoLuu.DataSource = dsbl;
        }

        public void linkData(string malop)
        {
            if (cboxMaLopHoc.SelectedIndex == 0)
            {
                dshv = logic.HienThiTatCaHocVien();
                loadCboxMaHV();
                loadGridvBaoLuuTatCaLop();
            }
            else
            {
                dshv = logic.HienThiTatCaHocVienTheoLop(malop);
                loadCboxMaHV();
                loadGridvBaoLuuTheoLop(malop);
            }
        }

        private void pictureExixt_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                Close();
        }

        private void frmBaoLuu_Load(object sender, EventArgs e)
        {
            loadCboxMaLop();
            loadCboxMaBL();
            gridvBaoLuu.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxMaLopHoc.SelectedIndex == 0)
                {
                    MessageBox.Show("Bạn đang chọn tất cả lớp,hãy chọn giá trị khác !");
                    return;
                }
                if (!kiemTraNhapLieu())
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin");
                    return;
                }
                BaoLuu bl = new BaoLuu();
                bl.maBL = int.Parse(cboxMaBL.Text.Trim());
                bl.maLH = int.Parse(cboxMaLopHoc.SelectedValue.ToString());
                bl.maHV = int.Parse(cboxMaHocVien.SelectedValue.ToString());
                bl.thoiGianBatDauBaoLuu = DateTime.Parse(DateTime.ParseExact(mtxtThoiGianBDBaoLuu.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                bl.thoiGianKetThucBaoLuu = DateTime.Parse(DateTime.ParseExact(mtxtThoiGianKTBaoLuu.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                bl.soTienBaoLuu = float.Parse(txtSoTienBL.Text.Trim());
                if (logic.capnhatBaoLuu(bl))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    string malop = cboxMaLopHoc.SelectedValue.ToString();
                    linkData(malop);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = new DialogResult();
                rs = MessageBox.Show("Bạn có muốn xoá", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.No)
                    return;
                if (logic.TimKiemBaoLuuTrongCongNo(cboxMaBL.Text.Trim()).Count != 0)
                {
                    MessageBox.Show("Bảo lưu này đang sử dụng trong Mục Công nợ, không thể xoá ");
                }
                else
                {
                    if (logic.xoaBaoLuu(cboxMaBL.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công !");
                        string malop = cboxMaLopHoc.SelectedValue.ToString();
                        if (malop != null) //////////////////////
                        {
                            linkData(malop);
                            loadCboxMaBL();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxMaLopHoc.SelectedIndex == 0)
                {
                    MessageBox.Show("Mã lớp 0 là tất cả lớp học,bạn vui lòng chọn mã lớp từ 1 trở lên !");
                    return;
                }
                if (!kiemTraNhapLieu())
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin");
                    return;
                }
                BaoLuu bl = new BaoLuu();
                bl.maLH = int.Parse(cboxMaLopHoc.SelectedValue.ToString()); ;
                bl.maHV = int.Parse(cboxMaHocVien.SelectedValue.ToString());
                bl.thoiGianBatDauBaoLuu = DateTime.Parse(DateTime.ParseExact(mtxtThoiGianBDBaoLuu.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                bl.thoiGianKetThucBaoLuu = DateTime.Parse(DateTime.ParseExact(mtxtThoiGianKTBaoLuu.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                bl.soTienBaoLuu = float.Parse(txtSoTienBL.Text.Trim());
                if (logic.themBaoLuu(bl))
                {
                    MessageBox.Show("Thêm thành công !");
                    string malop = cboxMaLopHoc.SelectedValue.ToString();
                    if (malop != null)  ////////////////////////////////
                    {
                        linkData(malop);
                        loadCboxMaBL();
                        cboxMaBL.SelectedIndex = cboxMaBL.Items.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra !");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mabl = cboxMaBL.SelectedValue.ToString();
            if (string.IsNullOrEmpty(mabl))
            {
                MessageBox.Show("Hãy chọn một mã bảo lưu !");
                return;
            }
            else
            {
                dsbl = logic.timkiemBaoLuu(mabl);
                gridvBaoLuu.DataSource = dsbl;
            }
        }

        private void cboxMaLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cboxMaLopHoc.SelectedValue.ToString();
            if (malop != null)
                linkData(malop);
        }

        private void txtSoTienBL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError((Control)sender, "Chỉ Cho Nhập Số");
            }
            else
                errorProvider1.Clear();
        }

        private void cboxMaHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahv = cboxMaHocVien.SelectedValue.ToString();
            if (mahv != null)
            {
                dsbl = logic.HienThiTatCaBaoLuuTheoMaHV(mahv);
                gridvBaoLuu.DataSource = dsbl;
            }
        }
    }
}
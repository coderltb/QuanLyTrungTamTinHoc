using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private List<HocVien> dshv = new List<HocVien>();

        private List<LopHoc> dslh = new List<LopHoc>();

        public void loadCboxMaLopHoc()  //Chỉ sửa ở đây ,những hàm khác không liên quan
        {
            dslh = logic.layToanBoLopHoc();
            LopHoc lh = new LopHoc();
            lh.maLH = 00;
            lh.khoaHoc.tenKH = "Tất cả";   // Display member // Edit ở đây
            dslh.Insert(0, lh);
            cboxMaLop.DataSource = dslh;
            cboxMaLop.DisplayMember = "khoaHoc.tenKH";   // Displaymember // Edit ở đây
            cboxMaLop.ValueMember = "MALH";
        }

        public void loadCboxMaHV()
        {
            //Phải set dshv trước rồi mới sử dụng hàm này
            //HocVien hv = new HocVien();
            //hv.maHV = 00;
            //dshv.Insert(0, hv);
            cboxMaHV.DataSource = dshv;
            cboxMaHV.DisplayMember = "MAHV";
            cboxMaHV.ValueMember = "MAHV";
        }

        public void loadCboxTinhTrang()
        {
            cboxTinhTrang.Items.Add("Đang học");
            cboxTinhTrang.Items.Add("Bảo lưu");
            cboxTinhTrang.SelectedIndex = 0;
        }

        public void clearData()
        {
            txtTenHV.ResetText();
            txtDiaChi.ResetText();
            txtNgheNgiep.ResetText();
            txtSDT.ResetText();
            cboxTinhTrang.ResetText();
            mtxtNamSinh.ResetText();
        }

        public bool kiemtraNhapLieu()
        {
            foreach (Control c in pnlHocVien.Controls)
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

        public void resetLstvThongTin()
        {
            foreach (ListViewItem i in lsvThongTin.Items)
            {
                i.Remove();
            }
        }

        public void loadLsvTatCaHocVien()
        {
            resetLstvThongTin();
            dshv = logic.HienThiTatCaHocVien();
            foreach (HocVien h in dshv)
            {
                ListViewItem i = new ListViewItem();
                i.Text = h.maHV.ToString();
                i.SubItems.Add(h.maLH.ToString());
                i.SubItems.Add(h.tenHV);
                i.SubItems.Add(h.namSinh.ToString());
                i.SubItems.Add(h.diaChi);
                i.SubItems.Add(h.ngheNghiep);
                i.SubItems.Add(h.tinhTrang);
                i.SubItems.Add(h.sDT);
                lsvThongTin.Items.Add(i);
            }
        }

        public void linkData(string malop)
        {
            if (cboxMaLop.SelectedIndex == 0)
            {
                dshv = logic.HienThiTatCaHocVien();
                loadCboxMaHV();
                loadLsvTatCaHocVien();
            }
            else
            {
                dshv = logic.HienThiTatCaHocVienTheoLop(malop);
                loadCboxMaHV();
                loadLsvThongTinTheoLop(malop);
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
                string mahv = cboxMaHV.Text.Trim();
                if (string.IsNullOrEmpty(mahv))
                {
                    MessageBox.Show("Phải chọn một Mã học viên");
                    return;
                }
                if (cboxMaHV.SelectedIndex == 0)
                {
                    MessageBox.Show("Mã học viên 0 có nghĩa là tất cả học viên,bạn vui lòng chọn mã học viên từ 1 trở lên !");
                    return;
                }

                if (logic.timkiemHocVienTrongBaoLuu(mahv).Count != 0)
                {
                    MessageBox.Show("Học viên này đang sử dụng trong Mục Bảo Lưu Học Viên, không thể xoá ");
                }
                else
                {
                    if (logic.xoaHocVien(cboxMaHV.Text.Trim()))
                    {
                        MessageBox.Show("Xoá thành công !");
                        clearData();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại !");
                    }
                }
                cboxMaLop.SelectedIndex = 0;
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
                if (!kiemtraNhapLieu())
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin");
                    return;
                }
                if (cboxMaLop.SelectedIndex == 0)
                {
                    MessageBox.Show("Không thể thêm học viên vào tất cả lớp,chỉ có thể chọn một lớp mà thôi !");
                    return;
                }
                HocVien hv = new HocVien();
                hv.maLH = int.Parse(cboxMaLop.SelectedValue.ToString());
                hv.tenHV = txtTenHV.Text.Trim();
                hv.namSinh = DateTime.Parse(DateTime.ParseExact(mtxtNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                hv.diaChi = txtDiaChi.Text.Trim();
                hv.ngheNghiep = txtNgheNgiep.Text.Trim();
                hv.tinhTrang = cboxTinhTrang.Text.Trim();
                hv.sDT = txtSDT.Text.Trim();
                if (logic.themHocVien(hv))
                {
                    MessageBox.Show("Thêm thành công !");
                    string malop = hv.maLH.ToString();
                    linkData(malop);
                    cboxMaHV.SelectedIndex = cboxMaHV.Items.Count - 1;
                    clearData();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxMaHV.SelectedIndex == 0)
                {
                    MessageBox.Show("Mã học viên 0 có nghĩa là tất cả học viên,bạn vui lòng chọn mã học viên từ 1 trở lên !");
                    return;
                }
                if (cboxMaLop.SelectedIndex == 0)
                {
                    MessageBox.Show("Chỉ chọn một lóp học  !");
                    return;
                }
                HocVien hv = new HocVien();
                hv.maHV = int.Parse(cboxMaHV.Text.Trim());
                hv.maLH = int.Parse(cboxMaLop.SelectedValue.ToString());
                hv.tenHV = txtTenHV.Text.Trim();
                hv.namSinh = DateTime.Parse(DateTime.ParseExact(mtxtNamSinh.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                hv.diaChi = txtDiaChi.Text.Trim();
                hv.ngheNghiep = txtNgheNgiep.Text.Trim();
                hv.tinhTrang = cboxTinhTrang.Text.Trim();
                hv.sDT = txtSDT.Text.Trim();
                if (logic.capnhatHocVien(hv))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    string malop = cboxMaLop.SelectedValue.ToString();
                    linkData(malop);
                    clearData();
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

        private void pictureExixt_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            resetLstvThongTin();

            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn tìm kiếm theo tên (Mặc định sẽ tìm kiếm theo ID) \n Bấm (Yes) để tìm kiếm theo tên, (No) để tìm kiếm Mặc định(ID)", "Tìm kiếm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
            {
                string mahv = cboxMaHV.Text.Trim();
                if (string.IsNullOrEmpty(mahv))
                {
                    MessageBox.Show("Mã học viên không được để trống \n Bạn hãy chọn một giá trị ");
                    return;
                }
                if (cboxMaHV.SelectedIndex == 0)
                {
                    MessageBox.Show("Mã học viên 0 có nghĩa là tất cả học viên,bạn vui lòng chọn mã học viên từ 1 trở lên !");
                    return;
                }
                HocVien h = new HocVien();
                h = logic.timkiemHocVienByID(mahv);
                ListViewItem i = new ListViewItem();
                i.Text = h.maHV.ToString();
                i.SubItems.Add(h.maLH.ToString());
                i.SubItems.Add(h.tenHV);
                i.SubItems.Add(h.namSinh.ToString());
                i.SubItems.Add(h.diaChi);
                i.SubItems.Add(h.ngheNghiep);
                i.SubItems.Add(h.tinhTrang);
                i.SubItems.Add(h.sDT);
                lsvThongTin.Items.Add(i);
            }
            else if (rs == DialogResult.Yes)
            {
                string tenhv = txtTenHV.Text.Trim();
                if (string.IsNullOrEmpty(tenhv))
                {
                    MessageBox.Show("Phải nhập liệu cho tên học viên chứ !");
                    return;
                }
                dshv = logic.timkiemHocVienByName(tenhv);
                foreach (HocVien h in dshv)
                {
                    ListViewItem i = new ListViewItem();
                    i.Text = h.maHV.ToString();
                    i.SubItems.Add(h.maLH.ToString());
                    i.SubItems.Add(h.tenHV);
                    i.SubItems.Add(h.namSinh.ToString());
                    i.SubItems.Add(h.diaChi);
                    i.SubItems.Add(h.ngheNghiep);
                    i.SubItems.Add(h.tinhTrang);
                    i.SubItems.Add(h.sDT);
                    lsvThongTin.Items.Add(i);
                }
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void frmHocVien_Load(object sender, EventArgs e)
        {
            loadCboxMaLopHoc();
            dshv = logic.HienThiTatCaHocVien();
            loadCboxMaHV();
            loadCboxTinhTrang();
        }

        public void loadLsvThongTinTheoLop(string malop)
        {
            dshv = logic.HienThiTatCaHocVienTheoLop(malop);
            resetLstvThongTin();
            foreach (HocVien h in dshv)
            {
                ListViewItem i = new ListViewItem();
                i.Text = h.maHV.ToString();
                i.SubItems.Add(h.maLH.ToString());
                i.SubItems.Add(h.tenHV);
                i.SubItems.Add(h.namSinh.ToString());
                i.SubItems.Add(h.diaChi);
                i.SubItems.Add(h.ngheNghiep);
                i.SubItems.Add(h.tinhTrang);
                i.SubItems.Add(h.sDT);
                lsvThongTin.Items.Add(i);
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void txtMaHV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError((Control)sender, "Chỉ Cho Nhập Số");
            }
            else
                errorProvider1.Clear();
        }

        private void cboxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cboxMaLop.SelectedValue.ToString();
            linkData(malop);
        }

        private void cboxMaHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Không cần thiết phải lọc lại khi chọn mã sv

            //string mahv = cboxMaHV.Text.Trim();
            //if (mahv != "0")
            //{
            //    resetLstvThongTin();

            //    if (cboxMaHV.SelectedIndex == 0)
            //    {
            //       // MessageBox.Show("Mã học viên 0 có nghĩa là tất cả học viên,bạn vui lòng chọn mã học viên từ 1 trở lên !");
            //        return;
            //    }
            //    HocVien h = new HocVien();
            //    h = logic.timkiemHocVienByID(mahv);
            //    ListViewItem i = new ListViewItem();
            //    i.Text = h.maHV.ToString();
            //    i.SubItems.Add(h.maLH.ToString());
            //    i.SubItems.Add(h.tenHV);
            //    i.SubItems.Add(h.namSinh.ToString());
            //    i.SubItems.Add(h.diaChi);
            //    i.SubItems.Add(h.ngheNghiep);
            //    i.SubItems.Add(h.tinhTrang);
            //    i.SubItems.Add(h.sDT);
            //    lsvThongTin.Items.Add(i);
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(cboxMaLop.Text.Trim()))
            //    {
            //        resetLstvThongTin();
            //        MessageBox.Show("Mã SV=0 là tất cả sv, Vì vậy  Bạn vui lòng chọn một mã lớp muốn xem thông tin ,muốn xem tất cả SV của tất cả Lớp " +
            //            "bạn hãy chọn MaLop là 0 nhé !, còn muốn xem Tất cả SV của thừng lớp,vui lòng chọn mã lớp bắt đầu từ 1");
            //        return;
            //    }
            //    string malop = cboxMaLop.SelectedValue.ToString();
            //    if (cboxMaLop.SelectedIndex == 0)
            //    {
            //        resetLstvThongTin();
            //        loadLsvTatCaHocVien();
            //    }
            //    else
            //    {
            //        resetLstvThongTin();
            //        loadLsvThongTinTheoLop(malop);
            //    }
            //}
        }

        private void lsvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvThongTin.SelectedItems.Count != 0)
            {
                ListViewItem tmp = lsvThongTin.SelectedItems[0];
                cboxMaHV.SelectedIndex = cboxMaHV.FindStringExact(tmp.SubItems[0].Text);
                txtTenHV.Text = tmp.SubItems[2].Text;
                string[] tmp2 = tmp.SubItems[3].Text.Split('/');
                if (int.Parse(tmp2[0]) < 10)
                {
                    mtxtNamSinh.Text = "0" + tmp2[0];
                    if (int.Parse(tmp2[1]) < 10)
                    {
                        mtxtNamSinh.Text = "0" + tmp2[0] + "/" + "0" + tmp2[1] + "/" + tmp2[2];
                    }
                    else
                    {
                        mtxtNamSinh.Text = "0" + tmp2[0] + "/" + tmp2[1] + "/" + tmp2[2];
                    }
                }
                else
                {
                    mtxtNamSinh.Text = tmp2[0];
                    if (int.Parse(tmp2[1]) < 10)
                    {
                        mtxtNamSinh.Text = tmp2[0] + "/" + "0" + tmp2[1] + "/" + tmp2[2];
                    }
                    else
                    {
                        mtxtNamSinh.Text = tmp2[0] + "/" + tmp2[1] + "/" + tmp2[2];
                    }
                }

                txtDiaChi.Text = tmp.SubItems[4].Text;
                txtNgheNgiep.Text = tmp.SubItems[5].Text;
                cboxTinhTrang.SelectedIndex = cboxTinhTrang.FindStringExact(tmp.SubItems[6].Text);
                txtSDT.Text = tmp.SubItems[7].Text;
                cboxMaLop.SelectedIndex = cboxMaLop.FindStringExact(tmp.SubItems[1].Text);
            }
        }
    }
}
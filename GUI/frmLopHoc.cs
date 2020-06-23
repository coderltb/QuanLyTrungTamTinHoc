using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private List<LopHoc> dslh = new List<LopHoc>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            DotKhaiGiang selectdkg = cboDotKhaiGiang.SelectedItem as DotKhaiGiang;
            if (cboDotKhaiGiang.SelectedIndex != 0)
            {
                string itemchuoi = selectdkg._TenDotKhaiGiang.Substring(0, selectdkg._TenDotKhaiGiang.LastIndexOf(' ')).Trim();
                string itemchuoi2 = selectdkg._TenDotKhaiGiang.Substring(selectdkg._TenDotKhaiGiang.LastIndexOf(' ')).Trim();
                bool checktime = false;
                DateTime lichkhaigiang_cvt = DateTime.Parse(DateTime.ParseExact(mtxtNgayKhaiGiang.Text.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                DateTime lichketthuc_cvt = DateTime.Parse(DateTime.ParseExact(mtxtNgayKetThuc.Text.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                int laythanglichkg = lichkhaigiang_cvt.Month;
                int laynamlichkg = lichkhaigiang_cvt.Year;

                if (itemchuoi.Equals("Đợt 1") && laythanglichkg > 5)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (itemchuoi.Equals("Đợt 2") && laythanglichkg > 9)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (itemchuoi.Equals("Đợt 3") && laythanglichkg < 9)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (laynamlichkg != int.Parse(itemchuoi2))
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (lichketthuc_cvt > lichkhaigiang_cvt)
                {
                    List<LopHoc> lopHocs = logic.layToanBoLopHoc();
                    foreach (var item in lopHocs)
                    {
                        if (item.tietHoc.Equals(cboTietHoc.SelectedItem.ToString()) && item.phongHoc.maPH == int.Parse(cboPhongHoc.SelectedValue.ToString()) && item.moLop)
                        {
                            if ((lichketthuc_cvt >= item.lichKhaiGiang && lichketthuc_cvt <= item.lichKetThuc) || (lichkhaigiang_cvt >= item.lichKhaiGiang && lichkhaigiang_cvt <= item.lichKetThuc))
                            {
                                checktime = true;
                            }
                        }
                    }
                    if (!checktime)
                    {
                        LopHoc lh = new LopHoc();
                        lh.phongHoc.maPH = int.Parse(cboPhongHoc.SelectedValue.ToString());
                        lh.khoaHoc.maKH = int.Parse(cboKhoaHoc.SelectedValue.ToString());
                        lh.giangVien.maGV = int.Parse(cboGiaoVien.SelectedValue.ToString());
                        lh.moLop = chkMoLop.Checked;
                        lh.tietHoc = cboTietHoc.SelectedItem.ToString();
                        lh.tinhTrang = cboTinhTrang.SelectedItem.ToString();
                        lh.soLuong = int.Parse(txtSoLuong.Text);
                        lh.dotkhaigiang._MaDotKhaiGiang = int.Parse(cboDotKhaiGiang.SelectedValue.ToString());
                        lh.lichKhaiGiang = lichkhaigiang_cvt;
                        lh.lichKetThuc = lichketthuc_cvt;
                        if (logic.themLopHoc(lh))
                        {
                            MessageBox.Show("Thêm thành công !");
                            loadLstvTatCaLopHoc();
                            loadCboxLopHoc();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trùng Lịch Học Rồi Fix Lại Đi!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lịch Kết Thúc Phải Lớn Hơn Lịch Khai Giảng");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Đợt Khai Giảng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn xoá", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            if (logic.HienThiTatCaCongNo().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Lớp Học Đang Có Trong Công Nợ, không thể xoá ");
            }
            else if (logic.HienThiTatCaBaoLuu().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Lớp Học Đang Có Trong Bảo Lưu, không thể xoá ");
            }
            else if (logic.HienThiTatCaHocVien().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Có Học Sinh Đăng Ký Trong Lớp Này, không thể xoá ");
            }
            else
            {
                if (logic.xoaLopHoc(cboLopHoc.SelectedValue.ToString()))
                {
                    MessageBox.Show("Xoá thành công !");
                    loadLstvTatCaLopHoc();
                    loadCboxLopHoc();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại !");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DotKhaiGiang selectdkg = cboDotKhaiGiang.SelectedItem as DotKhaiGiang;
            if (cboDotKhaiGiang.SelectedIndex != 0)
            {
                string itemchuoi = selectdkg._TenDotKhaiGiang.Substring(0, selectdkg._TenDotKhaiGiang.LastIndexOf(' ')).Trim();
                string itemchuoi2 = selectdkg._TenDotKhaiGiang.Substring(selectdkg._TenDotKhaiGiang.LastIndexOf(' ')).Trim();
                bool checktime = false;
                DateTime lichkhaigiang_cvt = DateTime.Parse(DateTime.ParseExact(mtxtNgayKhaiGiang.Text.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                DateTime lichketthuc_cvt = DateTime.Parse(DateTime.ParseExact(mtxtNgayKetThuc.Text.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
                int laythanglichkg = lichkhaigiang_cvt.Month;
                int laynamlichkg = lichkhaigiang_cvt.Year;

                if (itemchuoi.Equals("Đợt 1") && laythanglichkg > 5)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (itemchuoi.Equals("Đợt 2") && laythanglichkg > 9)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (itemchuoi.Equals("Đợt 3") && laythanglichkg < 9)
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (laynamlichkg != int.Parse(itemchuoi2))
                {
                    MessageBox.Show("Xin Hay Chon Dung Dot Khai Giang!!!(Dot 1 Tu thang 1-> 4,Dot 2 Tu thang 4 -> 8.Dot 3 Tu thang 8 -> 12)");
                    return;
                }
                else if (lichketthuc_cvt > lichkhaigiang_cvt)
                {
                    List<LopHoc> lopHocs = logic.layToanBoLopHoc();
                    foreach (var item in lopHocs)
                    {
                        if (item.tietHoc.Equals(cboTietHoc.SelectedItem.ToString()) && item.phongHoc.maPH == int.Parse(cboPhongHoc.SelectedValue.ToString()) && item.moLop && item.maLH != int.Parse(cboLopHoc.SelectedValue.ToString()))
                        {
                            if ((lichketthuc_cvt >= item.lichKhaiGiang && lichketthuc_cvt <= item.lichKetThuc) || (lichkhaigiang_cvt >= item.lichKhaiGiang && lichkhaigiang_cvt <= item.lichKetThuc))
                            {
                                checktime = true;
                            }
                        }
                    }
                    if (!checktime)
                    {
                        LopHoc lh = new LopHoc();
                        lh.maLH = int.Parse(cboLopHoc.SelectedValue.ToString());
                        lh.phongHoc.maPH = int.Parse(cboPhongHoc.SelectedValue.ToString());
                        lh.khoaHoc.maKH = int.Parse(cboKhoaHoc.SelectedValue.ToString());
                        lh.giangVien.maGV = int.Parse(cboGiaoVien.SelectedValue.ToString());
                        lh.moLop = chkMoLop.Checked;
                        lh.tietHoc = cboTietHoc.SelectedItem.ToString();
                        lh.tinhTrang = cboTinhTrang.SelectedItem.ToString();
                        lh.soLuong = int.Parse(txtSoLuong.Text);
                        lh.lichKhaiGiang = lichkhaigiang_cvt;
                        lh.lichKetThuc = lichketthuc_cvt;
                        lh.dotkhaigiang._MaDotKhaiGiang = int.Parse(cboDotKhaiGiang.SelectedValue.ToString());
                        if (logic.capNhatLopHoc(lh))
                        {
                            MessageBox.Show("Update thành công !");
                            loadLstvTatCaLopHoc();
                        }
                        else
                        {
                            MessageBox.Show("Update thất bại !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trùng Lịch Học Rồi Fix Lại Đi!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lịch Kết Thúc Phải Lớn Hơn Lịch Khai Giảng");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Đợt Khai Giảng");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboDotKhaiGiang.SelectedIndex == 0)
            {
                loadLstvTatCaLopHoc();
            }
            else
            {
                lstvThongTin.Items.Clear();
                dslh = logic.searchLopHoc(int.Parse(cboDotKhaiGiang.SelectedValue.ToString()));
                foreach (var item in dslh)
                {
                    ListViewItem viewItem = new ListViewItem(item.maLH.ToString());
                    viewItem.SubItems.Add(item.phongHoc.tenPG);
                    viewItem.SubItems.Add(item.khoaHoc.tenKH);
                    viewItem.SubItems.Add(item.giangVien.tenGV);
                    viewItem.SubItems.Add(item.tietHoc);
                    viewItem.SubItems.Add(item.lichKhaiGiang.ToShortDateString());
                    viewItem.SubItems.Add(item.lichKetThuc.ToShortDateString());
                    viewItem.SubItems.Add(item.tinhTrang);
                    viewItem.SubItems.Add(item.soLuong.ToString());
                    if (!item.moLop)
                    {
                        viewItem.BackColor = Color.Silver;
                    }
                    lstvThongTin.Items.Add(viewItem);
                }
            }
        }

        private void xuiFormDesign1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            loadCboxLopHoc();
            LoadCboxKhoaHoc();
            LoadCboxPhongHoc();
            LoadCboxGiaoVien();
            loadLstvTatCaLopHoc();
            loadCboxDotKhaiGiang();
        }

        private void loadCboxDotKhaiGiang()
        {
            List<DotKhaiGiang> dotKhaiGiangs = logic.LayToanBoDotKhaiGiang();
            DotKhaiGiang item = new DotKhaiGiang();
            item._MaDotKhaiGiang = 0;
            item._TenDotKhaiGiang = "Tất Cả";
            dotKhaiGiangs.Insert(0, item);
            cboDotKhaiGiang.DataSource = dotKhaiGiangs;
            cboDotKhaiGiang.DisplayMember = "_TenDotKhaiGiang";
            cboDotKhaiGiang.ValueMember = "_MaDotKhaiGiang";
        }

        private void loadCboxLopHoc()
        {
            cboLopHoc.DataSource = logic.layToanBoLopHoc();
            cboLopHoc.DisplayMember = "MALH";
            cboLopHoc.ValueMember = "MALH";
        }

        private void LoadCboxKhoaHoc()
        {
            cboKhoaHoc.DataSource = logic.LayToanBoKhoaHoc();
            cboKhoaHoc.DisplayMember = "TENKH";
            cboKhoaHoc.ValueMember = "MAKH";
        }

        private void LoadCboxPhongHoc()
        {
            cboPhongHoc.DataSource = logic.LayToanBoPhongHoc();
            cboPhongHoc.DisplayMember = "TENPG";
            cboPhongHoc.ValueMember = "MAPH";
        }

        private void LoadCboxGiaoVien()
        {
            cboGiaoVien.DataSource = logic.HienThiTatCaGiangVien();
            cboGiaoVien.ValueMember = "MAGV";
            cboGiaoVien.DisplayMember = "tenGV";
        }

        private void loadLstvTatCaLopHoc()
        {
            lstvThongTin.Items.Clear();
            dslh = logic.layToanBoLopHoc();
            foreach (var item in dslh)
            {
                ListViewItem viewItem = new ListViewItem(item.maLH.ToString());
                viewItem.SubItems.Add(item.phongHoc.tenPG);
                viewItem.SubItems.Add(item.khoaHoc.tenKH);
                viewItem.SubItems.Add(item.giangVien.tenGV);
                viewItem.SubItems.Add(item.tietHoc);
                viewItem.SubItems.Add(item.lichKhaiGiang.ToShortDateString());
                viewItem.SubItems.Add(item.lichKetThuc.ToShortDateString());
                viewItem.SubItems.Add(item.tinhTrang);
                viewItem.SubItems.Add(item.soLuong.ToString());
                if (!item.moLop)
                {
                    viewItem.BackColor = Color.Silver;
                }
                lstvThongTin.Items.Add(viewItem);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError((Control)sender, "Chỉ Cho Nhập Số");
            }
            else
                errorProvider1.Clear();
        }

        private void lstvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvThongTin.SelectedItems.Count != 0)
            {
                ListViewItem tmp = lstvThongTin.SelectedItems[0];
                cboLopHoc.SelectedIndex = cboLopHoc.FindStringExact(tmp.SubItems[0].Text);
                cboPhongHoc.SelectedIndex = cboPhongHoc.FindStringExact(tmp.SubItems[1].Text);
                cboKhoaHoc.SelectedIndex = cboKhoaHoc.FindStringExact(tmp.SubItems[2].Text);
                cboGiaoVien.SelectedIndex = cboGiaoVien.FindStringExact(tmp.SubItems[3].Text);
                cboTietHoc.SelectedIndex = cboTietHoc.FindStringExact(tmp.SubItems[4].Text);
                string[] tmp2 = tmp.SubItems[5].Text.Split('/');
                if (int.Parse(tmp2[0]) < 10)
                {
                    mtxtNgayKhaiGiang.Text = "0" + tmp2[0];
                    if (int.Parse(tmp2[1]) < 10)
                    {
                        mtxtNgayKhaiGiang.Text = "0" + tmp2[0] + "/" + "0" + tmp2[1] + "/" + tmp2[2];
                    }
                    else
                    {
                        mtxtNgayKhaiGiang.Text = "0" + tmp2[0] + "/" + tmp2[1] + "/" + tmp2[2];
                    }
                }
                else
                {
                    mtxtNgayKhaiGiang.Text = tmp2[0];
                    if (int.Parse(tmp2[1]) < 10)
                    {
                        mtxtNgayKhaiGiang.Text = tmp2[0] + "/" + "0" + tmp2[1] + "/" + tmp2[2];
                    }
                    else
                    {
                        mtxtNgayKhaiGiang.Text = tmp2[0] + "/" + tmp2[1] + "/" + tmp2[2];
                    }
                }
                string[] tmp3 = tmp.SubItems[6].Text.Split('/');
                if (int.Parse(tmp3[0]) < 10)
                {
                    mtxtNgayKetThuc.Text = "0" + tmp3[0];
                    if (int.Parse(tmp3[1]) < 10)
                    {
                        mtxtNgayKetThuc.Text = "0" + tmp3[0] + "/" + "0" + tmp3[1] + "/" + tmp3[2];
                    }
                    else
                    {
                        mtxtNgayKetThuc.Text = "0" + tmp3[0] + "/" + tmp3[1] + "/" + tmp3[2];
                    }
                }
                else
                {
                    mtxtNgayKetThuc.Text = tmp3[0];
                    if (int.Parse(tmp3[1]) < 10)
                    {
                        mtxtNgayKetThuc.Text = tmp3[0] + "/" + "0" + tmp3[1] + "/" + tmp3[2];
                    }
                    else
                    {
                        mtxtNgayKetThuc.Text = tmp3[0] + "/" + tmp3[1] + "/" + tmp3[2];
                    }
                }

                cboTinhTrang.SelectedIndex = cboTinhTrang.FindStringExact(tmp.SubItems[7].Text);
                txtSoLuong.Text = tmp.SubItems[8].Text;
                if (tmp.BackColor == Color.Silver)
                {
                    chkMoLop.Checked = false;
                }
                else
                {
                    chkMoLop.Checked = true;
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn xoá", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.No)
                return;
            if (logic.HienThiTatCaCongNo().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Lớp Học Đang Có Trong Công Nợ, không thể xoá ");
            }
            else if (logic.HienThiTatCaBaoLuu().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Lớp Học Đang Có Trong Bảo Lưu, không thể xoá ");
            }
            else if (logic.HienThiTatCaHocVien().Exists(x => x.maLH == int.Parse(cboLopHoc.SelectedValue.ToString())))
            {
                MessageBox.Show("Có Học Sinh Đăng Ký Trong Lớp Này, không thể xoá ");
            }
            else
            {
                if (lstvThongTin.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lstvThongTin.SelectedItems)
                    {
                        if (!logic.xoaLopHoc(item.SubItems[0].Text))
                        {
                            MessageBox.Show("Xoá thất bại !");
                            break;
                        }
                    }
                    MessageBox.Show("Xoá thành công !");
                    loadLstvTatCaLopHoc();
                    loadCboxLopHoc();
                }
            }
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            frmOptionDotKhaiGiang option = new frmOptionDotKhaiGiang();
            if (option.ShowDialog() == DialogResult.OK)
            {
                loadCboxDotKhaiGiang();
            }
        }

        private void cboDotKhaiGiang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
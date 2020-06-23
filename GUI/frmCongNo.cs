using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCongNo : Form
    {
        public frmCongNo()
        {
            InitializeComponent();
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private List<CongNo> dscn = new List<CongNo>();

        private List<LopHoc> dslh = new List<LopHoc>();

        public void loadCboxMaBL()
        {
            cboxMaBLuu.DataSource = logic.HienThiTatCaBaoLuu();
            cboxMaBLuu.DisplayMember = "MABL";
            cboxMaBLuu.ValueMember = "MABL";
        }

        public bool kiemTraNhapLieu()
        {
            foreach (Control c in pnlNoiDungThu.Controls)
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

        public void loadCboxMaLop()  //Chỉ chỉnh hàm này ,đừng đụng hàm khác
        {
            dslh = logic.layToanBoLopHoc();
            LopHoc lh = new LopHoc();
            lh.maLH = 00;
            lh.khoaHoc.tenKH = "Tất cả";
            dslh.Insert(0, lh);
            cboxMaLop.DataSource = dslh;
            cboxMaLop.DisplayMember = "TENKH";
            cboxMaLop.ValueMember = "MALH";
        }

        public void loadGridCongNo()
        {
            dscn = logic.HienThiTatCaCongNo();
            gridvThongTin.DataSource = dscn;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemTraNhapLieu())
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin !");
                    return;
                }
                if (cboxMaLop.SelectedIndex == 0)
                {
                    MessageBox.Show("Bạn đang chọn tất cả lớp,vui lòng chọn mã lớp khác !");
                    return;
                }
                CongNo cn = new CongNo();
                cn.maBL = int.Parse(cboxMaBLuu.SelectedValue.ToString());
                cn.maLH = int.Parse(cboxMaLop.SelectedValue.ToString());
                cn.hocPhi = float.Parse(txtHocPhi.Text);
                cn.soTienNop = float.Parse(txtSoTienNop.Text);
                cn.soTienConLai = float.Parse(txtSoTienConLai.Text);
                cn.soDu = float.Parse(txtSoDu.Text);
                cn.noiDungThu = txtNoiDung.Text.Trim();
                cn.trangThai = txtTrangThai.Text.Trim();
                if (logic.capnhatCongNo(cn))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    loadGridCongNo();
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
                string malop = cboxMaLop.SelectedValue.ToString();
                string mabl = cboxMaBLuu.SelectedValue.ToString();
                if (cboxMaBLuu.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy chọn một mã bảo lưu !");
                    return;
                }
                if (cboxMaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy chọn một mã lớp học !");
                    return;
                }
                if (logic.xoaCongNo(malop, mabl))
                {
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại !");
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
                if (!kiemTraNhapLieu())
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin !");
                    return;
                }
                if (cboxMaLop.SelectedIndex == 0)
                {
                    MessageBox.Show("Bạn đang chọn tất cả lớp,vui lòng chọn mã lớp khác !");
                    return;
                }
                CongNo cn = new CongNo();
                cn.maBL = int.Parse(cboxMaBLuu.SelectedValue.ToString());
                cn.maLH = int.Parse(cboxMaLop.SelectedValue.ToString());
                cn.hocPhi = float.Parse(txtHocPhi.Text);
                cn.soTienNop = float.Parse(txtSoTienNop.Text);
                cn.soTienConLai = float.Parse(txtSoTienConLai.Text);
                cn.soDu = float.Parse(txtSoDu.Text);
                cn.noiDungThu = txtNoiDung.Text.Trim();
                cn.trangThai = txtTrangThai.Text.Trim();
                if (logic.themCongNo(cn))
                {
                    MessageBox.Show("Thêm thành công !");
                    loadGridCongNo();
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

        private void pictureExixt_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rs == DialogResult.Yes)
                Close();
        }

        private void txtHocPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError((Control)sender, "Chỉ Cho Nhập Số");
            }
            else
                errorProvider1.Clear();
        }

        private void frmCongNo_Load(object sender, EventArgs e)
        {
            loadCboxMaBL();
            loadCboxMaLop();
            loadGridCongNo();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mabl = cboxMaBLuu.SelectedValue.ToString();
            dscn = logic.TimKiemCongNoTheoMaBL(mabl);
            gridvThongTin.DataSource = dscn;
            if (gridvThongTin.Rows.Count == 0)
                MessageBox.Show("không có Công nợ nào có mã bảo lưu và lớp học này !");
            //string malop = cboxMaLop.SelectedValue.ToString();
            //dscn = logic.TimKiemCongNo(mabl, malop);
            //gridvThongTin.DataSource = dscn;
            //if (gridvThongTin.Rows.Count == 0)
            //    MessageBox.Show("không có Công nợ nào có mã bảo lưu và lớp học này !");
        }

        private void cboxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = cboxMaLop.SelectedValue.ToString();
            if (cboxMaLop.SelectedIndex != 0)
            {
                dscn = logic.TimKiemCongNoTheoMaLop(malop);
            }
            else
            {
                dscn = logic.HienThiTatCaCongNo();
            }
            gridvThongTin.DataSource = dscn;
        }

        private void gridvThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridvThongTin.Rows[e.RowIndex];
            txtNoiDung.Text = row.Cells[2].Value.ToString(); ;
            txtHocPhi.Text = row.Cells[3].Value.ToString();
            txtSoTienNop.Text = row.Cells[4].Value.ToString();
            txtSoTienConLai.Text = row.Cells[5].Value.ToString();
            txtSoDu.Text = row.Cells[6].Value.ToString();
            txtTrangThai.Text = row.Cells[7].Value.ToString();
            cboxMaBLuu.SelectedIndex = cboxMaBLuu.FindStringExact(row.Cells[0].Value.ToString());
            cboxMaLop.SelectedIndex = cboxMaLop.FindStringExact(row.Cells[1].Value.ToString());
        }
    }
}
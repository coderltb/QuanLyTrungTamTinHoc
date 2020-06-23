using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmOptionDotKhaiGiang : Form
    {
        public frmOptionDotKhaiGiang()
        {
            InitializeComponent();
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private void frmOptionDotKhaiGiang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNam.Text.Trim()))
            {
                string tmp = cboThemDotKG.SelectedItem.ToString() + " " + txtNam.Text.Trim();
                if (!logic.LayToanBoDotKhaiGiang().Exists(x => x._TenDotKhaiGiang.Equals(tmp)))
                {
                    DotKhaiGiang dkg = new DotKhaiGiang();
                    dkg._TenDotKhaiGiang = tmp;
                    if (logic.themDotKhaiGiang(dkg))
                    {
                        MessageBox.Show("Thêm Thành Công !");
                        loadcboDotKhaiGiang();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại !");
                    }
                    cboThemDotKG.SelectedIndex = 0;
                    txtNam.ResetText();
                }
                else
                {
                    MessageBox.Show("Đã có Đợt Khai Giảng này rồi");
                }
            }
            else
            {
                MessageBox.Show("Xin Hãy Điền Đầy Đủ Thông Tin!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNam.Text.Trim()))
            {
                string tmp = cboThemDotKG.SelectedItem.ToString() + " " + txtNam.Text.Trim();
                if (!logic.LayToanBoDotKhaiGiang().Exists(x => x._TenDotKhaiGiang.Equals(tmp)))
                {
                    DotKhaiGiang dkg = new DotKhaiGiang();
                    dkg._TenDotKhaiGiang = tmp;
                    if (logic.capnhatDotKhaiGiang(dkg))
                    {
                        MessageBox.Show("Update Thành Công !");
                        loadcboDotKhaiGiang();
                    }
                    else
                    {
                        MessageBox.Show("Update Thất Bại !");
                    }
                    cboThemDotKG.SelectedIndex = 0;
                    txtNam.ResetText();
                }
                else
                {
                    MessageBox.Show("Đã có Đợt Khai Giảng này rồi");
                }
            }
            else
            {
                MessageBox.Show("Xin Hãy Điền Đầy Đủ Thông Tin!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNam.Text.Trim()))
            {
                string tmp = cboThemDotKG.SelectedItem.ToString() + " " + txtNam.Text.Trim();
                if (!logic.LayToanBoDotKhaiGiang().Exists(x => x._TenDotKhaiGiang.Equals(tmp)))
                {
                    DotKhaiGiang dkg = new DotKhaiGiang();
                    dkg._TenDotKhaiGiang = tmp;
                    if (logic.xoaDotKhaiGiang(dkg._TenDotKhaiGiang))
                    {
                        MessageBox.Show("Xóa Thành Công !");
                        loadcboDotKhaiGiang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại !");
                    }
                    cboThemDotKG.SelectedIndex = 0;
                    txtNam.ResetText();
                }
                else
                {
                    MessageBox.Show("Đã có Đợt Khai Giảng này rồi");
                }
            }
            else
            {
                MessageBox.Show("Xin Hãy Điền Đầy Đủ Thông Tin!!");
            }
        }

        private void frmOptionDotKhaiGiang_Load(object sender, EventArgs e)
        {
            loadcboDotKhaiGiang();
        }

        private void loadcboDotKhaiGiang()
        {
            cboDotKhaiGiang.DataSource = logic.LayToanBoDotKhaiGiang();
            cboDotKhaiGiang.DisplayMember = "_TenDotKhaiGiang";
            cboDotKhaiGiang.ValueMember = "_MaDotKhaiGiang";
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError((Control)sender, "Chỉ Cho Nhập Số");
            }
            else
                errorProvider1.Clear();
        }
    }
}
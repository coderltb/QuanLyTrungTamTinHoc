using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRegister_Admin : Form
    {
        public frmRegister_Admin()
        {
            InitializeComponent();
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()) && !string.IsNullOrEmpty(txtSDT.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (!logic.layToanBoUser().Exists(x => x._UserName.Equals(txtUserName.Text.Trim())))
                {
                    User user = new User();
                    user._UserName = txtUserName.Text;
                    user._Password = txtPassword.Text;
                    user._Email = txtEmail.Text;
                    user._SDT = txtSDT.Text;
                    user._IsAdmin = chkIsAdmin.Checked;
                    if (logic.Register_Admin(user))
                    {
                        MessageBox.Show("Đăng Ký Thành Công !");
                        loadGridCongNo();
                        loadCboxUser();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Ký Thất Bại !");
                    }
                    ResetInformation();
                }
                else
                {
                    MessageBox.Show("Đã có user này rồi");
                }
            }
            else
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin");
            }
        }

        private void ResetInformation()
        {
            txtSDT.ResetText();
            txtEmail.ResetText();
            txtPassword.ResetText();
            txtUserName.ResetText();
            chkIsAdmin.Checked = false;
        }

        public void loadCboxUser()
        {
            cboUser.DataSource = logic.layToanBoLopHoc();
            cboUser.DisplayMember = "_UserName";
            cboUser.ValueMember = "_MaUser";
        }

        public void loadGridCongNo()
        {
            dataGridView1.DataSource = logic.HienThiTatCaCongNo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (logic.Delete_Amin(int.Parse(cboUser.SelectedValue.ToString())))
            {
                MessageBox.Show("Delete Thành Công !");
                loadGridCongNo();
                loadCboxUser();
            }
            else
            {
                MessageBox.Show("Delete Thất Bại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            User user = new User();
            user._UserName = txtUserName.Text;
            user._Password = txtPassword.Text;
            user._Email = txtEmail.Text;
            user._SDT = txtSDT.Text;
            user._IsAdmin = chkIsAdmin.Checked;
            if (logic.Edit_Amin(user))
            {
                MessageBox.Show("Edit Thành Công !");
                loadGridCongNo();
            }
            else
            {
                MessageBox.Show("Edit Thất Bại !");
            }
            ResetInformation();
        }

        private void frmRegister_Admin_Load(object sender, EventArgs e)
        {
            loadGridCongNo();
            loadCboxUser();
        }
    }
}
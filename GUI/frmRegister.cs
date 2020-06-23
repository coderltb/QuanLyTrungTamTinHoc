using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRegister : MetroFramework.Forms.MetroForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
        }

        private UtilitiesBLL logic = new UtilitiesBLL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text.Trim()) && !string.IsNullOrEmpty(txtPass.Text.Trim()) && !string.IsNullOrEmpty(txtSDT.Text.Trim()) && !string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                User user = new User();
                user._UserName = txtUser.Text;
                user._Password = txtPass.Text;
                user._Email = txtEmail.Text;
                user._SDT = txtSDT.Text;
                if (logic.Register_User(user))
                {
                    MessageBox.Show("Đăng Ký Thành Công !");
                    txtSDT.ResetText();
                    txtEmail.ResetText();
                    txtPass.ResetText();
                    txtUser.ResetText();
                }
                else
                {
                    MessageBox.Show("Đăng Ký Thất Bại !");
                    txtSDT.ResetText();
                    txtEmail.ResetText();
                    txtPass.ResetText();
                    txtUser.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
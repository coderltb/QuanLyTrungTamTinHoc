using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public string UserName;

        private UtilitiesBLL xuly = new UtilitiesBLL();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // Tọa độ x của góc trên bên trái
          int nTopRect,      // Tọa độ y của góc trên bên trái
          int nRightRect,    // Tọa độ x của góc dưới bên phải
          int nBottomRect,   // Tọa độ y của góc dưới bên phải
          int nWidthEllipse, // Chiều Cao ellipse
          int nHeightEllipse // Chiều Rộng ellipse
      );

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> dsUser = xuly.layToanBoUser();
            UserName = txtUser.Text.Trim();
            foreach (User user in dsUser)
            {
                if (user._UserName.Equals(txtUser.Text.Trim()) && user._Password.Equals(txtPass.Text.Trim()))
                {
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
            MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu Rồi", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                this.Close();
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.DarkTurquoise;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.RoyalBlue;
        }
    }
}
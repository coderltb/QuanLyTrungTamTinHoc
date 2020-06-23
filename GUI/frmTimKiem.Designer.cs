namespace GUI
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNoiDung = new XanderUI.XUIGradientPanel();
            this.btnTimKiem = new XanderUI.XUIButton();
            this.txtTimKiem = new MetroFramework.Controls.MetroTextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.pnlNoiDung.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BottomLeft = System.Drawing.Color.Cyan;
            this.pnlNoiDung.BottomRight = System.Drawing.Color.Yellow;
            this.pnlNoiDung.Controls.Add(this.btnTimKiem);
            this.pnlNoiDung.Controls.Add(this.txtTimKiem);
            this.pnlNoiDung.Controls.Add(this.lblTimKiem);
            this.pnlNoiDung.Location = new System.Drawing.Point(172, 84);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.PrimerColor = System.Drawing.Color.White;
            this.pnlNoiDung.Size = new System.Drawing.Size(734, 316);
            this.pnlNoiDung.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.pnlNoiDung.TabIndex = 25;
            this.pnlNoiDung.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.pnlNoiDung.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.Red;
            this.btnTimKiem.ButtonImage = null;
            this.btnTimKiem.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.ClickBackColor = System.Drawing.Color.Black;
            this.btnTimKiem.ClickTextColor = System.Drawing.Color.Black;
            this.btnTimKiem.CornerRadius = 5;
            this.btnTimKiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTimKiem.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnTimKiem.HoverTextColor = System.Drawing.Color.Red;
            this.btnTimKiem.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btnTimKiem.Location = new System.Drawing.Point(564, 133);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.CustomButton.Image = null;
            this.txtTimKiem.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtTimKiem.CustomButton.Name = "";
            this.txtTimKiem.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTimKiem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimKiem.CustomButton.TabIndex = 1;
            this.txtTimKiem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimKiem.CustomButton.UseSelectable = true;
            this.txtTimKiem.CustomButton.Visible = false;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(219, 133);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PromptText = "Tìm kiếm...";
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(326, 25);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.UseSelectable = true;
            this.txtTimKiem.WaterMark = "Tìm kiếm...";
            this.txtTimKiem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimKiem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lblTimKiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Maroon;
            this.lblTimKiem.Location = new System.Drawing.Point(65, 135);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(148, 23);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Dữ liệu cần tìm";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Controls.Add(this.pictureExit);
            this.pnlTieuDe.Location = new System.Drawing.Point(172, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(734, 89);
            this.pnlTieuDe.TabIndex = 23;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(645, 89);
            this.lblTieuDe.TabIndex = 15;
            this.lblTieuDe.Text = "TÌM KIẾM";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureExit
            // 
            this.pictureExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(644, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 89);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 14;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.pbAnh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 400);
            this.panel2.TabIndex = 24;
            // 
            // pbAnh
            // 
            this.pbAnh.Image = global::GUI.Properties.Resources.tanjiro;
            this.pbAnh.Location = new System.Drawing.Point(0, 0);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(175, 400);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 400);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel pnlNoiDung;
        private XanderUI.XUIButton btnTimKiem;
        private MetroFramework.Controls.MetroTextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        protected internal System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbAnh;
    }
}
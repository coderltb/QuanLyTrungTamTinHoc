namespace GUI
{
    partial class frmPhongHoc
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.dgvPhongHoc = new System.Windows.Forms.DataGridView();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNoiDung = new DevComponents.DotNetBar.PanelEx();
            this.btnThemPhongHocMoi = new DevComponents.DotNetBar.ButtonX();
            this.gbThemPhongHoc = new System.Windows.Forms.GroupBox();
            this.cboThemSL = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblThemSoLuong = new System.Windows.Forms.Label();
            this.lblThemKhoaHoc = new System.Windows.Forms.Label();
            this.txtThemPH = new System.Windows.Forms.TextBox();
            this.cboSoLuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTenPH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenPhongHoc = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).BeginInit();
            this.pnlNoiDung.SuspendLayout();
            this.gbThemPhongHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.otakusan_net_4553_Mirai;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSua.Location = new System.Drawing.Point(24, 469);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 60);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlButton.Controls.Add(this.pictureBox1);
            this.pnlButton.Controls.Add(this.btnSua);
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnTimKiem);
            this.pnlButton.Controls.Add(this.btnThem);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(216, 704);
            this.pnlButton.TabIndex = 15;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(24, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 60);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 556);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThem.Location = new System.Drawing.Point(24, 282);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 60);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Controls.Add(this.pictureExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 86);
            this.panel1.TabIndex = 63;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionLabel1.Location = new System.Drawing.Point(0, 0);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(739, 86);
            this.reflectionLabel1.TabIndex = 14;
            this.reflectionLabel1.Text = "<div align=\"center\"><b><font size=\"+18\" color=\"#adff2f\"><i> PHÒNG </i><font> HỌC<" +
    "/font></font></b></div>";
            // 
            // pictureExit
            // 
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(739, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 13;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // dgvPhongHoc
            // 
            this.dgvPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPH,
            this.TENPH,
            this.SOLUONG});
            this.dgvPhongHoc.Location = new System.Drawing.Point(15, 246);
            this.dgvPhongHoc.Name = "dgvPhongHoc";
            this.dgvPhongHoc.RowHeadersWidth = 51;
            this.dgvPhongHoc.RowTemplate.Height = 24;
            this.dgvPhongHoc.Size = new System.Drawing.Size(802, 360);
            this.dgvPhongHoc.TabIndex = 63;
            this.dgvPhongHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongHoc_CellClick);
            // 
            // MAPH
            // 
            this.MAPH.DataPropertyName = "MAPH";
            this.MAPH.HeaderText = "Mã PH";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            this.MAPH.ReadOnly = true;
            this.MAPH.Width = 150;
            // 
            // TENPH
            // 
            this.TENPH.DataPropertyName = "TENPG";
            this.TENPH.HeaderText = "Tên PH";
            this.TENPH.MinimumWidth = 6;
            this.TENPH.Name = "TENPH";
            this.TENPH.ReadOnly = true;
            this.TENPH.Width = 200;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 150;
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNoiDung.Controls.Add(this.btnThemPhongHocMoi);
            this.pnlNoiDung.Controls.Add(this.gbThemPhongHoc);
            this.pnlNoiDung.Controls.Add(this.cboSoLuong);
            this.pnlNoiDung.Controls.Add(this.cboTenPH);
            this.pnlNoiDung.Controls.Add(this.lblSoLuong);
            this.pnlNoiDung.Controls.Add(this.lblTenPhongHoc);
            this.pnlNoiDung.Controls.Add(this.dgvPhongHoc);
            this.pnlNoiDung.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(216, 86);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(829, 618);
            this.pnlNoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNoiDung.Style.GradientAngle = 90;
            this.pnlNoiDung.TabIndex = 70;
            this.pnlNoiDung.Text = "panelEx1";
            // 
            // btnThemPhongHocMoi
            // 
            this.btnThemPhongHocMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemPhongHocMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThemPhongHocMoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemPhongHocMoi.Location = new System.Drawing.Point(359, 74);
            this.btnThemPhongHocMoi.Name = "btnThemPhongHocMoi";
            this.btnThemPhongHocMoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.btnThemPhongHocMoi.Size = new System.Drawing.Size(176, 42);
            this.btnThemPhongHocMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemPhongHocMoi.TabIndex = 98;
            this.btnThemPhongHocMoi.Text = "Phòng học mới";
            this.btnThemPhongHocMoi.Click += new System.EventHandler(this.btnPhongHocMoi_Click);
            // 
            // gbThemPhongHoc
            // 
            this.gbThemPhongHoc.Controls.Add(this.cboThemSL);
            this.gbThemPhongHoc.Controls.Add(this.lblThemSoLuong);
            this.gbThemPhongHoc.Controls.Add(this.lblThemKhoaHoc);
            this.gbThemPhongHoc.Controls.Add(this.txtThemPH);
            this.gbThemPhongHoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThemPhongHoc.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbThemPhongHoc.Location = new System.Drawing.Point(53, 136);
            this.gbThemPhongHoc.Name = "gbThemPhongHoc";
            this.gbThemPhongHoc.Size = new System.Drawing.Size(732, 85);
            this.gbThemPhongHoc.TabIndex = 97;
            this.gbThemPhongHoc.TabStop = false;
            this.gbThemPhongHoc.Text = "Phòng học mới";
            // 
            // cboThemSL
            // 
            this.cboThemSL.DisplayMember = "Text";
            this.cboThemSL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThemSL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThemSL.FormattingEnabled = true;
            this.cboThemSL.ItemHeight = 21;
            this.cboThemSL.Location = new System.Drawing.Point(612, 36);
            this.cboThemSL.Name = "cboThemSL";
            this.cboThemSL.Size = new System.Drawing.Size(114, 27);
            this.cboThemSL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThemSL.TabIndex = 96;
            // 
            // lblThemSoLuong
            // 
            this.lblThemSoLuong.AutoSize = true;
            this.lblThemSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemSoLuong.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemSoLuong.Location = new System.Drawing.Point(490, 43);
            this.lblThemSoLuong.Name = "lblThemSoLuong";
            this.lblThemSoLuong.Size = new System.Drawing.Size(75, 19);
            this.lblThemSoLuong.TabIndex = 95;
            this.lblThemSoLuong.Text = "Số lượng";
            // 
            // lblThemKhoaHoc
            // 
            this.lblThemKhoaHoc.AutoSize = true;
            this.lblThemKhoaHoc.Location = new System.Drawing.Point(14, 39);
            this.lblThemKhoaHoc.Name = "lblThemKhoaHoc";
            this.lblThemKhoaHoc.Size = new System.Drawing.Size(87, 19);
            this.lblThemKhoaHoc.TabIndex = 93;
            this.lblThemKhoaHoc.Text = "Tên phòng";
            // 
            // txtThemPH
            // 
            this.txtThemPH.Location = new System.Drawing.Point(158, 36);
            this.txtThemPH.Name = "txtThemPH";
            this.txtThemPH.Size = new System.Drawing.Size(193, 26);
            this.txtThemPH.TabIndex = 94;
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.DisplayMember = "Text";
            this.cboSoLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.ItemHeight = 21;
            this.cboSoLuong.Location = new System.Drawing.Point(664, 23);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(121, 27);
            this.cboSoLuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSoLuong.TabIndex = 86;
            // 
            // cboTenPH
            // 
            this.cboTenPH.DisplayMember = "TenPH";
            this.cboTenPH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenPH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTenPH.FormattingEnabled = true;
            this.cboTenPH.ItemHeight = 21;
            this.cboTenPH.Location = new System.Drawing.Point(232, 23);
            this.cboTenPH.Name = "cboTenPH";
            this.cboTenPH.Size = new System.Drawing.Size(178, 27);
            this.cboTenPH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTenPH.TabIndex = 85;
            this.cboTenPH.ValueMember = "MaPH";
            this.cboTenPH.SelectedIndexChanged += new System.EventHandler(this.cboTenPH_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoLuong.Location = new System.Drawing.Point(499, 23);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(75, 19);
            this.lblSoLuong.TabIndex = 84;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblTenPhongHoc
            // 
            this.lblTenPhongHoc.AutoSize = true;
            this.lblTenPhongHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTenPhongHoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPhongHoc.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenPhongHoc.Location = new System.Drawing.Point(67, 23);
            this.lblTenPhongHoc.Name = "lblTenPhongHoc";
            this.lblTenPhongHoc.Size = new System.Drawing.Size(118, 19);
            this.lblTenPhongHoc.TabIndex = 83;
            this.lblTenPhongHoc.Text = "Tên phòng học";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1045, 704);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhongHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhongHoc";
            this.Load += new System.EventHandler(this.frmPhongHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).EndInit();
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            this.gbThemPhongHoc.ResumeLayout(false);
            this.gbThemPhongHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        protected internal System.Windows.Forms.PictureBox pictureExit;
        public System.Windows.Forms.DataGridView dgvPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private DevComponents.DotNetBar.PanelEx pnlNoiDung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSoLuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTenPH;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenPhongHoc;
        private DevComponents.DotNetBar.ButtonX btnThemPhongHocMoi;
        private System.Windows.Forms.GroupBox gbThemPhongHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThemSL;
        private System.Windows.Forms.Label lblThemSoLuong;
        private System.Windows.Forms.Label lblThemKhoaHoc;
        private System.Windows.Forms.TextBox txtThemPH;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}
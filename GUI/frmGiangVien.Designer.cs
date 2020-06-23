namespace GUI
{
    partial class frmGiangVien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.pnlNoiDung = new DevComponents.DotNetBar.PanelEx();
            this.btnThemGiangVienMoi = new DevComponents.DotNetBar.ButtonX();
            this.gbThemGiangVien = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThemTenGV = new System.Windows.Forms.TextBox();
            this.txtThemDiaChi = new System.Windows.Forms.TextBox();
            this.lblThemDiaChi = new System.Windows.Forms.Label();
            this.cboThemTrinhDo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtThemSDT = new System.Windows.Forms.TextBox();
            this.lblThemSDT = new System.Windows.Forms.Label();
            this.lblThemTrinhDo = new System.Windows.Forms.Label();
            this.dtiNamSinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblThemNamSinh = new System.Windows.Forms.Label();
            this.lblThemMaGV = new System.Windows.Forms.Label();
            this.txtThemMaGV = new System.Windows.Forms.TextBox();
            this.cboTenGV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTrinhDo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtNamSinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRINHDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.pnlNoiDung.SuspendLayout();
            this.gbThemGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.otakusan_net_4511_tomoe_gozen;
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
            this.btnSua.Location = new System.Drawing.Point(24, 475);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 60);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(24, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 60);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThem.Location = new System.Drawing.Point(24, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 60);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlButton.Controls.Add(this.btnTimKiem);
            this.pnlButton.Controls.Add(this.pictureBox1);
            this.pnlButton.Controls.Add(this.btnSua);
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnThem);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(216, 788);
            this.pnlButton.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 564);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.reflectionLabel1);
            this.pnlTitle.Controls.Add(this.pictureExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(216, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(847, 86);
            this.pnlTitle.TabIndex = 77;
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
            this.reflectionLabel1.Size = new System.Drawing.Size(757, 86);
            this.reflectionLabel1.TabIndex = 91;
            this.reflectionLabel1.Text = "<div align=\"center\"><b><font size=\"+18\" color=\"#adff2f\"><i> GIẢNG </i><font> VIÊN" +
    "</font></font></b></div>";
            // 
            // pictureExit
            // 
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(757, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 21;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNoiDung.Controls.Add(this.btnThemGiangVienMoi);
            this.pnlNoiDung.Controls.Add(this.gbThemGiangVien);
            this.pnlNoiDung.Controls.Add(this.cboTenGV);
            this.pnlNoiDung.Controls.Add(this.cboTrinhDo);
            this.pnlNoiDung.Controls.Add(this.txtNamSinh);
            this.pnlNoiDung.Controls.Add(this.txtDienThoai);
            this.pnlNoiDung.Controls.Add(this.lblSDT);
            this.pnlNoiDung.Controls.Add(this.txtDiaChi);
            this.pnlNoiDung.Controls.Add(this.lblNamSinh);
            this.pnlNoiDung.Controls.Add(this.lblDiaChi);
            this.pnlNoiDung.Controls.Add(this.lblTrinhDo);
            this.pnlNoiDung.Controls.Add(this.lblTenGV);
            this.pnlNoiDung.Controls.Add(this.dgvGiangVien);
            this.pnlNoiDung.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(216, 86);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(847, 702);
            this.pnlNoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNoiDung.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlNoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNoiDung.Style.GradientAngle = 90;
            this.pnlNoiDung.TabIndex = 81;
            // 
            // btnThemGiangVienMoi
            // 
            this.btnThemGiangVienMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemGiangVienMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThemGiangVienMoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemGiangVienMoi.Location = new System.Drawing.Point(350, 144);
            this.btnThemGiangVienMoi.Name = "btnThemGiangVienMoi";
            this.btnThemGiangVienMoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.btnThemGiangVienMoi.Size = new System.Drawing.Size(176, 42);
            this.btnThemGiangVienMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemGiangVienMoi.TabIndex = 124;
            this.btnThemGiangVienMoi.Text = "Giảng viên mới";
            this.btnThemGiangVienMoi.Click += new System.EventHandler(this.btnThemGiangVienMoi_Click);
            // 
            // gbThemGiangVien
            // 
            this.gbThemGiangVien.Controls.Add(this.label1);
            this.gbThemGiangVien.Controls.Add(this.txtThemTenGV);
            this.gbThemGiangVien.Controls.Add(this.txtThemDiaChi);
            this.gbThemGiangVien.Controls.Add(this.lblThemDiaChi);
            this.gbThemGiangVien.Controls.Add(this.cboThemTrinhDo);
            this.gbThemGiangVien.Controls.Add(this.txtThemSDT);
            this.gbThemGiangVien.Controls.Add(this.lblThemSDT);
            this.gbThemGiangVien.Controls.Add(this.lblThemTrinhDo);
            this.gbThemGiangVien.Controls.Add(this.dtiNamSinh);
            this.gbThemGiangVien.Controls.Add(this.lblThemNamSinh);
            this.gbThemGiangVien.Controls.Add(this.lblThemMaGV);
            this.gbThemGiangVien.Controls.Add(this.txtThemMaGV);
            this.gbThemGiangVien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThemGiangVien.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbThemGiangVien.Location = new System.Drawing.Point(38, 179);
            this.gbThemGiangVien.Name = "gbThemGiangVien";
            this.gbThemGiangVien.Size = new System.Drawing.Size(797, 175);
            this.gbThemGiangVien.TabIndex = 123;
            this.gbThemGiangVien.TabStop = false;
            this.gbThemGiangVien.Text = "Giảng viên mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 129;
            this.label1.Text = "Tên giảng viên";
            // 
            // txtThemTenGV
            // 
            this.txtThemTenGV.Location = new System.Drawing.Point(537, 32);
            this.txtThemTenGV.Name = "txtThemTenGV";
            this.txtThemTenGV.Size = new System.Drawing.Size(233, 26);
            this.txtThemTenGV.TabIndex = 130;
            // 
            // txtThemDiaChi
            // 
            this.txtThemDiaChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThemDiaChi.Location = new System.Drawing.Point(537, 139);
            this.txtThemDiaChi.Name = "txtThemDiaChi";
            this.txtThemDiaChi.Size = new System.Drawing.Size(233, 26);
            this.txtThemDiaChi.TabIndex = 128;
            // 
            // lblThemDiaChi
            // 
            this.lblThemDiaChi.AutoSize = true;
            this.lblThemDiaChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemDiaChi.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemDiaChi.Location = new System.Drawing.Point(409, 139);
            this.lblThemDiaChi.Name = "lblThemDiaChi";
            this.lblThemDiaChi.Size = new System.Drawing.Size(61, 19);
            this.lblThemDiaChi.TabIndex = 127;
            this.lblThemDiaChi.Text = "Địa chỉ";
            // 
            // cboThemTrinhDo
            // 
            this.cboThemTrinhDo.DisplayMember = "Text";
            this.cboThemTrinhDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThemTrinhDo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThemTrinhDo.FormattingEnabled = true;
            this.cboThemTrinhDo.ItemHeight = 21;
            this.cboThemTrinhDo.Location = new System.Drawing.Point(158, 138);
            this.cboThemTrinhDo.Name = "cboThemTrinhDo";
            this.cboThemTrinhDo.Size = new System.Drawing.Size(224, 27);
            this.cboThemTrinhDo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThemTrinhDo.TabIndex = 126;
            // 
            // txtThemSDT
            // 
            this.txtThemSDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThemSDT.Location = new System.Drawing.Point(537, 86);
            this.txtThemSDT.Name = "txtThemSDT";
            this.txtThemSDT.Size = new System.Drawing.Size(233, 26);
            this.txtThemSDT.TabIndex = 125;
            // 
            // lblThemSDT
            // 
            this.lblThemSDT.AutoSize = true;
            this.lblThemSDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemSDT.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemSDT.Location = new System.Drawing.Point(409, 86);
            this.lblThemSDT.Name = "lblThemSDT";
            this.lblThemSDT.Size = new System.Drawing.Size(106, 19);
            this.lblThemSDT.TabIndex = 124;
            this.lblThemSDT.Text = "Số điện thoại";
            // 
            // lblThemTrinhDo
            // 
            this.lblThemTrinhDo.AutoSize = true;
            this.lblThemTrinhDo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemTrinhDo.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemTrinhDo.Location = new System.Drawing.Point(14, 138);
            this.lblThemTrinhDo.Name = "lblThemTrinhDo";
            this.lblThemTrinhDo.Size = new System.Drawing.Size(73, 19);
            this.lblThemTrinhDo.TabIndex = 123;
            this.lblThemTrinhDo.Text = "Trình độ";
            // 
            // dtiNamSinh
            // 
            // 
            // 
            // 
            this.dtiNamSinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNamSinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNamSinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNamSinh.ButtonDropDown.Visible = true;
            this.dtiNamSinh.CustomFormat = "dd/MM/yyyy";
            this.dtiNamSinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtiNamSinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtiNamSinh.IsPopupCalendarOpen = false;
            this.dtiNamSinh.Location = new System.Drawing.Point(158, 86);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtiNamSinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNamSinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNamSinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNamSinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNamSinh.MonthCalendar.DisplayMonth = new System.DateTime(2019, 11, 3, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtiNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNamSinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNamSinh.MonthCalendar.TodayButtonVisible = true;
            this.dtiNamSinh.Name = "dtiNamSinh";
            this.dtiNamSinh.Size = new System.Drawing.Size(224, 26);
            this.dtiNamSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNamSinh.TabIndex = 122;
            // 
            // lblThemNamSinh
            // 
            this.lblThemNamSinh.AutoSize = true;
            this.lblThemNamSinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemNamSinh.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemNamSinh.Location = new System.Drawing.Point(14, 89);
            this.lblThemNamSinh.Name = "lblThemNamSinh";
            this.lblThemNamSinh.Size = new System.Drawing.Size(79, 19);
            this.lblThemNamSinh.TabIndex = 121;
            this.lblThemNamSinh.Text = "Năm sinh";
            // 
            // lblThemMaGV
            // 
            this.lblThemMaGV.AutoSize = true;
            this.lblThemMaGV.Location = new System.Drawing.Point(14, 43);
            this.lblThemMaGV.Name = "lblThemMaGV";
            this.lblThemMaGV.Size = new System.Drawing.Size(111, 19);
            this.lblThemMaGV.TabIndex = 93;
            this.lblThemMaGV.Text = "Mã giảng viên";
            // 
            // txtThemMaGV
            // 
            this.txtThemMaGV.Location = new System.Drawing.Point(158, 36);
            this.txtThemMaGV.Name = "txtThemMaGV";
            this.txtThemMaGV.Size = new System.Drawing.Size(224, 26);
            this.txtThemMaGV.TabIndex = 94;
            // 
            // cboTenGV
            // 
            this.cboTenGV.DisplayMember = "Text";
            this.cboTenGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenGV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTenGV.FormattingEnabled = true;
            this.cboTenGV.ItemHeight = 21;
            this.cboTenGV.Location = new System.Drawing.Point(219, 9);
            this.cboTenGV.Name = "cboTenGV";
            this.cboTenGV.Size = new System.Drawing.Size(201, 27);
            this.cboTenGV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTenGV.TabIndex = 122;
            this.cboTenGV.SelectedIndexChanged += new System.EventHandler(this.cboTenGV_SelectedIndexChanged);
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.DisplayMember = "Text";
            this.cboTrinhDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrinhDo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.ItemHeight = 21;
            this.cboTrinhDo.Location = new System.Drawing.Point(219, 55);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(201, 27);
            this.cboTrinhDo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTrinhDo.TabIndex = 121;
            // 
            // txtNamSinh
            // 
            // 
            // 
            // 
            this.txtNamSinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNamSinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamSinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtNamSinh.ButtonDropDown.Visible = true;
            this.txtNamSinh.CustomFormat = "dd/MM/yyyy";
            this.txtNamSinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNamSinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtNamSinh.IsPopupCalendarOpen = false;
            this.txtNamSinh.Location = new System.Drawing.Point(575, 6);
            // 
            // 
            // 
            // 
            // 
            // 
            this.txtNamSinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamSinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtNamSinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtNamSinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamSinh.MonthCalendar.DisplayMonth = new System.DateTime(2019, 11, 3, 0, 0, 0, 0);
            // 
            // 
            // 
            this.txtNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNamSinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtNamSinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamSinh.MonthCalendar.TodayButtonVisible = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(233, 26);
            this.txtNamSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtNamSinh.TabIndex = 120;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDienThoai.Location = new System.Drawing.Point(575, 52);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(233, 26);
            this.txtDienThoai.TabIndex = 119;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.Color.Maroon;
            this.lblSDT.Location = new System.Drawing.Point(447, 55);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 19);
            this.lblSDT.TabIndex = 118;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(219, 99);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(589, 26);
            this.txtDiaChi.TabIndex = 117;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNamSinh.ForeColor = System.Drawing.Color.Maroon;
            this.lblNamSinh.Location = new System.Drawing.Point(447, 9);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(79, 19);
            this.lblNamSinh.TabIndex = 116;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiaChi.Location = new System.Drawing.Point(59, 102);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(61, 19);
            this.lblDiaChi.TabIndex = 115;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTrinhDo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTrinhDo.Location = new System.Drawing.Point(59, 55);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(73, 19);
            this.lblTrinhDo.TabIndex = 114;
            this.lblTrinhDo.Text = "Trình độ";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenGV.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenGV.Location = new System.Drawing.Point(59, 9);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(115, 19);
            this.lblTenGV.TabIndex = 113;
            this.lblTenGV.Text = "Tên giảng viên";
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.TENGV,
            this.NAMSINH,
            this.DIACHI,
            this.SDT,
            this.TRINHDO});
            this.dgvGiangVien.Location = new System.Drawing.Point(10, 360);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.Size = new System.Drawing.Size(825, 320);
            this.dgvGiangVien.TabIndex = 89;
            this.dgvGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellClick);
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã GV";
            this.MAGV.MinimumWidth = 6;
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            this.MAGV.Width = 125;
            // 
            // TENGV
            // 
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "Tên GV";
            this.TENGV.MinimumWidth = 6;
            this.TENGV.Name = "TENGV";
            this.TENGV.ReadOnly = true;
            this.TENGV.Width = 200;
            // 
            // NAMSINH
            // 
            this.NAMSINH.DataPropertyName = "NAMSINH";
            this.NAMSINH.HeaderText = "Năm Sinh";
            this.NAMSINH.MinimumWidth = 6;
            this.NAMSINH.Name = "NAMSINH";
            this.NAMSINH.ReadOnly = true;
            this.NAMSINH.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 170;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // TRINHDO
            // 
            this.TRINHDO.DataPropertyName = "TRINHDO";
            this.TRINHDO.HeaderText = "Trình Độ";
            this.TRINHDO.MinimumWidth = 6;
            this.TRINHDO.Name = "TRINHDO";
            this.TRINHDO.ReadOnly = true;
            this.TRINHDO.Width = 150;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1063, 788);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            this.gbThemGiangVien.ResumeLayout(false);
            this.gbThemGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlTitle;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        protected internal System.Windows.Forms.PictureBox pictureExit;
        private DevComponents.DotNetBar.PanelEx pnlNoiDung;
        public System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRINHDO;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTenGV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTrinhDo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtNamSinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblTenGV;
        private DevComponents.DotNetBar.ButtonX btnThemGiangVienMoi;
        private System.Windows.Forms.GroupBox gbThemGiangVien;
        private System.Windows.Forms.Label lblThemMaGV;
        private System.Windows.Forms.TextBox txtThemMaGV;
        private System.Windows.Forms.TextBox txtThemDiaChi;
        private System.Windows.Forms.Label lblThemDiaChi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThemTrinhDo;
        private System.Windows.Forms.TextBox txtThemSDT;
        private System.Windows.Forms.Label lblThemSDT;
        private System.Windows.Forms.Label lblThemTrinhDo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNamSinh;
        private System.Windows.Forms.Label lblThemNamSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThemTenGV;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}
namespace GUI
{
    partial class frmKhoaHoc
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
            this.btnSua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitile = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOILUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGHVTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGHVTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNoiDung = new DevComponents.DotNetBar.PanelEx();
            this.btnThemKhoaHocMoi = new DevComponents.DotNetBar.ButtonX();
            this.gbThemKhoaHoc = new System.Windows.Forms.GroupBox();
            this.cboThemSLHVTT = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblThemSLHVTT = new System.Windows.Forms.Label();
            this.cboThemSLHVTD = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblThemSLHVTD = new System.Windows.Forms.Label();
            this.cboThemTL = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblThemSoLuong = new System.Windows.Forms.Label();
            this.lblThemKhoaHoc = new System.Windows.Forms.Label();
            this.txtThemKH = new System.Windows.Forms.TextBox();
            this.cboSLHVToiThieu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboSLHVToiDa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboThoiLuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboTenKH = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblSLHVToiThieu = new System.Windows.Forms.Label();
            this.lblSLHVToiDa = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlTitile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.pnlNoiDung.SuspendLayout();
            this.gbThemKhoaHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSua.Location = new System.Drawing.Point(25, 516);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 60);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.zenitsumoon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlButton.Controls.Add(this.pictureBox1);
            this.pnlButton.Controls.Add(this.btnTimKiem);
            this.pnlButton.Controls.Add(this.btnSua);
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnThem);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(216, 788);
            this.pnlButton.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(25, 604);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(25, 428);
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
            this.btnThem.Location = new System.Drawing.Point(25, 340);
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
            // pnlTitile
            // 
            this.pnlTitile.Controls.Add(this.reflectionLabel1);
            this.pnlTitile.Controls.Add(this.pictureExit);
            this.pnlTitile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitile.Location = new System.Drawing.Point(216, 0);
            this.pnlTitile.Name = "pnlTitile";
            this.pnlTitile.Size = new System.Drawing.Size(752, 86);
            this.pnlTitile.TabIndex = 66;
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
            this.reflectionLabel1.Size = new System.Drawing.Size(662, 86);
            this.reflectionLabel1.TabIndex = 66;
            this.reflectionLabel1.Text = "<div align=\"center\"><b><font size=\"+18\" color=\"#adff2f\"><i> KHÓA </i><font> HỌC</" +
    "font></font></b></div>";
            // 
            // pictureExit
            // 
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(662, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 13;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.THOILUONG,
            this.SOLUONGHVTD,
            this.SOLUONGHVTT});
            this.dgvKhoaHoc.Location = new System.Drawing.Point(17, 320);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.RowHeadersWidth = 51;
            this.dgvKhoaHoc.RowTemplate.Height = 24;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(718, 370);
            this.dgvKhoaHoc.TabIndex = 54;
            this.dgvKhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoaHoc_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 125;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            this.TENKH.Width = 200;
            // 
            // THOILUONG
            // 
            this.THOILUONG.DataPropertyName = "THOILUONG";
            this.THOILUONG.HeaderText = "Thời Lượng";
            this.THOILUONG.MinimumWidth = 6;
            this.THOILUONG.Name = "THOILUONG";
            this.THOILUONG.ReadOnly = true;
            this.THOILUONG.Width = 150;
            // 
            // SOLUONGHVTD
            // 
            this.SOLUONGHVTD.DataPropertyName = "SOLUONGHVTD";
            this.SOLUONGHVTD.HeaderText = "SL Học Viên TD";
            this.SOLUONGHVTD.MinimumWidth = 6;
            this.SOLUONGHVTD.Name = "SOLUONGHVTD";
            this.SOLUONGHVTD.ReadOnly = true;
            this.SOLUONGHVTD.Width = 170;
            // 
            // SOLUONGHVTT
            // 
            this.SOLUONGHVTT.DataPropertyName = "SOLUONGHVTT";
            this.SOLUONGHVTT.HeaderText = "SL Học Viên TT";
            this.SOLUONGHVTT.MinimumWidth = 6;
            this.SOLUONGHVTT.Name = "SOLUONGHVTT";
            this.SOLUONGHVTT.ReadOnly = true;
            this.SOLUONGHVTT.Width = 170;
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNoiDung.Controls.Add(this.btnThemKhoaHocMoi);
            this.pnlNoiDung.Controls.Add(this.gbThemKhoaHoc);
            this.pnlNoiDung.Controls.Add(this.cboSLHVToiThieu);
            this.pnlNoiDung.Controls.Add(this.cboSLHVToiDa);
            this.pnlNoiDung.Controls.Add(this.cboThoiLuong);
            this.pnlNoiDung.Controls.Add(this.cboTenKH);
            this.pnlNoiDung.Controls.Add(this.lblThoiLuong);
            this.pnlNoiDung.Controls.Add(this.lblSLHVToiThieu);
            this.pnlNoiDung.Controls.Add(this.lblSLHVToiDa);
            this.pnlNoiDung.Controls.Add(this.lblTenKH);
            this.pnlNoiDung.Controls.Add(this.dgvKhoaHoc);
            this.pnlNoiDung.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(216, 86);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(752, 702);
            this.pnlNoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNoiDung.Style.GradientAngle = 90;
            this.pnlNoiDung.TabIndex = 77;
            // 
            // btnThemKhoaHocMoi
            // 
            this.btnThemKhoaHocMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKhoaHocMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnThemKhoaHocMoi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKhoaHocMoi.Location = new System.Drawing.Point(304, 120);
            this.btnThemKhoaHocMoi.Name = "btnThemKhoaHocMoi";
            this.btnThemKhoaHocMoi.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.btnThemKhoaHocMoi.Size = new System.Drawing.Size(176, 42);
            this.btnThemKhoaHocMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemKhoaHocMoi.TabIndex = 96;
            this.btnThemKhoaHocMoi.Text = "Khóa học mới";
            this.btnThemKhoaHocMoi.Click += new System.EventHandler(this.btnThemKhoaHocMoi_Click);
            // 
            // gbThemKhoaHoc
            // 
            this.gbThemKhoaHoc.Controls.Add(this.cboThemSLHVTT);
            this.gbThemKhoaHoc.Controls.Add(this.lblThemSLHVTT);
            this.gbThemKhoaHoc.Controls.Add(this.cboThemSLHVTD);
            this.gbThemKhoaHoc.Controls.Add(this.lblThemSLHVTD);
            this.gbThemKhoaHoc.Controls.Add(this.cboThemTL);
            this.gbThemKhoaHoc.Controls.Add(this.lblThemSoLuong);
            this.gbThemKhoaHoc.Controls.Add(this.lblThemKhoaHoc);
            this.gbThemKhoaHoc.Controls.Add(this.txtThemKH);
            this.gbThemKhoaHoc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThemKhoaHoc.ForeColor = System.Drawing.Color.DarkViolet;
            this.gbThemKhoaHoc.Location = new System.Drawing.Point(8, 168);
            this.gbThemKhoaHoc.Name = "gbThemKhoaHoc";
            this.gbThemKhoaHoc.Size = new System.Drawing.Size(732, 146);
            this.gbThemKhoaHoc.TabIndex = 95;
            this.gbThemKhoaHoc.TabStop = false;
            this.gbThemKhoaHoc.Text = "Khóa học mới";
            // 
            // cboThemSLHVTT
            // 
            this.cboThemSLHVTT.DisplayMember = "Text";
            this.cboThemSLHVTT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThemSLHVTT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThemSLHVTT.FormattingEnabled = true;
            this.cboThemSLHVTT.ItemHeight = 21;
            this.cboThemSLHVTT.Location = new System.Drawing.Point(612, 90);
            this.cboThemSLHVTT.Name = "cboThemSLHVTT";
            this.cboThemSLHVTT.Size = new System.Drawing.Size(114, 27);
            this.cboThemSLHVTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThemSLHVTT.TabIndex = 100;
            // 
            // lblThemSLHVTT
            // 
            this.lblThemSLHVTT.AutoSize = true;
            this.lblThemSLHVTT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemSLHVTT.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemSLHVTT.Location = new System.Drawing.Point(376, 98);
            this.lblThemSLHVTT.Name = "lblThemSLHVTT";
            this.lblThemSLHVTT.Size = new System.Drawing.Size(208, 19);
            this.lblThemSLHVTT.TabIndex = 99;
            this.lblThemSLHVTT.Text = "Số lượng học viên tối thiểu";
            // 
            // cboThemSLHVTD
            // 
            this.cboThemSLHVTD.DisplayMember = "Text";
            this.cboThemSLHVTD.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThemSLHVTD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThemSLHVTD.FormattingEnabled = true;
            this.cboThemSLHVTD.ItemHeight = 21;
            this.cboThemSLHVTD.Location = new System.Drawing.Point(222, 90);
            this.cboThemSLHVTD.Name = "cboThemSLHVTD";
            this.cboThemSLHVTD.Size = new System.Drawing.Size(121, 27);
            this.cboThemSLHVTD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThemSLHVTD.TabIndex = 98;
            // 
            // lblThemSLHVTD
            // 
            this.lblThemSLHVTD.AutoSize = true;
            this.lblThemSLHVTD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemSLHVTD.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemSLHVTD.Location = new System.Drawing.Point(14, 98);
            this.lblThemSLHVTD.Name = "lblThemSLHVTD";
            this.lblThemSLHVTD.Size = new System.Drawing.Size(188, 19);
            this.lblThemSLHVTD.TabIndex = 97;
            this.lblThemSLHVTD.Text = "Số lượng học viên tối đa";
            // 
            // cboThemTL
            // 
            this.cboThemTL.DisplayMember = "Text";
            this.cboThemTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThemTL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThemTL.FormattingEnabled = true;
            this.cboThemTL.ItemHeight = 21;
            this.cboThemTL.Location = new System.Drawing.Point(612, 36);
            this.cboThemTL.Name = "cboThemTL";
            this.cboThemTL.Size = new System.Drawing.Size(114, 27);
            this.cboThemTL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThemTL.TabIndex = 96;
            // 
            // lblThemSoLuong
            // 
            this.lblThemSoLuong.AutoSize = true;
            this.lblThemSoLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThemSoLuong.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblThemSoLuong.Location = new System.Drawing.Point(490, 43);
            this.lblThemSoLuong.Name = "lblThemSoLuong";
            this.lblThemSoLuong.Size = new System.Drawing.Size(94, 19);
            this.lblThemSoLuong.TabIndex = 95;
            this.lblThemSoLuong.Text = "Thời lượng";
            // 
            // lblThemKhoaHoc
            // 
            this.lblThemKhoaHoc.AutoSize = true;
            this.lblThemKhoaHoc.Location = new System.Drawing.Point(14, 39);
            this.lblThemKhoaHoc.Name = "lblThemKhoaHoc";
            this.lblThemKhoaHoc.Size = new System.Drawing.Size(108, 19);
            this.lblThemKhoaHoc.TabIndex = 93;
            this.lblThemKhoaHoc.Text = "Tên khóa học";
            // 
            // txtThemKH
            // 
            this.txtThemKH.Location = new System.Drawing.Point(158, 36);
            this.txtThemKH.Name = "txtThemKH";
            this.txtThemKH.Size = new System.Drawing.Size(193, 26);
            this.txtThemKH.TabIndex = 94;
            // 
            // cboSLHVToiThieu
            // 
            this.cboSLHVToiThieu.DisplayMember = "Text";
            this.cboSLHVToiThieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSLHVToiThieu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSLHVToiThieu.FormattingEnabled = true;
            this.cboSLHVToiThieu.ItemHeight = 21;
            this.cboSLHVToiThieu.Location = new System.Drawing.Point(621, 80);
            this.cboSLHVToiThieu.Name = "cboSLHVToiThieu";
            this.cboSLHVToiThieu.Size = new System.Drawing.Size(114, 27);
            this.cboSLHVToiThieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSLHVToiThieu.TabIndex = 92;
            // 
            // cboSLHVToiDa
            // 
            this.cboSLHVToiDa.DisplayMember = "Text";
            this.cboSLHVToiDa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSLHVToiDa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSLHVToiDa.FormattingEnabled = true;
            this.cboSLHVToiDa.ItemHeight = 21;
            this.cboSLHVToiDa.Location = new System.Drawing.Point(231, 80);
            this.cboSLHVToiDa.Name = "cboSLHVToiDa";
            this.cboSLHVToiDa.Size = new System.Drawing.Size(121, 27);
            this.cboSLHVToiDa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSLHVToiDa.TabIndex = 91;
            // 
            // cboThoiLuong
            // 
            this.cboThoiLuong.DisplayMember = "Text";
            this.cboThoiLuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThoiLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboThoiLuong.FormattingEnabled = true;
            this.cboThoiLuong.ItemHeight = 21;
            this.cboThoiLuong.Location = new System.Drawing.Point(621, 25);
            this.cboThoiLuong.Name = "cboThoiLuong";
            this.cboThoiLuong.Size = new System.Drawing.Size(114, 27);
            this.cboThoiLuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboThoiLuong.TabIndex = 90;
            // 
            // cboTenKH
            // 
            this.cboTenKH.DisplayMember = "Text";
            this.cboTenKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenKH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTenKH.FormattingEnabled = true;
            this.cboTenKH.ItemHeight = 21;
            this.cboTenKH.Location = new System.Drawing.Point(141, 24);
            this.cboTenKH.Name = "cboTenKH";
            this.cboTenKH.Size = new System.Drawing.Size(323, 27);
            this.cboTenKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTenKH.TabIndex = 89;
            this.cboTenKH.SelectedIndexChanged += new System.EventHandler(this.cboTenKH_SelectedIndexChanged);
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThoiLuong.ForeColor = System.Drawing.Color.Maroon;
            this.lblThoiLuong.Location = new System.Drawing.Point(499, 28);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(94, 19);
            this.lblThoiLuong.TabIndex = 88;
            this.lblThoiLuong.Text = "Thời lượng";
            // 
            // lblSLHVToiThieu
            // 
            this.lblSLHVToiThieu.AutoSize = true;
            this.lblSLHVToiThieu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSLHVToiThieu.ForeColor = System.Drawing.Color.Maroon;
            this.lblSLHVToiThieu.Location = new System.Drawing.Point(385, 83);
            this.lblSLHVToiThieu.Name = "lblSLHVToiThieu";
            this.lblSLHVToiThieu.Size = new System.Drawing.Size(208, 19);
            this.lblSLHVToiThieu.TabIndex = 87;
            this.lblSLHVToiThieu.Text = "Số lượng học viên tối thiểu";
            // 
            // lblSLHVToiDa
            // 
            this.lblSLHVToiDa.AutoSize = true;
            this.lblSLHVToiDa.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSLHVToiDa.ForeColor = System.Drawing.Color.Maroon;
            this.lblSLHVToiDa.Location = new System.Drawing.Point(12, 83);
            this.lblSLHVToiDa.Name = "lblSLHVToiDa";
            this.lblSLHVToiDa.Size = new System.Drawing.Size(188, 19);
            this.lblSLHVToiDa.TabIndex = 86;
            this.lblSLHVToiDa.Text = "Số lượng học viên tối đa";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKH.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenKH.Location = new System.Drawing.Point(13, 28);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(108, 19);
            this.lblTenKH.TabIndex = 85;
            this.lblTenKH.Text = "Tên khóa học";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(968, 788);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTitile);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoaHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhoaHoc";
            this.Load += new System.EventHandler(this.frmKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlTitile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            this.gbThemKhoaHoc.ResumeLayout(false);
            this.gbThemKhoaHoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlTitile;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        protected internal System.Windows.Forms.PictureBox pictureExit;
        private DevComponents.DotNetBar.PanelEx pnlNoiDung;
        public System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOILUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGHVTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGHVTT;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSLHVToiThieu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSLHVToiDa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThoiLuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTenKH;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblSLHVToiThieu;
        private System.Windows.Forms.Label lblSLHVToiDa;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.GroupBox gbThemKhoaHoc;
        private System.Windows.Forms.Label lblThemKhoaHoc;
        private System.Windows.Forms.TextBox txtThemKH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThemSLHVTT;
        private System.Windows.Forms.Label lblThemSLHVTT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThemSLHVTD;
        private System.Windows.Forms.Label lblThemSLHVTD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboThemTL;
        private System.Windows.Forms.Label lblThemSoLuong;
        private DevComponents.DotNetBar.ButtonX btnThemKhoaHocMoi;
    }
}
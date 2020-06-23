namespace GUI
{
    partial class frmLopHoc
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
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.pnlHocVien = new System.Windows.Forms.Panel();
            this.btnTuyChon = new XanderUI.XUIButton();
            this.lblDotKhaiGiang = new System.Windows.Forms.Label();
            this.cboDotKhaiGiang = new System.Windows.Forms.ComboBox();
            this.chkMoLop = new System.Windows.Forms.CheckBox();
            this.mtxtNgayKetThuc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNgayKhaiGiang = new System.Windows.Forms.MaskedTextBox();
            this.lstvThongTin = new System.Windows.Forms.ListView();
            this.MALH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAGV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIETHOC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LICHKHAIGIANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LICHKETTHUC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINHTRANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLichKetThuc = new System.Windows.Forms.Label();
            this.lblLichKhaiGiang = new System.Windows.Forms.Label();
            this.lblTietHoc = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.lblMaPH = new System.Windows.Forms.Label();
            this.cboTietHoc = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboGiaoVien = new System.Windows.Forms.ComboBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cboPhongHoc = new System.Windows.Forms.ComboBox();
            this.lblMaLopHoc = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.pnlHocVien.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkingArea
            // 
            this.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(1052, 633);
            this.WorkingArea.TabIndex = 0;
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.MacOS;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = false;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1063, 705);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "Class";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.pnlHocVien);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.pnlButton);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 39);
            this.xuiFormDesign1.WorkingArea.Margin = new System.Windows.Forms.Padding(4);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1063, 666);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            this.xuiFormDesign1.Paint += new System.Windows.Forms.PaintEventHandler(this.xuiFormDesign1_Paint);
            // 
            // pnlHocVien
            // 
            this.pnlHocVien.BackColor = System.Drawing.Color.LightGray;
            this.pnlHocVien.Controls.Add(this.btnTuyChon);
            this.pnlHocVien.Controls.Add(this.lblDotKhaiGiang);
            this.pnlHocVien.Controls.Add(this.cboDotKhaiGiang);
            this.pnlHocVien.Controls.Add(this.chkMoLop);
            this.pnlHocVien.Controls.Add(this.mtxtNgayKetThuc);
            this.pnlHocVien.Controls.Add(this.mtxtNgayKhaiGiang);
            this.pnlHocVien.Controls.Add(this.lstvThongTin);
            this.pnlHocVien.Controls.Add(this.lblLichKetThuc);
            this.pnlHocVien.Controls.Add(this.lblLichKhaiGiang);
            this.pnlHocVien.Controls.Add(this.lblTietHoc);
            this.pnlHocVien.Controls.Add(this.txtSoLuong);
            this.pnlHocVien.Controls.Add(this.lblSoLuong);
            this.pnlHocVien.Controls.Add(this.lblMaGV);
            this.pnlHocVien.Controls.Add(this.lblMaKH);
            this.pnlHocVien.Controls.Add(this.lblTinhTrang);
            this.pnlHocVien.Controls.Add(this.lblMaPH);
            this.pnlHocVien.Controls.Add(this.cboTietHoc);
            this.pnlHocVien.Controls.Add(this.cboTinhTrang);
            this.pnlHocVien.Controls.Add(this.cboGiaoVien);
            this.pnlHocVien.Controls.Add(this.cboLopHoc);
            this.pnlHocVien.Controls.Add(this.cboKhoaHoc);
            this.pnlHocVien.Controls.Add(this.cboPhongHoc);
            this.pnlHocVien.Controls.Add(this.lblMaLopHoc);
            this.pnlHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHocVien.Location = new System.Drawing.Point(216, 0);
            this.pnlHocVien.Name = "pnlHocVien";
            this.pnlHocVien.Size = new System.Drawing.Size(847, 666);
            this.pnlHocVien.TabIndex = 20;
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btnTuyChon.ButtonImage = null;
            this.btnTuyChon.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTuyChon.ButtonText = "...";
            this.btnTuyChon.ClickBackColor = System.Drawing.Color.Black;
            this.btnTuyChon.ClickTextColor = System.Drawing.Color.Black;
            this.btnTuyChon.CornerRadius = 5;
            this.btnTuyChon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyChon.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTuyChon.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnTuyChon.HoverTextColor = System.Drawing.Color.Red;
            this.btnTuyChon.ImagePosition = XanderUI.XUIButton.imgPosition.Right;
            this.btnTuyChon.Location = new System.Drawing.Point(709, 253);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(114, 31);
            this.btnTuyChon.TabIndex = 22;
            this.btnTuyChon.TextColor = System.Drawing.Color.Black;
            this.btnTuyChon.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // lblDotKhaiGiang
            // 
            this.lblDotKhaiGiang.AutoSize = true;
            this.lblDotKhaiGiang.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotKhaiGiang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDotKhaiGiang.Location = new System.Drawing.Point(16, 254);
            this.lblDotKhaiGiang.Name = "lblDotKhaiGiang";
            this.lblDotKhaiGiang.Size = new System.Drawing.Size(178, 28);
            this.lblDotKhaiGiang.TabIndex = 21;
            this.lblDotKhaiGiang.Text = "Đợt Khai Giảng";
            // 
            // cboDotKhaiGiang
            // 
            this.cboDotKhaiGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDotKhaiGiang.FormattingEnabled = true;
            this.cboDotKhaiGiang.Items.AddRange(new object[] {
            "CÒN",
            "Hết Chỗ"});
            this.cboDotKhaiGiang.Location = new System.Drawing.Point(205, 253);
            this.cboDotKhaiGiang.Name = "cboDotKhaiGiang";
            this.cboDotKhaiGiang.Size = new System.Drawing.Size(493, 31);
            this.cboDotKhaiGiang.TabIndex = 20;
            this.cboDotKhaiGiang.SelectedIndexChanged += new System.EventHandler(this.cboDotKhaiGiang_SelectedIndexChanged);
            // 
            // chkMoLop
            // 
            this.chkMoLop.AutoSize = true;
            this.chkMoLop.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.chkMoLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chkMoLop.Location = new System.Drawing.Point(711, 163);
            this.chkMoLop.Name = "chkMoLop";
            this.chkMoLop.Size = new System.Drawing.Size(118, 32);
            this.chkMoLop.TabIndex = 19;
            this.chkMoLop.Text = "Mở Lớp";
            this.chkMoLop.UseVisualStyleBackColor = true;
            // 
            // mtxtNgayKetThuc
            // 
            this.mtxtNgayKetThuc.Location = new System.Drawing.Point(557, 204);
            this.mtxtNgayKetThuc.Mask = "00/00/0000";
            this.mtxtNgayKetThuc.Name = "mtxtNgayKetThuc";
            this.mtxtNgayKetThuc.Size = new System.Drawing.Size(272, 31);
            this.mtxtNgayKetThuc.TabIndex = 18;
            // 
            // mtxtNgayKhaiGiang
            // 
            this.mtxtNgayKhaiGiang.Location = new System.Drawing.Point(175, 204);
            this.mtxtNgayKhaiGiang.Mask = "00/00/0000";
            this.mtxtNgayKhaiGiang.Name = "mtxtNgayKhaiGiang";
            this.mtxtNgayKhaiGiang.Size = new System.Drawing.Size(243, 31);
            this.mtxtNgayKhaiGiang.TabIndex = 18;
            // 
            // lstvThongTin
            // 
            this.lstvThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MALH,
            this.MAPH,
            this.MAKH,
            this.MAGV,
            this.TIETHOC,
            this.LICHKHAIGIANG,
            this.LICHKETTHUC,
            this.TINHTRANG,
            this.SOLUONG});
            this.lstvThongTin.ContextMenuStrip = this.contextMenuStrip1;
            this.lstvThongTin.FullRowSelect = true;
            this.lstvThongTin.GridLines = true;
            this.lstvThongTin.HideSelection = false;
            this.lstvThongTin.Location = new System.Drawing.Point(21, 305);
            this.lstvThongTin.Name = "lstvThongTin";
            this.lstvThongTin.Size = new System.Drawing.Size(808, 332);
            this.lstvThongTin.TabIndex = 17;
            this.lstvThongTin.UseCompatibleStateImageBehavior = false;
            this.lstvThongTin.View = System.Windows.Forms.View.Details;
            this.lstvThongTin.SelectedIndexChanged += new System.EventHandler(this.lstvThongTin_SelectedIndexChanged);
            // 
            // MALH
            // 
            this.MALH.Text = "Mã LH";
            this.MALH.Width = 80;
            // 
            // MAPH
            // 
            this.MAPH.Text = "Tên Phòng Học";
            this.MAPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MAPH.Width = 164;
            // 
            // MAKH
            // 
            this.MAKH.Text = "Tên Khóa Học";
            this.MAKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MAKH.Width = 275;
            // 
            // MAGV
            // 
            this.MAGV.Text = "Tên Giáo Viên";
            this.MAGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MAGV.Width = 200;
            // 
            // TIETHOC
            // 
            this.TIETHOC.Text = "Tiết Học";
            this.TIETHOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TIETHOC.Width = 150;
            // 
            // LICHKHAIGIANG
            // 
            this.LICHKHAIGIANG.DisplayIndex = 7;
            this.LICHKHAIGIANG.Text = "Lịch Khai Giảng";
            this.LICHKHAIGIANG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LICHKHAIGIANG.Width = 150;
            // 
            // LICHKETTHUC
            // 
            this.LICHKETTHUC.DisplayIndex = 8;
            this.LICHKETTHUC.Text = "Lịch Kết Thúc";
            this.LICHKETTHUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LICHKETTHUC.Width = 150;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DisplayIndex = 5;
            this.TINHTRANG.Text = "Tình Trạng";
            this.TINHTRANG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TINHTRANG.Width = 150;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DisplayIndex = 6;
            this.SOLUONG.Text = "Số Lượng";
            this.SOLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // lblLichKetThuc
            // 
            this.lblLichKetThuc.AutoSize = true;
            this.lblLichKetThuc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichKetThuc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLichKetThuc.Location = new System.Drawing.Point(441, 205);
            this.lblLichKetThuc.Name = "lblLichKetThuc";
            this.lblLichKetThuc.Size = new System.Drawing.Size(109, 28);
            this.lblLichKetThuc.TabIndex = 15;
            this.lblLichKetThuc.Text = "Kết Thúc";
            // 
            // lblLichKhaiGiang
            // 
            this.lblLichKhaiGiang.AutoSize = true;
            this.lblLichKhaiGiang.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichKhaiGiang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLichKhaiGiang.Location = new System.Drawing.Point(16, 205);
            this.lblLichKhaiGiang.Name = "lblLichKhaiGiang";
            this.lblLichKhaiGiang.Size = new System.Drawing.Size(131, 28);
            this.lblLichKhaiGiang.TabIndex = 15;
            this.lblLichKhaiGiang.Text = "Khai Giảng";
            // 
            // lblTietHoc
            // 
            this.lblTietHoc.AutoSize = true;
            this.lblTietHoc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTietHoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTietHoc.Location = new System.Drawing.Point(441, 116);
            this.lblTietHoc.Name = "lblTietHoc";
            this.lblTietHoc.Size = new System.Drawing.Size(104, 28);
            this.lblTietHoc.TabIndex = 13;
            this.lblTietHoc.Text = "Tiết Học";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(557, 160);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(127, 31);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSoLuong.Location = new System.Drawing.Point(441, 161);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(115, 28);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaGV.Location = new System.Drawing.Point(16, 116);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(118, 28);
            this.lblMaGV.TabIndex = 9;
            this.lblMaGV.Text = "Giáo Viên";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaKH.Location = new System.Drawing.Point(16, 67);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(116, 28);
            this.lblMaKH.TabIndex = 6;
            this.lblMaKH.Text = "Khóa Học";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTinhTrang.Location = new System.Drawing.Point(16, 161);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(132, 28);
            this.lblTinhTrang.TabIndex = 5;
            this.lblTinhTrang.Text = "Tình Trạng";
            // 
            // lblMaPH
            // 
            this.lblMaPH.AutoSize = true;
            this.lblMaPH.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaPH.Location = new System.Drawing.Point(441, 21);
            this.lblMaPH.Name = "lblMaPH";
            this.lblMaPH.Size = new System.Drawing.Size(128, 28);
            this.lblMaPH.TabIndex = 4;
            this.lblMaPH.Text = "Phòng Học";
            // 
            // cboTietHoc
            // 
            this.cboTietHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTietHoc.FormattingEnabled = true;
            this.cboTietHoc.Items.AddRange(new object[] {
            "9h - 11h (3,5,7)",
            "14h - 16h (2,4,6)",
            "17h - 19h (2,4,6)",
            "19h - 21h (3,5,7)",
            "9h - 11h (2,4,6)",
            "7h - 9h (3,5,7)",
            "19h - 21h (2,4,6)",
            "17h - 19h (3,5,7)",
            "9h - 11h (2,4,6)",
            "7h - 9h (2,4,6)",
            "17h - 19h (2,4,6)",
            "14h - 16h (3,5,7)"});
            this.cboTietHoc.Location = new System.Drawing.Point(557, 115);
            this.cboTietHoc.Name = "cboTietHoc";
            this.cboTietHoc.Size = new System.Drawing.Size(272, 31);
            this.cboTietHoc.TabIndex = 3;
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "CÒN",
            "Hết Chỗ"});
            this.cboTinhTrang.Location = new System.Drawing.Point(175, 160);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(243, 31);
            this.cboTinhTrang.TabIndex = 3;
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.Location = new System.Drawing.Point(175, 115);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(243, 31);
            this.cboGiaoVien.TabIndex = 3;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(175, 20);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(243, 31);
            this.cboLopHoc.TabIndex = 3;
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(175, 67);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(654, 31);
            this.cboKhoaHoc.TabIndex = 3;
            // 
            // cboPhongHoc
            // 
            this.cboPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongHoc.FormattingEnabled = true;
            this.cboPhongHoc.Location = new System.Drawing.Point(557, 18);
            this.cboPhongHoc.Name = "cboPhongHoc";
            this.cboPhongHoc.Size = new System.Drawing.Size(272, 31);
            this.cboPhongHoc.TabIndex = 3;
            // 
            // lblMaLopHoc
            // 
            this.lblMaLopHoc.AutoSize = true;
            this.lblMaLopHoc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLopHoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaLopHoc.Location = new System.Drawing.Point(16, 21);
            this.lblMaLopHoc.Name = "lblMaLopHoc";
            this.lblMaLopHoc.Size = new System.Drawing.Size(140, 28);
            this.lblMaLopHoc.TabIndex = 2;
            this.lblMaLopHoc.Text = "Mã Lớp Học";
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
            this.pnlButton.Size = new System.Drawing.Size(216, 666);
            this.pnlButton.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(12, 521);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm  kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.otakusan_net_4553_Mirai;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSua.Location = new System.Drawing.Point(12, 436);
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
            this.btnXoa.Location = new System.Drawing.Point(12, 349);
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
            this.btnThem.Location = new System.Drawing.Point(12, 269);
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
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 705);
            this.Controls.Add(this.xuiFormDesign1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLopHoc";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.pnlHocVien.ResumeLayout(false);
            this.pnlHocVien.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkingArea;
        private XanderUI.XUIFormDesign xuiFormDesign1;
        private System.Windows.Forms.Panel pnlHocVien;
        private System.Windows.Forms.MaskedTextBox mtxtNgayKhaiGiang;
        private System.Windows.Forms.ColumnHeader MALH;
        private System.Windows.Forms.ColumnHeader MAPH;
        private System.Windows.Forms.ColumnHeader MAKH;
        private System.Windows.Forms.ColumnHeader MAGV;
        private System.Windows.Forms.ColumnHeader TIETHOC;
        private System.Windows.Forms.ColumnHeader TINHTRANG;
        private System.Windows.Forms.ColumnHeader SOLUONG;
        private System.Windows.Forms.Label lblLichKhaiGiang;
        private System.Windows.Forms.Label lblTietHoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.Label lblMaPH;
        private System.Windows.Forms.ComboBox cboPhongHoc;
        private System.Windows.Forms.Label lblMaLopHoc;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.ComboBox cboTietHoc;
        private System.Windows.Forms.ComboBox cboGiaoVien;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Label lblLichKetThuc;
        private System.Windows.Forms.MaskedTextBox mtxtNgayKetThuc;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ColumnHeader LICHKHAIGIANG;
        private System.Windows.Forms.ColumnHeader LICHKETTHUC;
        private System.Windows.Forms.CheckBox chkMoLop;
        public System.Windows.Forms.ListView lstvThongTin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label lblDotKhaiGiang;
        private System.Windows.Forms.ComboBox cboDotKhaiGiang;
        private XanderUI.XUIButton btnTuyChon;
    }
}
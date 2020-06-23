namespace GUI
{
    partial class frmHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocVien));
            this.pictureExixt = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lsvThongTin = new System.Windows.Forms.ListView();
            this.MAHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MALH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TENHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAMSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIACHI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGHENGHIEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TINHTRANG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHocVien = new System.Windows.Forms.Panel();
            this.cboxMaHV = new System.Windows.Forms.ComboBox();
            this.mtxtNamSinh = new System.Windows.Forms.MaskedTextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtNgheNgiep = new System.Windows.Forms.TextBox();
            this.lblNgheNgiep = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtTenHV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTenHV = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.cboxMaLop = new System.Windows.Forms.ComboBox();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxTinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExixt)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHocVien.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureExixt
            // 
            this.pictureExixt.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExixt.Image = ((System.Drawing.Image)(resources.GetObject("pictureExixt.Image")));
            this.pictureExixt.Location = new System.Drawing.Point(719, 0);
            this.pictureExixt.Name = "pictureExixt";
            this.pictureExixt.Size = new System.Drawing.Size(128, 100);
            this.pictureExixt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExixt.TabIndex = 17;
            this.pictureExixt.TabStop = false;
            this.pictureExixt.Click += new System.EventHandler(this.pictureExixt_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(719, 100);
            this.lblTieuDe.TabIndex = 16;
            this.lblTieuDe.Text = "HỌC VIÊN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlButton.Size = new System.Drawing.Size(216, 705);
            this.pnlButton.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 598);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm  kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
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
            this.btnSua.Location = new System.Drawing.Point(24, 513);
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
            this.btnXoa.Location = new System.Drawing.Point(24, 426);
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
            this.btnThem.Location = new System.Drawing.Point(24, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 60);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lsvThongTin
            // 
            this.lsvThongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MAHV,
            this.MALH,
            this.TENHV,
            this.NAMSINH,
            this.DIACHI,
            this.NGHENGHIEP,
            this.TINHTRANG,
            this.SDT});
            this.lsvThongTin.FullRowSelect = true;
            this.lsvThongTin.GridLines = true;
            this.lsvThongTin.HideSelection = false;
            this.lsvThongTin.Location = new System.Drawing.Point(21, 258);
            this.lsvThongTin.MultiSelect = false;
            this.lsvThongTin.Name = "lsvThongTin";
            this.lsvThongTin.Size = new System.Drawing.Size(793, 335);
            this.lsvThongTin.TabIndex = 17;
            this.lsvThongTin.UseCompatibleStateImageBehavior = false;
            this.lsvThongTin.View = System.Windows.Forms.View.Details;
            this.lsvThongTin.SelectedIndexChanged += new System.EventHandler(this.lsvThongTin_SelectedIndexChanged);
            // 
            // MAHV
            // 
            this.MAHV.Text = "Mã HV";
            this.MAHV.Width = 80;
            // 
            // MALH
            // 
            this.MALH.Text = "Mã LH";
            this.MALH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MALH.Width = 80;
            // 
            // TENHV
            // 
            this.TENHV.Text = "Tên Học Viên";
            this.TENHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TENHV.Width = 250;
            // 
            // NAMSINH
            // 
            this.NAMSINH.Text = "Năm Sinh";
            this.NAMSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NAMSINH.Width = 150;
            // 
            // DIACHI
            // 
            this.DIACHI.Text = "Địa Chỉ";
            this.DIACHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DIACHI.Width = 250;
            // 
            // NGHENGHIEP
            // 
            this.NGHENGHIEP.Text = "Nghề Nghiệp";
            this.NGHENGHIEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NGHENGHIEP.Width = 150;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Text = "Tình Trạng";
            this.TINHTRANG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TINHTRANG.Width = 150;
            // 
            // SDT
            // 
            this.SDT.Text = "SDT";
            this.SDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SDT.Width = 150;
            // 
            // pnlHocVien
            // 
            this.pnlHocVien.BackColor = System.Drawing.Color.LightGray;
            this.pnlHocVien.Controls.Add(this.cboxTinhTrang);
            this.pnlHocVien.Controls.Add(this.cboxMaHV);
            this.pnlHocVien.Controls.Add(this.mtxtNamSinh);
            this.pnlHocVien.Controls.Add(this.lsvThongTin);
            this.pnlHocVien.Controls.Add(this.lblTinhTrang);
            this.pnlHocVien.Controls.Add(this.txtNgheNgiep);
            this.pnlHocVien.Controls.Add(this.lblNgheNgiep);
            this.pnlHocVien.Controls.Add(this.txtSDT);
            this.pnlHocVien.Controls.Add(this.lblSDT);
            this.pnlHocVien.Controls.Add(this.lblNamSinh);
            this.pnlHocVien.Controls.Add(this.txtTenHV);
            this.pnlHocVien.Controls.Add(this.txtDiaChi);
            this.pnlHocVien.Controls.Add(this.lblTenHV);
            this.pnlHocVien.Controls.Add(this.lblDiaChi);
            this.pnlHocVien.Controls.Add(this.lblMaLop);
            this.pnlHocVien.Controls.Add(this.cboxMaLop);
            this.pnlHocVien.Controls.Add(this.lblMaHocVien);
            this.pnlHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHocVien.Location = new System.Drawing.Point(216, 100);
            this.pnlHocVien.Name = "pnlHocVien";
            this.pnlHocVien.Size = new System.Drawing.Size(847, 605);
            this.pnlHocVien.TabIndex = 15;
            // 
            // cboxMaHV
            // 
            this.cboxMaHV.FormattingEnabled = true;
            this.cboxMaHV.Location = new System.Drawing.Point(175, 21);
            this.cboxMaHV.Name = "cboxMaHV";
            this.cboxMaHV.Size = new System.Drawing.Size(243, 31);
            this.cboxMaHV.TabIndex = 20;
            this.cboxMaHV.SelectedIndexChanged += new System.EventHandler(this.cboxMaHV_SelectedIndexChanged);
            // 
            // mtxtNamSinh
            // 
            this.mtxtNamSinh.Location = new System.Drawing.Point(594, 64);
            this.mtxtNamSinh.Mask = "00/00/0000";
            this.mtxtNamSinh.Name = "mtxtNamSinh";
            this.mtxtNamSinh.Size = new System.Drawing.Size(220, 31);
            this.mtxtNamSinh.TabIndex = 18;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTinhTrang.Location = new System.Drawing.Point(16, 166);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(127, 28);
            this.lblTinhTrang.TabIndex = 15;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // txtNgheNgiep
            // 
            this.txtNgheNgiep.Location = new System.Drawing.Point(594, 113);
            this.txtNgheNgiep.Name = "txtNgheNgiep";
            this.txtNgheNgiep.Size = new System.Drawing.Size(220, 31);
            this.txtNgheNgiep.TabIndex = 14;
            // 
            // lblNgheNgiep
            // 
            this.lblNgheNgiep.AutoSize = true;
            this.lblNgheNgiep.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgheNgiep.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNgheNgiep.Location = new System.Drawing.Point(441, 113);
            this.lblNgheNgiep.Name = "lblNgheNgiep";
            this.lblNgheNgiep.Size = new System.Drawing.Size(147, 28);
            this.lblNgheNgiep.TabIndex = 13;
            this.lblNgheNgiep.Text = "Nghề nghiệp";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(175, 113);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(243, 31);
            this.txtSDT.TabIndex = 12;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHV_KeyPress);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSDT.Location = new System.Drawing.Point(16, 116);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(155, 28);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNamSinh.Location = new System.Drawing.Point(438, 67);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(114, 28);
            this.lblNamSinh.TabIndex = 9;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // txtTenHV
            // 
            this.txtTenHV.Location = new System.Drawing.Point(175, 67);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(243, 31);
            this.txtTenHV.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(175, 209);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(639, 31);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblTenHV
            // 
            this.lblTenHV.AutoSize = true;
            this.lblTenHV.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTenHV.Location = new System.Drawing.Point(16, 67);
            this.lblTenHV.Name = "lblTenHV";
            this.lblTenHV.Size = new System.Drawing.Size(150, 28);
            this.lblTenHV.TabIndex = 6;
            this.lblTenHV.Text = "Tên học viên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiaChi.Location = new System.Drawing.Point(16, 212);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(88, 28);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaLop.Location = new System.Drawing.Point(441, 21);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(131, 28);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "Mã lớp học";
            // 
            // cboxMaLop
            // 
            this.cboxMaLop.FormattingEnabled = true;
            this.cboxMaLop.Location = new System.Drawing.Point(594, 18);
            this.cboxMaLop.Name = "cboxMaLop";
            this.cboxMaLop.Size = new System.Drawing.Size(220, 31);
            this.cboxMaLop.TabIndex = 3;
            this.cboxMaLop.SelectedIndexChanged += new System.EventHandler(this.cboxMaLop_SelectedIndexChanged);
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMaHocVien.Location = new System.Drawing.Point(16, 21);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(142, 28);
            this.lblMaHocVien.TabIndex = 2;
            this.lblMaHocVien.Text = "Mã học viên";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTitle.Controls.Add(this.lblTieuDe);
            this.pnlTitle.Controls.Add(this.pictureExixt);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(216, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(847, 100);
            this.pnlTitle.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboxTinhTrang
            // 
            this.cboxTinhTrang.FormattingEnabled = true;
            this.cboxTinhTrang.Location = new System.Drawing.Point(175, 163);
            this.cboxTinhTrang.Name = "cboxTinhTrang";
            this.cboxTinhTrang.Size = new System.Drawing.Size(639, 31);
            this.cboxTinhTrang.TabIndex = 21;
            // 
            // frmHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1063, 705);
            this.Controls.Add(this.pnlHocVien);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHocVien";
            this.Load += new System.EventHandler(this.frmHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExixt)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHocVien.ResumeLayout(false);
            this.pnlHocVien.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.PictureBox pictureExixt;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lsvThongTin;
        private System.Windows.Forms.Panel pnlHocVien;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtNgheNgiep;
        private System.Windows.Forms.Label lblNgheNgiep;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtTenHV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTenHV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.ComboBox cboxMaLop;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.ColumnHeader MAHV;
        private System.Windows.Forms.ColumnHeader MALH;
        private System.Windows.Forms.ColumnHeader TENHV;
        private System.Windows.Forms.ColumnHeader NAMSINH;
        private System.Windows.Forms.ColumnHeader DIACHI;
        private System.Windows.Forms.ColumnHeader NGHENGHIEP;
        private System.Windows.Forms.ColumnHeader TINHTRANG;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.MaskedTextBox mtxtNamSinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboxMaHV;
        private System.Windows.Forms.ComboBox cboxTinhTrang;
    }
}
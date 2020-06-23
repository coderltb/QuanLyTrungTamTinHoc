namespace GUI
{
    partial class frmBaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoLuu));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureExixt = new System.Windows.Forms.PictureBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxMaBL = new System.Windows.Forms.ComboBox();
            this.mtxtThoiGianKTBaoLuu = new System.Windows.Forms.MaskedTextBox();
            this.mtxtThoiGianBDBaoLuu = new System.Windows.Forms.MaskedTextBox();
            this.gridvBaoLuu = new System.Windows.Forms.DataGridView();
            this.MABL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBATDAUBAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKETTHUCBAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIENBAOLUU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaBaoLuu = new System.Windows.Forms.Label();
            this.lblMaLopHoc = new System.Windows.Forms.Label();
            this.lblMaHocVien = new System.Windows.Forms.Label();
            this.lblThoiGianKTBaoLUU = new System.Windows.Forms.Label();
            this.cboxMaHocVien = new System.Windows.Forms.ComboBox();
            this.lblThoiGianBDBaoLuu = new System.Windows.Forms.Label();
            this.cboxMaLopHoc = new System.Windows.Forms.ComboBox();
            this.txtSoTienBL = new System.Windows.Forms.TextBox();
            this.lblSoTienBaoLuu = new System.Windows.Forms.Label();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExixt)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvBaoLuu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlButton.Controls.Add(this.btnTimKiem);
            this.pnlButton.Controls.Add(this.btnSua);
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnThem);
            this.pnlButton.Controls.Add(this.pictureBox1);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(216, 721);
            this.pnlButton.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(24, 578);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 60);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSua.Location = new System.Drawing.Point(24, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 60);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(24, 400);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 60);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThem.Location = new System.Drawing.Point(24, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 60);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureExixt
            // 
            this.pictureExixt.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExixt.Image = ((System.Drawing.Image)(resources.GetObject("pictureExixt.Image")));
            this.pictureExixt.Location = new System.Drawing.Point(818, 0);
            this.pictureExixt.Name = "pictureExixt";
            this.pictureExixt.Size = new System.Drawing.Size(100, 81);
            this.pictureExixt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExixt.TabIndex = 7;
            this.pictureExixt.TabStop = false;
            this.pictureExixt.Click += new System.EventHandler(this.pictureExixt_Click_1);
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.LightGray;
            this.pnlData.Controls.Add(this.cboxMaBL);
            this.pnlData.Controls.Add(this.mtxtThoiGianKTBaoLuu);
            this.pnlData.Controls.Add(this.mtxtThoiGianBDBaoLuu);
            this.pnlData.Controls.Add(this.gridvBaoLuu);
            this.pnlData.Controls.Add(this.lblMaBaoLuu);
            this.pnlData.Controls.Add(this.lblMaLopHoc);
            this.pnlData.Controls.Add(this.lblMaHocVien);
            this.pnlData.Controls.Add(this.lblThoiGianKTBaoLUU);
            this.pnlData.Controls.Add(this.cboxMaHocVien);
            this.pnlData.Controls.Add(this.lblThoiGianBDBaoLuu);
            this.pnlData.Controls.Add(this.cboxMaLopHoc);
            this.pnlData.Controls.Add(this.txtSoTienBL);
            this.pnlData.Controls.Add(this.lblSoTienBaoLuu);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(216, 81);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(918, 640);
            this.pnlData.TabIndex = 30;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Controls.Add(this.pictureExixt);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(216, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(918, 81);
            this.pnlTieuDe.TabIndex = 31;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(818, 81);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Bảo Lưu Học Viên";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboxMaBL
            // 
            this.cboxMaBL.BackColor = System.Drawing.Color.Silver;
            this.cboxMaBL.FormattingEnabled = true;
            this.cboxMaBL.Location = new System.Drawing.Point(209, 14);
            this.cboxMaBL.Name = "cboxMaBL";
            this.cboxMaBL.Size = new System.Drawing.Size(222, 31);
            this.cboxMaBL.TabIndex = 44;
            // 
            // mtxtThoiGianKTBaoLuu
            // 
            this.mtxtThoiGianKTBaoLuu.BackColor = System.Drawing.Color.Silver;
            this.mtxtThoiGianKTBaoLuu.ForeColor = System.Drawing.Color.White;
            this.mtxtThoiGianKTBaoLuu.Location = new System.Drawing.Point(337, 178);
            this.mtxtThoiGianKTBaoLuu.Mask = "00/00/0000";
            this.mtxtThoiGianKTBaoLuu.Name = "mtxtThoiGianKTBaoLuu";
            this.mtxtThoiGianKTBaoLuu.Size = new System.Drawing.Size(564, 31);
            this.mtxtThoiGianKTBaoLuu.TabIndex = 43;
            // 
            // mtxtThoiGianBDBaoLuu
            // 
            this.mtxtThoiGianBDBaoLuu.BackColor = System.Drawing.Color.Silver;
            this.mtxtThoiGianBDBaoLuu.ForeColor = System.Drawing.Color.White;
            this.mtxtThoiGianBDBaoLuu.Location = new System.Drawing.Point(337, 134);
            this.mtxtThoiGianBDBaoLuu.Mask = "00/00/0000";
            this.mtxtThoiGianBDBaoLuu.Name = "mtxtThoiGianBDBaoLuu";
            this.mtxtThoiGianBDBaoLuu.Size = new System.Drawing.Size(564, 31);
            this.mtxtThoiGianBDBaoLuu.TabIndex = 42;
            // 
            // gridvBaoLuu
            // 
            this.gridvBaoLuu.BackgroundColor = System.Drawing.Color.DarkGray;
            this.gridvBaoLuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridvBaoLuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABL,
            this.MALH,
            this.MAHV,
            this.THOIGIANBATDAUBAOLUU,
            this.THOIGIANKETTHUCBAOLUU,
            this.SOTIENBAOLUU});
            this.gridvBaoLuu.Location = new System.Drawing.Point(22, 228);
            this.gridvBaoLuu.Name = "gridvBaoLuu";
            this.gridvBaoLuu.RowHeadersWidth = 51;
            this.gridvBaoLuu.RowTemplate.Height = 24;
            this.gridvBaoLuu.Size = new System.Drawing.Size(879, 398);
            this.gridvBaoLuu.TabIndex = 41;
            // 
            // MABL
            // 
            this.MABL.DataPropertyName = "MABL";
            this.MABL.HeaderText = "Mã BL";
            this.MABL.MinimumWidth = 6;
            this.MABL.Name = "MABL";
            this.MABL.Width = 125;
            // 
            // MALH
            // 
            this.MALH.DataPropertyName = "MALH";
            this.MALH.HeaderText = "Mã LH";
            this.MALH.MinimumWidth = 6;
            this.MALH.Name = "MALH";
            this.MALH.Width = 125;
            // 
            // MAHV
            // 
            this.MAHV.DataPropertyName = "MAHV";
            this.MAHV.HeaderText = "Mã HV";
            this.MAHV.MinimumWidth = 6;
            this.MAHV.Name = "MAHV";
            this.MAHV.Width = 125;
            // 
            // THOIGIANBATDAUBAOLUU
            // 
            this.THOIGIANBATDAUBAOLUU.DataPropertyName = "THOIGIANBATDAUBAOLUU";
            this.THOIGIANBATDAUBAOLUU.HeaderText = "TGBD Bảo Lưu";
            this.THOIGIANBATDAUBAOLUU.MinimumWidth = 6;
            this.THOIGIANBATDAUBAOLUU.Name = "THOIGIANBATDAUBAOLUU";
            this.THOIGIANBATDAUBAOLUU.Width = 170;
            // 
            // THOIGIANKETTHUCBAOLUU
            // 
            this.THOIGIANKETTHUCBAOLUU.DataPropertyName = "THOIGIANKETTHUCBAOLUU";
            this.THOIGIANKETTHUCBAOLUU.HeaderText = "TGKT Bảo Lưu";
            this.THOIGIANKETTHUCBAOLUU.MinimumWidth = 6;
            this.THOIGIANKETTHUCBAOLUU.Name = "THOIGIANKETTHUCBAOLUU";
            this.THOIGIANKETTHUCBAOLUU.Width = 170;
            // 
            // SOTIENBAOLUU
            // 
            this.SOTIENBAOLUU.DataPropertyName = "SOTIENBAOLUU";
            this.SOTIENBAOLUU.HeaderText = "Số Tiền Bảo Lưu";
            this.SOTIENBAOLUU.MinimumWidth = 6;
            this.SOTIENBAOLUU.Name = "SOTIENBAOLUU";
            this.SOTIENBAOLUU.Width = 200;
            // 
            // lblMaBaoLuu
            // 
            this.lblMaBaoLuu.AutoSize = true;
            this.lblMaBaoLuu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBaoLuu.ForeColor = System.Drawing.Color.Maroon;
            this.lblMaBaoLuu.Location = new System.Drawing.Point(17, 17);
            this.lblMaBaoLuu.Name = "lblMaBaoLuu";
            this.lblMaBaoLuu.Size = new System.Drawing.Size(134, 28);
            this.lblMaBaoLuu.TabIndex = 32;
            this.lblMaBaoLuu.Text = "Mã bảo lưu";
            // 
            // lblMaLopHoc
            // 
            this.lblMaLopHoc.AutoSize = true;
            this.lblMaLopHoc.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLopHoc.ForeColor = System.Drawing.Color.Maroon;
            this.lblMaLopHoc.Location = new System.Drawing.Point(462, 17);
            this.lblMaLopHoc.Name = "lblMaLopHoc";
            this.lblMaLopHoc.Size = new System.Drawing.Size(131, 28);
            this.lblMaLopHoc.TabIndex = 33;
            this.lblMaLopHoc.Text = "Mã lớp học";
            // 
            // lblMaHocVien
            // 
            this.lblMaHocVien.AutoSize = true;
            this.lblMaHocVien.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHocVien.ForeColor = System.Drawing.Color.Maroon;
            this.lblMaHocVien.Location = new System.Drawing.Point(462, 69);
            this.lblMaHocVien.Name = "lblMaHocVien";
            this.lblMaHocVien.Size = new System.Drawing.Size(142, 28);
            this.lblMaHocVien.TabIndex = 34;
            this.lblMaHocVien.Text = "Mã học viên";
            // 
            // lblThoiGianKTBaoLUU
            // 
            this.lblThoiGianKTBaoLUU.AutoSize = true;
            this.lblThoiGianKTBaoLUU.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianKTBaoLUU.ForeColor = System.Drawing.Color.Maroon;
            this.lblThoiGianKTBaoLUU.Location = new System.Drawing.Point(17, 181);
            this.lblThoiGianKTBaoLUU.Name = "lblThoiGianKTBaoLUU";
            this.lblThoiGianKTBaoLUU.Size = new System.Drawing.Size(299, 28);
            this.lblThoiGianKTBaoLUU.TabIndex = 40;
            this.lblThoiGianKTBaoLUU.Text = "Thời gian kết thúc bảo lưu";
            // 
            // cboxMaHocVien
            // 
            this.cboxMaHocVien.BackColor = System.Drawing.Color.Silver;
            this.cboxMaHocVien.FormattingEnabled = true;
            this.cboxMaHocVien.Location = new System.Drawing.Point(613, 66);
            this.cboxMaHocVien.Name = "cboxMaHocVien";
            this.cboxMaHocVien.Size = new System.Drawing.Size(288, 31);
            this.cboxMaHocVien.TabIndex = 35;
            this.cboxMaHocVien.SelectedIndexChanged += new System.EventHandler(this.cboxMaHocVien_SelectedIndexChanged);
            // 
            // lblThoiGianBDBaoLuu
            // 
            this.lblThoiGianBDBaoLuu.AutoSize = true;
            this.lblThoiGianBDBaoLuu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianBDBaoLuu.ForeColor = System.Drawing.Color.Maroon;
            this.lblThoiGianBDBaoLuu.Location = new System.Drawing.Point(17, 129);
            this.lblThoiGianBDBaoLuu.Name = "lblThoiGianBDBaoLuu";
            this.lblThoiGianBDBaoLuu.Size = new System.Drawing.Size(293, 28);
            this.lblThoiGianBDBaoLuu.TabIndex = 39;
            this.lblThoiGianBDBaoLuu.Text = "Thời gian bắt đàu bảo lưu";
            // 
            // cboxMaLopHoc
            // 
            this.cboxMaLopHoc.BackColor = System.Drawing.Color.Silver;
            this.cboxMaLopHoc.FormattingEnabled = true;
            this.cboxMaLopHoc.Location = new System.Drawing.Point(613, 14);
            this.cboxMaLopHoc.Name = "cboxMaLopHoc";
            this.cboxMaLopHoc.Size = new System.Drawing.Size(288, 31);
            this.cboxMaLopHoc.TabIndex = 36;
            this.cboxMaLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboxMaLopHoc_SelectedIndexChanged);
            // 
            // txtSoTienBL
            // 
            this.txtSoTienBL.BackColor = System.Drawing.Color.Silver;
            this.txtSoTienBL.ForeColor = System.Drawing.Color.Firebrick;
            this.txtSoTienBL.Location = new System.Drawing.Point(209, 66);
            this.txtSoTienBL.Name = "txtSoTienBL";
            this.txtSoTienBL.Size = new System.Drawing.Size(222, 31);
            this.txtSoTienBL.TabIndex = 38;
            this.txtSoTienBL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienBL_KeyPress);
            // 
            // lblSoTienBaoLuu
            // 
            this.lblSoTienBaoLuu.AutoSize = true;
            this.lblSoTienBaoLuu.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienBaoLuu.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoTienBaoLuu.Location = new System.Drawing.Point(17, 69);
            this.lblSoTienBaoLuu.Name = "lblSoTienBaoLuu";
            this.lblSoTienBaoLuu.Size = new System.Drawing.Size(176, 28);
            this.lblSoTienBaoLuu.TabIndex = 37;
            this.lblSoTienBaoLuu.Text = "Số tiền bảo lưu";
            // 
            // frmBaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1134, 721);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.pnlButton);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoLuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo lưu học viên";
            this.Load += new System.EventHandler(this.frmBaoLuu_Load);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExixt)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvBaoLuu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.PictureBox pictureExixt;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboxMaBL;
        private System.Windows.Forms.MaskedTextBox mtxtThoiGianKTBaoLuu;
        private System.Windows.Forms.MaskedTextBox mtxtThoiGianBDBaoLuu;
        private System.Windows.Forms.DataGridView gridvBaoLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBATDAUBAOLUU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKETTHUCBAOLUU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIENBAOLUU;
        private System.Windows.Forms.Label lblMaBaoLuu;
        private System.Windows.Forms.Label lblMaLopHoc;
        private System.Windows.Forms.Label lblMaHocVien;
        private System.Windows.Forms.Label lblThoiGianKTBaoLUU;
        private System.Windows.Forms.ComboBox cboxMaHocVien;
        private System.Windows.Forms.Label lblThoiGianBDBaoLuu;
        private System.Windows.Forms.ComboBox cboxMaLopHoc;
        private System.Windows.Forms.TextBox txtSoTienBL;
        private System.Windows.Forms.Label lblSoTienBaoLuu;
    }
}
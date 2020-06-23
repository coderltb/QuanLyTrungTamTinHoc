namespace GUI
{
    partial class frmOptionDotKhaiGiang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionDotKhaiGiang));
            this.lblDotKhaiGiang = new System.Windows.Forms.Label();
            this.cboDotKhaiGiang = new System.Windows.Forms.ComboBox();
            this.gboxThemDotKhaiGiang = new System.Windows.Forms.GroupBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboThemDotKG = new System.Windows.Forms.ComboBox();
            this.lblThemDotKhaiGiang = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlNoiDung = new DevComponents.DotNetBar.PanelEx();
            this.pnlTitile = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.gboxThemDotKhaiGiang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlNoiDung.SuspendLayout();
            this.pnlTitile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDotKhaiGiang
            // 
            this.lblDotKhaiGiang.AutoSize = true;
            this.lblDotKhaiGiang.ForeColor = System.Drawing.Color.Maroon;
            this.lblDotKhaiGiang.Location = new System.Drawing.Point(51, 17);
            this.lblDotKhaiGiang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDotKhaiGiang.Name = "lblDotKhaiGiang";
            this.lblDotKhaiGiang.Size = new System.Drawing.Size(149, 22);
            this.lblDotKhaiGiang.TabIndex = 0;
            this.lblDotKhaiGiang.Text = "Đợt Khai Giảng: ";
            // 
            // cboDotKhaiGiang
            // 
            this.cboDotKhaiGiang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDotKhaiGiang.FormattingEnabled = true;
            this.cboDotKhaiGiang.Location = new System.Drawing.Point(252, 17);
            this.cboDotKhaiGiang.Name = "cboDotKhaiGiang";
            this.cboDotKhaiGiang.Size = new System.Drawing.Size(505, 29);
            this.cboDotKhaiGiang.TabIndex = 2;
            // 
            // gboxThemDotKhaiGiang
            // 
            this.gboxThemDotKhaiGiang.Controls.Add(this.txtNam);
            this.gboxThemDotKhaiGiang.Controls.Add(this.lblNam);
            this.gboxThemDotKhaiGiang.Controls.Add(this.cboThemDotKG);
            this.gboxThemDotKhaiGiang.Controls.Add(this.lblThemDotKhaiGiang);
            this.gboxThemDotKhaiGiang.ForeColor = System.Drawing.Color.Maroon;
            this.gboxThemDotKhaiGiang.Location = new System.Drawing.Point(-4, 78);
            this.gboxThemDotKhaiGiang.Name = "gboxThemDotKhaiGiang";
            this.gboxThemDotKhaiGiang.Size = new System.Drawing.Size(780, 132);
            this.gboxThemDotKhaiGiang.TabIndex = 3;
            this.gboxThemDotKhaiGiang.TabStop = false;
            this.gboxThemDotKhaiGiang.Text = "Thêm Đợt Khai Giảng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(616, 57);
            this.txtNam.MaxLength = 4;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(145, 29);
            this.txtNam.TabIndex = 4;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(529, 60);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(59, 22);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm: ";
            // 
            // cboThemDotKG
            // 
            this.cboThemDotKG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThemDotKG.FormattingEnabled = true;
            this.cboThemDotKG.Items.AddRange(new object[] {
            "Đợt 1",
            "Đợt 2",
            "Đợt 3"});
            this.cboThemDotKG.Location = new System.Drawing.Point(220, 57);
            this.cboThemDotKG.Name = "cboThemDotKG";
            this.cboThemDotKG.Size = new System.Drawing.Size(303, 29);
            this.cboThemDotKG.TabIndex = 2;
            // 
            // lblThemDotKhaiGiang
            // 
            this.lblThemDotKhaiGiang.AutoSize = true;
            this.lblThemDotKhaiGiang.Location = new System.Drawing.Point(22, 60);
            this.lblThemDotKhaiGiang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThemDotKhaiGiang.Name = "lblThemDotKhaiGiang";
            this.lblThemDotKhaiGiang.Size = new System.Drawing.Size(149, 22);
            this.lblThemDotKhaiGiang.TabIndex = 0;
            this.lblThemDotKhaiGiang.Text = "Đợt Khai Giảng: ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSua.Location = new System.Drawing.Point(304, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 60);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleGreen;
            this.btnXoa.Location = new System.Drawing.Point(551, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 60);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThem.Location = new System.Drawing.Point(71, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 60);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNoiDung.Controls.Add(this.cboDotKhaiGiang);
            this.pnlNoiDung.Controls.Add(this.btnSua);
            this.pnlNoiDung.Controls.Add(this.lblDotKhaiGiang);
            this.pnlNoiDung.Controls.Add(this.btnXoa);
            this.pnlNoiDung.Controls.Add(this.gboxThemDotKhaiGiang);
            this.pnlNoiDung.Controls.Add(this.btnThem);
            this.pnlNoiDung.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 90);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(804, 338);
            this.pnlNoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNoiDung.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlNoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNoiDung.Style.GradientAngle = 90;
            this.pnlNoiDung.TabIndex = 10;
            // 
            // pnlTitile
            // 
            this.pnlTitile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTitile.Controls.Add(this.reflectionLabel1);
            this.pnlTitile.Controls.Add(this.pictureExit);
            this.pnlTitile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitile.Location = new System.Drawing.Point(0, 0);
            this.pnlTitile.Name = "pnlTitile";
            this.pnlTitile.Size = new System.Drawing.Size(804, 86);
            this.pnlTitile.TabIndex = 67;
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
            this.reflectionLabel1.Size = new System.Drawing.Size(714, 86);
            this.reflectionLabel1.TabIndex = 66;
            this.reflectionLabel1.Text = resources.GetString("reflectionLabel1.Text");
            // 
            // pictureExit
            // 
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(714, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 13;
            this.pictureExit.TabStop = false;
            // 
            // frmOptionDotKhaiGiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(804, 428);
            this.Controls.Add(this.pnlTitile);
            this.Controls.Add(this.pnlNoiDung);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmOptionDotKhaiGiang";
            this.Text = "frmOptionDotKhaiGiang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptionDotKhaiGiang_FormClosing);
            this.Load += new System.EventHandler(this.frmOptionDotKhaiGiang_Load);
            this.gboxThemDotKhaiGiang.ResumeLayout(false);
            this.gboxThemDotKhaiGiang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlNoiDung.ResumeLayout(false);
            this.pnlNoiDung.PerformLayout();
            this.pnlTitile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDotKhaiGiang;
        private System.Windows.Forms.ComboBox cboDotKhaiGiang;
        private System.Windows.Forms.GroupBox gboxThemDotKhaiGiang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboThemDotKG;
        private System.Windows.Forms.Label lblThemDotKhaiGiang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.PanelEx pnlNoiDung;
        private System.Windows.Forms.Panel pnlTitile;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        protected internal System.Windows.Forms.PictureBox pictureExit;
    }
}
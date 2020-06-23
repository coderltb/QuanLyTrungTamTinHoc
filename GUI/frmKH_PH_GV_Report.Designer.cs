namespace GUI
{
    partial class frmKH_PH_GV_Report
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlTitile = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.pnlNoiDung = new DevComponents.DotNetBar.PanelEx();
            this.btnReport = new DevComponents.DotNetBar.ButtonX();
            this.cboTen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTen = new DevComponents.DotNetBar.LabelX();
            this.pnlTitile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.pnlNoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 164);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(982, 585);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 225;
            // 
            // pnlTitile
            // 
            this.pnlTitile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTitile.Controls.Add(this.lblTieuDe);
            this.pnlTitile.Controls.Add(this.pictureExit);
            this.pnlTitile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitile.Location = new System.Drawing.Point(0, 0);
            this.pnlTitile.Name = "pnlTitile";
            this.pnlTitile.Size = new System.Drawing.Size(982, 86);
            this.pnlTitile.TabIndex = 68;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(892, 86);
            this.lblTieuDe.TabIndex = 14;
            this.lblTieuDe.Text = "Report";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureExit
            // 
            this.pictureExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureExit.Image = global::GUI.Properties.Resources._15104_wpm_lowres;
            this.pictureExit.Location = new System.Drawing.Point(892, 0);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(90, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExit.TabIndex = 13;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNoiDung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNoiDung.Controls.Add(this.btnReport);
            this.pnlNoiDung.Controls.Add(this.cboTen);
            this.pnlNoiDung.Controls.Add(this.lblTen);
            this.pnlNoiDung.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNoiDung.Location = new System.Drawing.Point(0, 86);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(982, 112);
            this.pnlNoiDung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNoiDung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNoiDung.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlNoiDung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNoiDung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNoiDung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNoiDung.Style.GradientAngle = 90;
            this.pnlNoiDung.TabIndex = 74;
            // 
            // btnReport
            // 
            this.btnReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(626, 40);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(122, 28);
            this.btnReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReport.TabIndex = 70;
            this.btnReport.Text = "Show Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cboTen
            // 
            this.cboTen.DisplayMember = "Text";
            this.cboTen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTen.FormattingEnabled = true;
            this.cboTen.ItemHeight = 21;
            this.cboTen.Location = new System.Drawing.Point(339, 41);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(261, 27);
            this.cboTen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTen.TabIndex = 68;
            // 
            // lblTen
            // 
            // 
            // 
            // 
            this.lblTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTen.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Maroon;
            this.lblTen.Location = new System.Drawing.Point(200, 41);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(133, 23);
            this.lblTen.TabIndex = 69;
            this.lblTen.Text = "Tên";
            // 
            // frmKH_PH_GV_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 749);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTitile);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKH_PH_GV_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KH_PH_GV_Report";
            this.Load += new System.EventHandler(this.frmKH_PH_GV_Report_Load);
            this.pnlTitile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.pnlNoiDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel pnlTitile;
        private System.Windows.Forms.Label lblTieuDe;
        protected internal System.Windows.Forms.PictureBox pictureExit;
        private DevComponents.DotNetBar.PanelEx pnlNoiDung;
        private DevComponents.DotNetBar.ButtonX btnReport;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTen;
        private DevComponents.DotNetBar.LabelX lblTen;
    }
}
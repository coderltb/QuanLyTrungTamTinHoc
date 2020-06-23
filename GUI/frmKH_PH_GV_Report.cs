using BLL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKH_PH_GV_Report : Form
    {
        public frmKH_PH_GV_Report()
        {
            InitializeComponent();
        }

        private UtilitiesBLL xuly = new UtilitiesBLL();

        private void loadComboBoxTenPH()
        {
            List<PhongHoc> dsph = xuly.LayToanBoPhongHoc();
            PhongHoc item = new PhongHoc();
            item.tenPG = "Tất cả phòng";
            item.maPH = 0;
            dsph.Insert(0, item);
            cboTen.DataSource = dsph;
            cboTen.ValueMember = "MaPH";
            cboTen.DisplayMember = "tenPG";
        }

        private void loadComboBoxTenKH()
        {
            List<KhoaHoc> dskh = xuly.LayToanBoKhoaHoc();
            KhoaHoc item = new KhoaHoc();
            item.tenKH = "Tất cả lớp";
            item.maKH = 0;
            dskh.Insert(0, item);
            cboTen.DataSource = dskh;
            cboTen.DisplayMember = "TenKH";
            cboTen.ValueMember = "MaKH";
        }

        private void loadComboBoxTenGV()
        {
            List<GiangVien> dsgv = xuly.HienThiTatCaGiangVien();
            GiangVien item = new GiangVien();
            item.maGV = 0;
            item.tenGV = "Tất cả giảng viên";
            cboTen.DataSource = dsgv;
            cboTen.ValueMember = "MaGV";
            cboTen.DisplayMember = "TenGV";
        }

        private void frmKH_PH_GV_Report_Load(object sender, EventArgs e)
        {
            Form frmQuanLy = Application.OpenForms["frmChuongTrinhQuanLyTrungTamTinHoc"];
            int clicked = ((frmChuongTrinhQuanLyTrungTamTinHoc)frmQuanLy).btnWasClicked;
            if (this.Owner is frmChuongTrinhQuanLyTrungTamTinHoc)
            {
                if (clicked == 1)
                {
                    lblTieuDe.Text = "Report Khóa Học";
                    lblTen.Text = "Tên khóa học";
                    loadComboBoxTenKH();
                }

                if (clicked == 2)
                {
                    lblTieuDe.Text = "Report Phòng Học";
                    lblTen.Text = "Tên phòng học";
                    loadComboBoxTenPH();
                }

                if (clicked == 3)
                {
                    lblTieuDe.Text = "Report Giảng Viên";
                    lblTen.Text = "Tên giảng viên";
                    loadComboBoxTenGV();
                }
            }
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn thoát báo cáo?", "Rời khỏi báo cáo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form frmQuanLy = Application.OpenForms["frmChuongTrinhQuanLyTrungTamTinHoc"];
            int clicked = ((frmChuongTrinhQuanLyTrungTamTinHoc)frmQuanLy).btnWasClicked;
            string dulieu = cboTen.SelectedValue.ToString();
            if (this.Owner is frmChuongTrinhQuanLyTrungTamTinHoc)
            {
                if (clicked == 1)
                {
                    if (dulieu.Equals("0"))
                    {
                        rptKhoaHoc rptKhoaHoc = new rptKhoaHoc();
                        crystalReportViewer1.ReportSource = rptKhoaHoc;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        rptKhoaHocTheoTen rpt = new rptKhoaHocTheoTen();

                        ParameterDiscreteValue pdvMaKH = new ParameterDiscreteValue();
                        string tenKH = dulieu;
                        pdvMaKH.Value = tenKH;

                        ParameterFieldDefinition pfdMaKH = rpt.DataDefinition.ParameterFields["MaKH"];
                        pfdMaKH.CurrentValues.Clear();
                        pfdMaKH.CurrentValues.Add(pdvMaKH);
                        pfdMaKH.ApplyCurrentValues(pfdMaKH.CurrentValues);
                        crystalReportViewer1.ReportSource = rpt;
                    }
                }

                if (clicked == 2)
                {
                    if (dulieu.Equals("0"))
                    {
                        rptPhongHoc rptPhongHoc = new rptPhongHoc();
                        crystalReportViewer1.ReportSource = rptPhongHoc;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        rptPhongHoc rpt = new rptPhongHoc();

                        ParameterDiscreteValue pdvMaPH = new ParameterDiscreteValue();
                        string tenPH = dulieu;
                        pdvMaPH.Value = tenPH;

                        ParameterFieldDefinition pfdMaPH = rpt.DataDefinition.ParameterFields["MaPH"];
                        pfdMaPH.CurrentValues.Clear();
                        pfdMaPH.CurrentValues.Add(pdvMaPH);
                        pfdMaPH.ApplyCurrentValues(pfdMaPH.CurrentValues);
                        crystalReportViewer1.ReportSource = rpt;
                    }
                }

                if (clicked == 3)
                {
                    if (dulieu.Equals("0"))
                    {
                        rptGiangVien rptGiangVien = new rptGiangVien();
                        crystalReportViewer1.ReportSource = rptGiangVien;
                        crystalReportViewer1.Refresh();
                    }
                    else
                    {
                        rptGiangVien rpt = new rptGiangVien();

                        ParameterDiscreteValue pdvMaGV = new ParameterDiscreteValue();
                        string tenGV = dulieu;
                        pdvMaGV.Value = tenGV;

                        ParameterFieldDefinition pfdMaGV = rpt.DataDefinition.ParameterFields["MaGV"];
                        pfdMaGV.CurrentValues.Clear();
                        pfdMaGV.CurrentValues.Add(pdvMaGV);
                        pfdMaGV.ApplyCurrentValues(pfdMaGV.CurrentValues);
                        crystalReportViewer1.ReportSource = rpt;
                    }
                }
            }
        }
    }
}
using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class UtilitiesBLL
    {
        private BaoLuuAccess baoLuu = new BaoLuuAccess();

        private CongNoAccess congNo = new CongNoAccess();

        private GiangVienAccess giangVien = new GiangVienAccess();

        private HocVienAccess hocVien = new HocVienAccess();

        private KhoaHocAccess khoaHoc = new KhoaHocAccess();

        private LopHocAccess lopHoc = new LopHocAccess();

        private PhongHocAccess phongHoc = new PhongHocAccess();

        private DotKhaiGiangAccess dotkhaigiang = new DotKhaiGiangAccess();

        private UserAccess user = new UserAccess();

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Rap Code Bao Luu

        public List<BaoLuu> HienThiTatCaBaoLuu()
        {
            return baoLuu.HienThiTatCaBaoLuu();
        }

        public List<BaoLuu> HienThiTatCaBaoLuuTheoLop(string maLH)
        {
            return baoLuu.HienThiTatCaBaoLuuTheoLop(maLH);
        }

        public List<BaoLuu> HienThiTatCaBaoLuuTheoMaHV(string maHV)
        {
            return baoLuu.HienThiTatCaBaoLuuTheoMaHV(maHV);
        }

        public bool themBaoLuu(BaoLuu bl)
        {
            return baoLuu.themBaoLuu(bl);
        }

        public bool xoaBaoLuu(string maBL)
        {
            return baoLuu.xoaBaoLuu(maBL);
        }

        public bool capnhatBaoLuu(BaoLuu bl)
        {
            return baoLuu.capnhatBaoLuu(bl);
        }

        public List<BaoLuu> timkiemBaoLuu(string MaBL)
        {
            return baoLuu.timkiemBaoLuu(MaBL);
        }

        public List<BaoLuu> TimKiemBaoLuuTrongCongNo(string MaBL)
        {
            return baoLuu.TimKiemBaoLuuTrongCongNo(MaBL);
        }

        #endregion Rap Code Bao Luu

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Rap Code Cong No

        public List<CongNo> HienThiTatCaCongNo()
        {
            return congNo.HienThiTatCaCongNo();
        }

        public bool themCongNo(CongNo cn)
        {
            return congNo.themCongNo(cn);
        }

        public bool xoaCongNo(string maLH, string maBL)
        {
            return congNo.xoaCongNo(maLH, maBL);
        }

        public bool capnhatCongNo(CongNo cn)
        {
            return congNo.capnhatCongNo(cn);
        }

        public List<CongNo> TimKiemCongNo(string MaBL, string MaLH)
        {
            return congNo.TimKiemCongNo(MaBL, MaLH);
        }

        public List<CongNo> TimKiemCongNoTheoMaLop(string maLH)
        {
            return congNo.TimKiemCongNoTheoMaLop(maLH);
        }

        public List<CongNo> TimKiemCongNoTheoMaBL(string maBL)
        {
            return congNo.TimKiemCongNoTheoMaBL(maBL);
        }

        #endregion Rap Code Cong No

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Ráp Code Giảng Viên

        public List<GiangVien> HienThiTatCaGiangVien()
        {
            return giangVien.HienThiTatCaGiangVien();
        }

        public bool themGiangVien(GiangVien gv)
        {
            return giangVien.themGiangVien(gv);
        }

        public bool xoaGiangVien(string maGV)
        {
            return giangVien.xoaGiangVien(maGV);
        }

        public bool capnhatGiangVien(GiangVien gv)
        {
            return giangVien.capnhatGiangVien(gv);
        }

        public List<GiangVien> timkiemGiangVien(string tmp)
        {
            return giangVien.timkiemGiangVien(tmp);
        }

        #endregion Ráp Code Giảng Viên

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Học Viên

        public List<HocVien> HienThiTatCaHocVien()
        {
            return hocVien.HienThiTatCaHocVien();
        }

        public bool themHocVien(HocVien hv)
        {
            return hocVien.themHocVien(hv);
        }

        public bool xoaHocVien(string maHV)
        {
            return hocVien.xoaHocVien(maHV);
        }

        public bool capnhatHocVien(HocVien hv)
        {
            return hocVien.capnhatHocVien(hv);
        }

        public List<HocVien> timkiemHocVienByName(string thv)
        {
            return hocVien.timkiemHocVienByName(thv);
        }

        public HocVien timkiemHocVienByID(string MaHV)
        {
            return hocVien.timkiemHocVienByID(MaHV);
        }

        public List<BaoLuu> timkiemHocVienTrongBaoLuu(string MaHV)
        {
            return hocVien.timkiemHocVienTrongBaoLuu(MaHV);
        }

        public List<HocVien> HienThiTatCaHocVienTheoLop(string MaLH)
        {
            return hocVien.HienThiTatCaHocVienTheoLop(MaLH);
        }

        #endregion Học Viên

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Ráp Code Khóa Học

        public List<KhoaHoc> LayToanBoKhoaHoc()
        {
            return khoaHoc.LayToanBoKhoaHoc();
        }

        public bool themKhoaHoc(KhoaHoc kh)
        {
            return khoaHoc.themKhoaHoc(kh);
        }

        public bool xoaKhoaHoc(string maKH)
        {
            return khoaHoc.xoaKhoaHoc(maKH);
        }

        public bool capnhatKhoaHoc(KhoaHoc kh)
        {
            return khoaHoc.capnhatKhoaHoc(kh);
        }

        public List<KhoaHoc> timkiemKhoaHoc(string tmp)
        {
            return khoaHoc.timkiemKhoaHoc(tmp);
        }

        #endregion Ráp Code Khóa Học

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Lớp Học

        public List<LopHoc> layToanBoLopHoc()
        {
            return lopHoc.layToanBoLopHoc();
        }

        public List<LopHoc> searchLopHoc(int makg)
        {
            return lopHoc.searchLopHoc(makg);
        }

        public bool themLopHoc(LopHoc lh)
        {
            return lopHoc.themLopHoc(lh);
        }

        public bool xoaLopHoc(string maLH)
        {
            return lopHoc.xoaLopHoc(maLH);
        }

        public bool capNhatLopHoc(LopHoc lh)
        {
            return lopHoc.capNhatLopHoc(lh);
        }

        #endregion Lớp Học

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Ráp Code Phòng Học

        public List<PhongHoc> LayToanBoPhongHoc()
        {
            return phongHoc.LayToanBoPhongHoc();
        }

        public bool themPhongHoc(PhongHoc ph)
        {
            return phongHoc.themPhongHoc(ph);
        }

        public bool xoaPhongHoc(string maPH)
        {
            return phongHoc.xoaPhongHoc(maPH);
        }

        public bool capnhatPhongHoc(PhongHoc ph)
        {
            return phongHoc.capnhatPhongHoc(ph);
        }

        public List<PhongHoc> timkiemPhongHoc(string tmp)
        {
            return phongHoc.timkiemPhongHoc(tmp);
        }

        #endregion Ráp Code Phòng Học

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Ráp Code Đợt Khai Giảng

        public List<DotKhaiGiang> LayToanBoDotKhaiGiang()
        {
            return dotkhaigiang.LayToanBoDotKhaiGiang();
        }

        public bool themDotKhaiGiang(DotKhaiGiang dkg)
        {
            return dotkhaigiang.themDotKhaiGiang(dkg);
        }

        public bool xoaDotKhaiGiang(string tenkg)
        {
            return dotkhaigiang.xoaDotKhaiGiang(tenkg);
        }

        public bool capnhatDotKhaiGiang(DotKhaiGiang dkg)
        {
            return dotkhaigiang.capnhatDotKhaiGiang(dkg);
        }

        #endregion Ráp Code Đợt Khai Giảng

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Ráp Code User

        public List<User> layToanBoUser()
        {
            return user.layToanBoUser();
        }

        public bool Register_Admin(User u)
        {
            return user.Register_Admin(u);
        }

        public bool Register_User(User u)
        {
            return user.Register_User(u);
        }

        public bool Delete_Amin(int mauser)
        {
            return user.Delete_Amin(mauser);
        }

        public bool Edit_Amin(User u)
        {
            return user.Edit_Amin(u);
        }

        #endregion Ráp Code User

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
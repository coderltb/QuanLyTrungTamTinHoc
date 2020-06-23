using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LopHocAccess : DatabaseAccess
    {
        public List<LopHoc> searchLopHoc(int makg)
        {
            #region Dùng Store Procedure

            List<LopHoc> dskh = new List<LopHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemLop");
            command.Parameters.Add("@MaDotKhaiGiang", SqlDbType.Int).Value = makg;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LopHoc lh = new LopHoc();
                lh.maLH = reader.GetInt32(0);
                var tmp = reader.GetString(1);
                lh.phongHoc.tenPG = tmp;
                lh.khoaHoc.tenKH = reader.GetString(2);
                lh.giangVien.tenGV = reader.GetString(3);
                lh.tietHoc = reader.GetString(4);
                lh.lichKhaiGiang = reader.GetDateTime(5);
                lh.lichKetThuc = reader.GetDateTime(6);
                lh.tinhTrang = reader.GetString(7);
                lh.soLuong = reader.GetInt32(8);
                lh.moLop = reader.GetBoolean(9);
                lh.phongHoc.maPH = reader.GetInt32(10);
                lh.dotkhaigiang._TenDotKhaiGiang = reader.GetString(11);
                dskh.Add(lh);
            }
            reader.Close();
            closeConnected();
            return dskh;

            #endregion Dùng Store Procedure
        }

        public List<LopHoc> layToanBoLopHoc()
        {
            #region Dùng Store Procedure

            List<LopHoc> dskh = new List<LopHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoLopHoc");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LopHoc lh = new LopHoc();
                lh.maLH = reader.GetInt32(0);
                var tmp = reader.GetString(1);
                lh.phongHoc.tenPG = tmp;
                lh.khoaHoc.tenKH = reader.GetString(2);
                lh.giangVien.tenGV = reader.GetString(3);
                lh.tietHoc = reader.GetString(4);
                lh.lichKhaiGiang = reader.GetDateTime(5);
                lh.lichKetThuc = reader.GetDateTime(6);
                lh.tinhTrang = reader.GetString(7);
                lh.soLuong = reader.GetInt32(8);
                lh.moLop = reader.GetBoolean(9);
                lh.phongHoc.maPH = reader.GetInt32(10);
                lh.dotkhaigiang._TenDotKhaiGiang = reader.GetString(11);
                dskh.Add(lh);
            }
            reader.Close();
            closeConnected();
            return dskh;

            #endregion Dùng Store Procedure
        }

        public bool themLopHoc(LopHoc lh)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemLopHoc");
            command.Parameters.Add("@MAPH", SqlDbType.Int).Value = lh.phongHoc.maPH;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = lh.khoaHoc.maKH;
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = lh.giangVien.maGV;
            command.Parameters.Add("@MOLOP", SqlDbType.Bit).Value = lh.moLop;
            command.Parameters.Add("@TIETHOC", SqlDbType.NVarChar).Value = lh.tietHoc;
            command.Parameters.Add("@LICHKHAIGIANG", SqlDbType.Date).Value = lh.lichKhaiGiang;
            command.Parameters.Add("@LICHKETTHUC", SqlDbType.Date).Value = lh.lichKetThuc;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = lh.tinhTrang;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = lh.soLuong;
            command.Parameters.Add("@MaDotKhaiGiang", SqlDbType.Int).Value = lh.dotkhaigiang._MaDotKhaiGiang;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaLopHoc(string maLH)
        {
            #region Dùng Store Procedure

            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaLopHoc");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = maLH;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v

            #endregion Dùng Store Procedure
        }

        public bool capNhatLopHoc(LopHoc lh)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaLopHoc");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = lh.maLH;
            command.Parameters.Add("@MAPH", SqlDbType.Int).Value = lh.phongHoc.maPH;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = lh.khoaHoc.maKH;
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = lh.giangVien.maGV;
            command.Parameters.Add("@MOLOP", SqlDbType.Bit).Value = lh.moLop;
            command.Parameters.Add("@TIETHOC", SqlDbType.NVarChar).Value = lh.tietHoc;
            command.Parameters.Add("@LICHKHAIGIANG", SqlDbType.Date).Value = lh.lichKhaiGiang;
            command.Parameters.Add("@LICHKETTHUC", SqlDbType.Date).Value = lh.lichKetThuc;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = lh.tinhTrang;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = lh.soLuong;
            command.Parameters.Add("@MaDotKhaiGiang", SqlDbType.Int).Value = lh.dotkhaigiang._MaDotKhaiGiang;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }
    }
}
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KhoaHocAccess : DatabaseAccess
    {
        #region Ráp Code

        public List<KhoaHoc> LayToanBoKhoaHoc()
        {
            #region Dùng Store Procedure

            List<KhoaHoc> dskh = new List<KhoaHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoKhoaHoc");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                KhoaHoc kh = new KhoaHoc();
                kh.maKH = reader.GetInt32(0);
                kh.tenKH = reader.GetString(1);
                kh.soLuongHVTD = reader.GetInt32(2);
                kh.thoiLuong = reader.GetInt32(3);
                kh.soLuongHVTT = reader.GetInt32(4);
                dskh.Add(kh);
            }
            reader.Close();
            closeConnected();
            return dskh;

            #endregion Dùng Store Procedure

            #region Dùng Text

            //List<KhoaHoc> dskh = new List<KhoaHoc>();
            //openConnected();
            //SqlCommand command = createCommandText("Select * from KHOAHOC"); //Dùng Text
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    KhoaHoc kh = new KhoaHoc();
            //    kh.maKH = reader.GetInt32(0);
            //    kh.tenKH = reader.GetString(1);
            //    kh.soLuongHVTD = reader.GetInt32(2);
            //    kh.thoiLuong = reader.GetInt32(3);
            //    kh.soLuongHVTT = reader.GetInt32(4);
            //    dskh.Add(kh);
            //}
            //reader.Close();
            //closeConnected();
            //return dskh;

            #endregion Dùng Text
        }

        public bool themKhoaHoc(KhoaHoc kh)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemKhoaHoc");
            command.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.tenKH;
            command.Parameters.Add("@SOLUONGHVTD", SqlDbType.Int).Value = kh.soLuongHVTD;
            command.Parameters.Add("@THOILUONG", SqlDbType.Int).Value = kh.thoiLuong;
            command.Parameters.Add("@SOLUONGHVTT", SqlDbType.Int).Value = kh.soLuongHVTT;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaKhoaHoc(string maKH)
        {
            #region Dùng Store Procedure

            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaKhoaHoc");
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = maKH;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v

            #endregion Dùng Store Procedure

            #region Dùng Text Hoặc Paramater

            //openConnected();
            //#region Parammeter
            ////SqlCommand command = createCommandText("DELETE FROM KHOAHOC WHERE MAKH = @MAKH");
            ////command.Parameters.Add("@MAKH", SqlDbType.Int).Value = maKH;
            //#endregion
            //#region Text
            ////SqlCommand command = createCommandText("DELETE FROM KHOAHOC WHERE MAKH = '" + maKH + "'");
            //#endregion
            //int kq = command.ExecuteNonQuery();
            //closeConnected();
            //return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v

            #endregion Dùng Text Hoặc Paramater
        }

        public bool capnhatKhoaHoc(KhoaHoc kh)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaKhoaHoc");
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = kh.maKH;
            command.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.tenKH;
            command.Parameters.Add("@SOLUONGHVTD", SqlDbType.Int).Value = kh.soLuongHVTD;
            command.Parameters.Add("@THOILUONG", SqlDbType.Int).Value = kh.thoiLuong;
            command.Parameters.Add("@SOLUONGHVTT", SqlDbType.Int).Value = kh.soLuongHVTT;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<KhoaHoc> timkiemKhoaHoc(string tmp)
        {
            List<KhoaHoc> dskh = new List<KhoaHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemKhoaHoc");
            command.Parameters.Add("@ChuoiTimKiem", SqlDbType.NVarChar).Value = tmp;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                KhoaHoc kh = new KhoaHoc();
                kh.maKH = dr.GetInt32(0);
                kh.tenKH = dr.GetString(1);
                kh.soLuongHVTD = dr.GetInt32(2);
                kh.thoiLuong = dr.GetInt32(3);
                kh.soLuongHVTT = dr.GetInt32(4);
                dskh.Add(kh);
            }
            dr.Close();
            closeConnected();
            return dskh;
        }

        #endregion Ráp Code
    }
}
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PhongHocAccess : DatabaseAccess
    {
        #region Ráp Code

        public List<PhongHoc> LayToanBoPhongHoc()
        {
            List<PhongHoc> dsph = new List<PhongHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoPhongHoc");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhongHoc ph = new PhongHoc();
                ph.maPH = reader.GetInt32(0);
                ph.tenPG = reader.GetString(1);
                ph.soLuong = reader.GetInt32(2);
                dsph.Add(ph);
            }
            reader.Close();
            closeConnected();
            return dsph;
        }

        public bool themPhongHoc(PhongHoc ph)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemPhongHoc");
            command.Parameters.Add("@TENPH", SqlDbType.NVarChar).Value = ph.tenPG;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = ph.soLuong;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaPhongHoc(string maPH)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaPhongHoc");
            command.Parameters.Add("@MAPH", SqlDbType.Int).Value = maPH;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatPhongHoc(PhongHoc ph)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaPhongHoc");
            command.Parameters.Add("@MAPH", SqlDbType.Int).Value = ph.maPH;
            command.Parameters.Add("@TENPH", SqlDbType.NVarChar).Value = ph.tenPG;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = ph.soLuong;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<PhongHoc> timkiemPhongHoc(string tmp)
        {
            List<PhongHoc> dsph = new List<PhongHoc>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemPhongHoc");
            command.Parameters.Add("@ChuoiTimKiem", SqlDbType.NVarChar).Value = tmp;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                PhongHoc ph = new PhongHoc();
                ph.maPH = dr.GetInt32(0);
                ph.tenPG = dr.GetString(1);
                ph.soLuong = dr.GetInt32(2);
                dsph.Add(ph);
            }
            dr.Close();
            closeConnected();
            return dsph;
        }

        #endregion Ráp Code
    }
}
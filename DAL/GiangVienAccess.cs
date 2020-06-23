using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class GiangVienAccess : DatabaseAccess
    {
        #region Ráp Code

        public List<GiangVien> HienThiTatCaGiangVien()
        {
            List<GiangVien> dsgv = new List<GiangVien>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoGiangVien");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GiangVien gv = new GiangVien();
                gv.maGV = reader.GetInt32(0);
                gv.tenGV = reader.GetString(1);
                gv.namSinh = reader.GetDateTime(2);
                gv.diaChi = reader.GetString(3);
                gv.sDT = reader.GetString(4);
                gv.trinhDo = reader.GetString(5);
                dsgv.Add(gv);
            }
            reader.Close();
            closeConnected();
            return dsgv;
        }

        public bool themGiangVien(GiangVien gv)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemGiangVien");
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = gv.maGV;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = gv.tenGV;
            command.Parameters.Add("@NAMSINH", SqlDbType.Date).Value = gv.namSinh;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = gv.diaChi;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = gv.sDT;
            command.Parameters.Add("@TRINHDO", SqlDbType.NVarChar).Value = gv.trinhDo;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaGiangVien(string maGV)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaGiangVien");
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = maGV;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatGiangVien(GiangVien gv)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaGiangVien");
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = gv.maGV;
            command.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = gv.tenGV;
            command.Parameters.Add("@NAMSINH", SqlDbType.Date).Value = gv.namSinh;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = gv.diaChi;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = gv.sDT;
            command.Parameters.Add("@TRINHDO", SqlDbType.NVarChar).Value = gv.trinhDo;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<GiangVien> timkiemGiangVien(string tmp)
        {
            List<GiangVien> dsgv = new List<GiangVien>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemGiangVien");
            command.Parameters.Add("@ChuoiTimKiem", SqlDbType.NVarChar).Value = tmp;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                GiangVien gv = new GiangVien();
                gv.maGV = dr.GetInt32(0);
                gv.tenGV = dr.GetString(1);
                gv.namSinh = dr.GetDateTime(2);
                gv.diaChi = dr.GetString(3);
                gv.sDT = dr.GetString(4);
                gv.trinhDo = dr.GetString(5);
                dsgv.Add(gv);
            }
            dr.Close();
            closeConnected();
            return dsgv;
        }

        #endregion Ráp Code
    }
}
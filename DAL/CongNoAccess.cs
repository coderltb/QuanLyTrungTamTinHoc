using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CongNoAccess : DatabaseAccess
    {
        #region Rap Code

        public List<CongNo> HienThiTatCaCongNo()
        {
            List<CongNo> dscn = new List<CongNo>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoCongNo");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CongNo cn = new CongNo();
                cn.maLH = reader.GetInt32(0);
                cn.maBL = reader.GetInt32(1);
                cn.noiDungThu = reader.GetString(2);
                cn.hocPhi = reader.GetDouble(3);
                cn.soTienNop = reader.GetDouble(4);
                cn.soTienConLai = reader.GetDouble(5);
                cn.soDu = reader.GetDouble(6);
                cn.trangThai = reader.GetString(7);
                dscn.Add(cn);
            }
            reader.Close();
            closeConnected();
            return dscn;
        }

        public bool themCongNo(CongNo cn)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemCongNo");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = cn.maLH;
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = cn.maBL;
            command.Parameters.Add("@NOIDUNGTHU", SqlDbType.NVarChar).Value = cn.noiDungThu;
            command.Parameters.Add("@HOCPHI", SqlDbType.Float).Value = cn.hocPhi;
            command.Parameters.Add("@SOTIENNOP", SqlDbType.Float).Value = cn.soTienNop;
            command.Parameters.Add("@SOTIENCONLAI", SqlDbType.Float).Value = cn.soTienConLai;
            command.Parameters.Add("@SODU", SqlDbType.Float).Value = cn.soDu;
            command.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = cn.trangThai;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaCongNo(string maLH, string maBL)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaCongNo");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = maLH;
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = maBL;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatCongNo(CongNo cn)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaCongNo");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = cn.maLH;
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = cn.maBL;
            command.Parameters.Add("@NOIDUNGTHU", SqlDbType.NVarChar).Value = cn.noiDungThu;
            command.Parameters.Add("@HOCPHI", SqlDbType.Float).Value = cn.hocPhi;
            command.Parameters.Add("@SOTIENNOP", SqlDbType.Float).Value = cn.soTienNop;
            command.Parameters.Add("@SOTIENCONLAI", SqlDbType.Float).Value = cn.soTienConLai;
            command.Parameters.Add("@SODU", SqlDbType.Float).Value = cn.soDu;
            command.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = cn.trangThai;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<CongNo> TimKiemCongNo(string MaBL, string MaLH)
        {
            List<CongNo> dscn = new List<CongNo>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemCongNo");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = MaBL;
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = MaLH;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CongNo cn = new CongNo();
                cn.maLH = reader.GetInt32(0);
                cn.maBL = reader.GetInt32(1);
                cn.noiDungThu = reader.GetString(2);
                cn.hocPhi = reader.GetDouble(3);
                cn.soTienNop = reader.GetDouble(4);
                cn.soTienConLai = reader.GetDouble(5);
                cn.soDu = reader.GetDouble(6);
                cn.trangThai = reader.GetString(7);
                dscn.Add(cn);
            }
            reader.Close();
            closeConnected();
            return dscn;
        }

        public List<CongNo> TimKiemCongNoTheoMaLop(string maLH)
        {
            List<CongNo> dscn = new List<CongNo>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemCongNoTheoMaLop");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = maLH;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CongNo cn = new CongNo();
                cn.maLH = reader.GetInt32(0);
                cn.maBL = reader.GetInt32(1);
                cn.noiDungThu = reader.GetString(2);
                cn.hocPhi = reader.GetDouble(3);
                cn.soTienNop = reader.GetDouble(4);
                cn.soTienConLai = reader.GetDouble(5);
                cn.soDu = reader.GetDouble(6);
                cn.trangThai = reader.GetString(7);
                dscn.Add(cn);
            }
            reader.Close();
            closeConnected();
            return dscn;
        }

        public List<CongNo> TimKiemCongNoTheoMaBL(string maBL)
        {
            List<CongNo> dscn = new List<CongNo>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemCongNoTheoMaBL");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = maBL;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CongNo cn = new CongNo();
                cn.maLH = reader.GetInt32(0);
                cn.maBL = reader.GetInt32(1);
                cn.noiDungThu = reader.GetString(2);
                cn.hocPhi = reader.GetDouble(3);
                cn.soTienNop = reader.GetDouble(4);
                cn.soTienConLai = reader.GetDouble(5);
                cn.soDu = reader.GetDouble(6);
                cn.trangThai = reader.GetString(7);
                dscn.Add(cn);
            }
            reader.Close();
            closeConnected();
            return dscn;
        }

        #endregion Rap Code
    }
}
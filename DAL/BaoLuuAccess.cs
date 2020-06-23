using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BaoLuuAccess : DatabaseAccess
    {
        #region Rap Code

        public List<BaoLuu> HienThiTatCaBaoLuu()
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoBaoLuu");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BaoLuu bl = new BaoLuu();
                bl.maBL = reader.GetInt32(0);
                bl.maLH = reader.GetInt32(1);
                bl.maHV = reader.GetInt32(2);
                bl.thoiGianBatDauBaoLuu = reader.GetDateTime(3);
                bl.thoiGianKetThucBaoLuu = reader.GetDateTime(4);
                bl.soTienBaoLuu = float.Parse(reader.GetDouble(5).ToString());
                dsbl.Add(bl);
            }
            reader.Close();
            closeConnected();
            return dsbl;
        }

        public List<BaoLuu> HienThiTatCaBaoLuuTheoLop(string maLH)
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoBaoLuuTheoLop");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = maLH;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BaoLuu bl = new BaoLuu();
                bl.maBL = reader.GetInt32(0);
                bl.maLH = reader.GetInt32(1);
                bl.maHV = reader.GetInt32(2);
                bl.thoiGianBatDauBaoLuu = reader.GetDateTime(3);
                bl.thoiGianKetThucBaoLuu = reader.GetDateTime(4);
                bl.soTienBaoLuu = float.Parse(reader.GetDouble(5).ToString());
                dsbl.Add(bl);
            }
            reader.Close();
            closeConnected();
            return dsbl;
        }

        public List<BaoLuu> HienThiTatCaBaoLuuTheoMaHV(string maHV)
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoBaoLuuTheoMaHocVien");
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = maHV;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BaoLuu bl = new BaoLuu();
                bl.maBL = reader.GetInt32(0);
                bl.maLH = reader.GetInt32(1);
                bl.maHV = reader.GetInt32(2);
                bl.thoiGianBatDauBaoLuu = reader.GetDateTime(3);
                bl.thoiGianKetThucBaoLuu = reader.GetDateTime(4);
                bl.soTienBaoLuu = float.Parse(reader.GetDouble(5).ToString());
                dsbl.Add(bl);
            }
            reader.Close();
            closeConnected();
            return dsbl;
        }

        public bool themBaoLuu(BaoLuu bl)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemBaoLuu");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = bl.maLH;
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = bl.maHV;
            command.Parameters.Add("@THOIGIANBATDAUBAOLUU", SqlDbType.Date).Value = bl.thoiGianBatDauBaoLuu;
            command.Parameters.Add("@THOIGIANKETTHUCBAOLUU", SqlDbType.Date).Value = bl.thoiGianKetThucBaoLuu;
            command.Parameters.Add("@SOTIENBAOLUU", SqlDbType.Float).Value = bl.soTienBaoLuu;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaBaoLuu(string maBL)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaBaoLuu");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = maBL;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatBaoLuu(BaoLuu bl)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaBaoLuu");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = bl.maBL;
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = bl.maLH;
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = bl.maHV;
            command.Parameters.Add("@THOIGIANBATDAUBAOLUU", SqlDbType.Date).Value = bl.thoiGianBatDauBaoLuu;
            command.Parameters.Add("@THOIGIANKETTHUCBAOLUU", SqlDbType.Date).Value = bl.thoiGianKetThucBaoLuu;
            command.Parameters.Add("@SOTIENBAOLUU", SqlDbType.Float).Value = bl.soTienBaoLuu;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<BaoLuu> timkiemBaoLuu(string MaBL)
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemBaoLuu");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = MaBL;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BaoLuu bl = new BaoLuu();
                bl.maBL = reader.GetInt32(0);
                bl.maLH = reader.GetInt32(1);
                bl.maHV = reader.GetInt32(2);
                bl.thoiGianBatDauBaoLuu = reader.GetDateTime(3);
                bl.thoiGianKetThucBaoLuu = reader.GetDateTime(4);
                bl.soTienBaoLuu = float.Parse(reader.GetDouble(5).ToString());
                dsbl.Add(bl);
            }
            reader.Close();
            closeConnected();
            return dsbl;
        }

        public List<BaoLuu> TimKiemBaoLuuTrongCongNo(string MaBL)
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemBaoLuuTrongCongNo");
            command.Parameters.Add("@MABL", SqlDbType.Int).Value = MaBL;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BaoLuu bl = new BaoLuu();
                bl.maBL = reader.GetInt32(0);
                bl.maLH = reader.GetInt32(1);
                bl.maHV = reader.GetInt32(2);
                bl.thoiGianBatDauBaoLuu = reader.GetDateTime(3);
                bl.thoiGianKetThucBaoLuu = reader.GetDateTime(4);
                bl.soTienBaoLuu = float.Parse(reader.GetDouble(5).ToString());
                dsbl.Add(bl);
            }
            reader.Close();
            closeConnected();
            return dsbl;
        }

        #endregion Rap Code
    }
}
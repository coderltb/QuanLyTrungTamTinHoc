using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HocVienAccess : DatabaseAccess
    {
        #region Rap COde

        public List<HocVien> HienThiTatCaHocVien()
        {
            List<HocVien> dshv = new List<HocVien>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoHocVien");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HocVien hv = new HocVien();
                hv.maHV = reader.GetInt32(0);
                hv.maLH = reader.GetInt32(1);
                hv.tenHV = reader.GetString(2);
                hv.namSinh = reader.GetDateTime(3);
                hv.diaChi = reader.GetString(4);
                hv.ngheNghiep = reader.GetString(5);
                hv.tinhTrang = reader.GetString(6);
                hv.sDT = reader.GetString(7);
                dshv.Add(hv);
            }
            reader.Close();
            closeConnected();
            return dshv;
        }

        public List<HocVien> HienThiTatCaHocVienTheoLop(string MaLH)
        {
            List<HocVien> dshv = new List<HocVien>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoHocVienTheoLop");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = MaLH;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HocVien hv = new HocVien();
                hv.maHV = reader.GetInt32(0);
                hv.maLH = reader.GetInt32(1);
                hv.tenHV = reader.GetString(2);
                hv.namSinh = reader.GetDateTime(3);
                hv.diaChi = reader.GetString(4);
                hv.ngheNghiep = reader.GetString(5);
                hv.tinhTrang = reader.GetString(6);
                hv.sDT = reader.GetString(7);
                dshv.Add(hv);
            }
            reader.Close();
            closeConnected();
            return dshv;
        }

        public bool themHocVien(HocVien hv)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("ThemHocVien");
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = hv.maLH;
            command.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = hv.tenHV;
            command.Parameters.Add("@NAMSINH", SqlDbType.Date).Value = hv.namSinh;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hv.diaChi;
            command.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = hv.ngheNghiep;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = hv.tinhTrang;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = hv.sDT;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaHocVien(string maHV)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("XoaHocVien");
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = maHV;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatHocVien(HocVien hv)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("SuaHocVien");
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = hv.maHV;
            command.Parameters.Add("@MALH", SqlDbType.Int).Value = hv.maLH;
            command.Parameters.Add("@TENHV", SqlDbType.NVarChar).Value = hv.tenHV;
            command.Parameters.Add("@NAMSINH", SqlDbType.Date).Value = hv.namSinh;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hv.diaChi;
            command.Parameters.Add("@NGHENGHIEP", SqlDbType.NVarChar).Value = hv.ngheNghiep;
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar).Value = hv.tinhTrang;
            command.Parameters.Add("@SDT", SqlDbType.Char).Value = hv.sDT;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public List<HocVien> timkiemHocVienByName(string thv)
        {
            List<HocVien> dshv = new List<HocVien>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemHocVienByName");
            command.Parameters.Add("@TimKiem", SqlDbType.NVarChar).Value = thv;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HocVien hv = new HocVien();
                hv.maHV = reader.GetInt32(0);
                hv.maLH = reader.GetInt32(1);
                hv.tenHV = reader.GetString(2);
                hv.namSinh = reader.GetDateTime(3);
                hv.diaChi = reader.GetString(4);
                hv.ngheNghiep = reader.GetString(5);
                hv.tinhTrang = reader.GetString(6);
                hv.sDT = reader.GetString(7);
                dshv.Add(hv);
            }
            reader.Close();
            closeConnected();
            return dshv;
        }

        public HocVien timkiemHocVienByID(string MaHV)
        {
            HocVien hv = new HocVien();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemHocVienByID");
            command.Parameters.Add("@MAHV", SqlDbType.NVarChar).Value = MaHV;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hv.maHV = reader.GetInt32(0);
                hv.maLH = reader.GetInt32(1);
                hv.tenHV = reader.GetString(2);
                hv.namSinh = reader.GetDateTime(3);
                hv.diaChi = reader.GetString(4);
                hv.ngheNghiep = reader.GetString(5);
                hv.tinhTrang = reader.GetString(6);
                hv.sDT = reader.GetString(7);
            }
            reader.Close();
            closeConnected();
            return hv;
        }

        public List<BaoLuu> timkiemHocVienTrongBaoLuu(string MaHV)
        {
            List<BaoLuu> dsbl = new List<BaoLuu>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("TimKiemHocVienTrongBaoLuu");
            command.Parameters.Add("@MAHV", SqlDbType.Int).Value = MaHV;
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

        #endregion Rap COde
    }
}
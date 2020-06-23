using System;

namespace DTO
{
    public class HocVien
    {
        private int mahv;

        public int maHV
        {
            get { return mahv; }
            set { mahv = value; }
        }

        private int malh;

        public int maLH
        {
            get { return malh; }
            set { malh = value; }
        }

        private string tenhv;

        public string tenHV
        {
            get { return tenhv; }
            set { tenhv = value; }
        }

        private DateTime namsinh;

        public DateTime namSinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }

        private string diachi;

        public string diaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string nghenghiep;

        public string ngheNghiep
        {
            get { return nghenghiep; }
            set { nghenghiep = value; }
        }

        private string tinhtrang;

        public string tinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        private string sdt;

        public string sDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
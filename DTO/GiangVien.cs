using System;

namespace DTO
{
    public class GiangVien
    {
        private int magv;

        public int maGV
        {
            get { return magv; }
            set { magv = value; }
        }

        private string tengv;

        public string tenGV
        {
            get { return tengv; }
            set { tengv = value; }
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

        private string sdt;

        public string sDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string trinhdo;

        public string trinhDo
        {
            get { return trinhdo; }
            set { trinhdo = value; }
        }
    }
}
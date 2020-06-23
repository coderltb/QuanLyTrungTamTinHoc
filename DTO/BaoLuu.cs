using System;

namespace DTO
{
    public class BaoLuu
    {
        private int mabl;

        public int maBL
        {
            get { return mabl; }
            set { mabl = value; }
        }

        private int malh;

        public int maLH
        {
            get { return malh; }
            set { malh = value; }
        }

        private int mahv;

        public int maHV
        {
            get { return mahv; }
            set { mahv = value; }
        }

        private DateTime thoigianbatdaubaoluu;

        public DateTime thoiGianBatDauBaoLuu
        {
            get { return thoigianbatdaubaoluu; }
            set { thoigianbatdaubaoluu = value; }
        }

        private DateTime thoigianketthucbaoluu;

        public DateTime thoiGianKetThucBaoLuu
        {
            get { return thoigianketthucbaoluu; }
            set { thoigianketthucbaoluu = value; }
        }

        private float sotienbaoluu;

        public float soTienBaoLuu
        {
            get { return sotienbaoluu; }
            set { sotienbaoluu = value; }
        }
    }
}
using System;

namespace DTO
{
    public class LopHoc
    {
        private int malh;

        public int maLH
        {
            get { return malh; }
            set { malh = value; }
        }

        public PhongHoc phongHoc = new PhongHoc();

        public KhoaHoc khoaHoc = new KhoaHoc();

        public GiangVien giangVien = new GiangVien();

        private bool molop;

        public bool moLop
        {
            get { return molop; }
            set { molop = value; }
        }

        private string tiethoc;

        public string tietHoc
        {
            get { return tiethoc; }
            set { tiethoc = value; }
        }

        private DateTime lichkhaigiang;

        public DateTime lichKhaiGiang
        {
            get { return lichkhaigiang; }
            set { lichkhaigiang = value; }
        }

        private DateTime lichketthuc;

        public DateTime lichKetThuc
        {
            get { return lichketthuc; }
            set { lichketthuc = value; }
        }

        private string tinhtrang;

        public string tinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }

        private int soluong;

        public int soLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public DotKhaiGiang dotkhaigiang = new DotKhaiGiang();
    }
}
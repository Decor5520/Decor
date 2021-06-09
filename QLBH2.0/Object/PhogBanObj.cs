using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0.Object
{
    class PhogBanObj
    {
        string mapb, tenpb, manv, tennv, maluong, mucluong, chucvu,email,thangtongket,chamcong,luongthucte,ghichu;

        public string MaPB
        {
            get { return mapb; }
            set { mapb = value; }
        }

        public string TenPB
        {
            get { return tenpb; }
            set { tenpb = value; }
        }

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        public string TenNV
        {
            get { return tennv; }
            set { tennv = value; }
        }

        public string MaLuong
        {
            get { return maluong; }
            set { maluong = value; }
        }

        public string MucLuong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }
        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ThangTongKet
        {
            get { return thangtongket; }
            set { thangtongket = value; }
        }
        public string Chamcong
        {
            get { return chamcong; }

            set { chamcong = value; }

        }
        public string TienLuongNhanDuoc
        {
            get { return luongthucte; }
            set { luongthucte = value; }
        }

        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }

        public PhogBanObj() { }
        public PhogBanObj(string mapb, string tenpb, string manv, string tennv, string maluong, string mucluong, string chucvu,string email,string thangtongket,string chamcong,string luongthucte,string ghichu)

        {
            this.manv = manv;
            this.tennv = tennv;
            this.mapb = mapb;
            this.maluong = maluong;
            this.tennv = tennv;
            this.mucluong = mucluong;
            this.ghichu = ghichu;
            this.email = email;
            this.chamcong = chamcong;
            this.chucvu = chucvu;
            this.luongthucte = luongthucte;
            this.thangtongket = thangtongket;
        }

    }
}
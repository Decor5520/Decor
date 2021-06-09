using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0.Object
{
    class BaoHiemObj
    {
        string manv,tennv, maluong, mabh, ngaycap, noicap,cmt, ghichu;

        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }

        public string MaLuong
        {
            get { return maluong; }
            set { maluong = value; }
        }

        public string MaBH
        {
            get { return mabh; }
            set { mabh = value; }
        }

        public string TenNhanVien
        {
            get { return tennv; }
            set { tennv = value; }
        }

        public string NoiCap
        {
            get { return noicap; }
            set { noicap = value; }
        }

        public string NgayCap
        {
            get { return ngaycap; }
            set { ngaycap = value; }
        }

        
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string SoCMT
        {
            get { return cmt; }
            set { cmt = value; }
        }
        public BaoHiemObj() { }
        public BaoHiemObj(string manv, string tennv, string maluong, string mabh, string noicap, string ngaycap,  string ghichu,string cmt)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.mabh = mabh;
            this.maluong = maluong;
            this.noicap = noicap;
            this.ngaycap = ngaycap;
            this.ghichu = ghichu;
            this.cmt = cmt;
           
        }

    }
}

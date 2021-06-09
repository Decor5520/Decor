using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0.Object
{
    class ThaiSanObj
    { 
         string manv, mabp, maphong, hoten, ngaybdnghi, ngaysinh,ngayback,trocap, ghichu;

    public string MaNV
    {
        get { return manv; }
        set { manv = value; }
    }

    public string MaBoPhan
    {
        get { return mabp; }
        set { mabp = value; }
    }

    public string MaPhong
    {
        get { return maphong; }
        set { maphong = value; }
    }

    public string Hoten
    {
        get { return hoten; }
        set { hoten = value; }
    }

    public string NgayBatDauNghi
    {
        get { return ngaybdnghi; }
        set { ngaybdnghi = value; }
    }

    public string NgaySinh
    {
        get { return ngaysinh; }
        set { ngaysinh = value; }
    }


    public string NgayQuayLai
    {
        get { return ngayback; }
        set { ngayback = value; }
    }
    public string TroCap
        {
            get { return trocap; }
            set { trocap = value; }
        }
    public string GhiChu
       {
            get { return ghichu; }
            set { ghichu = value; }
        }


        public ThaiSanObj() { }
    public ThaiSanObj(string manv, string mabp, string maphong, string hoten, string ngaybdnghi,string ngaysinh, string ngayback,string trocap,string ghichu)
    {
        this.manv = manv;
        this.mabp = mabp;
        this.maphong = maphong;
        this.trocap = trocap;
        this.ngaybdnghi = ngaybdnghi;
        this.ngayback = ngayback;
        this.ghichu = ghichu;
        this.manv = manv;
        this.hoten = hoten;   

    }

}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0
{
    class NguoiDung
    {
        private string tennguoidung, tendangnhap, matkhau;
        public NguoiDung()
        {
            tennguoidung = tendangnhap = matkhau = "";
        }
        public NguoiDung(string ten, string tk, string mk)
        {
            tennguoidung = ten;
            tendangnhap = tk;
            matkhau = mk;
        }
    }
}



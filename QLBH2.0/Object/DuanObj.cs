using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0.Object
{
    class DuanObj
    {
        string tenduan, bophan, truongban, ngaybd, ngaydukien, sdt, tiendo;

        public string TenDuAn
        {
            get { return tenduan; }
            set { tenduan = value; }
        }

        public string BoPhanDamNhiem
        {
            get { return bophan; }
            set { bophan = value; }
        }

        public string TruongBan
        {
            get { return truongban; }
            set { truongban = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string NgayBatDau
        {
            get { return ngaybd; }
            set { ngaybd = value; }
        }

        public string DuKienHoanhThanh
        {
            get { return ngaydukien; }
            set { ngaydukien = value; }
        }


        public string TienDo
        {
            get { return tiendo; }
            set { tiendo = value; }
        }
      
        public DuanObj() { }
        public DuanObj(string tenduan, string bophan, string truongban, string sdt, string tiendo, string ngaybd, string ngaydukien)
        {
            this.tenduan = tenduan;
            this.ngaydukien = ngaydukien;
            this.ngaybd = ngaybd;
            this.sdt = sdt;
            this.truongban = truongban;
            this.bophan = bophan;
            this.tiendo = tiendo;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH2._0.Object
{
    class PhanHoiObj
    {
        string nguoiphanhoi, chude, noidung;

        public string NguoiPhanHoi
        {
            get { return nguoiphanhoi; }
            set { nguoiphanhoi = value; }
        }

        public string Chude
        {
            get { return chude; }
            set { chude = value; }
        }

        public string NoiDung
        {
            get { return noidung; }
            set { noidung = value; }
        }

      
        public PhanHoiObj() { }
        public PhanHoiObj(string nguoiphanhoi, string chude, string noidung)
        {
            this.nguoiphanhoi = nguoiphanhoi;
            this.chude = chude;
            this.noidung = noidung;

        }

    }
}


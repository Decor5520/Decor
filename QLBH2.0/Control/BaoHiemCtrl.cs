using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBH2._0.Model;
using QLBH2._0.Object;

namespace QLBH2._0.Control
{
    class BaoHiemCtrl
    {
        BaoHiemMod bhMod = new BaoHiemMod();
        public DataTable GetData()
        {
            return bhMod.GetData();
        }
        public bool AddData(BaoHiemObj bhObj)
        {
            return bhMod.AddData(bhObj);
        }
        public bool UpdData(BaoHiemObj bhObj)
        {
            return bhMod.UpdData(bhObj);
        }

        public bool DelData(string manv)
        {
            return bhMod.DelData(manv);
        }
    }
}


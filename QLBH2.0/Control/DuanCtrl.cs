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
    class DuanCtrl
    {
        DuanMod bhMod = new DuanMod();
        public DataTable GetData()
        {
            return bhMod.GetData();
        }
        public bool AddData(DuanObj bhObj)
        {
            return bhMod.AddData(bhObj);
        }
        public bool UpdData(DuanObj bhObj)
        {
            return bhMod.UpdData(bhObj);
        }

        public bool DelData(string mada)
        {
            return bhMod.DelData(mada);
        }
    }
}

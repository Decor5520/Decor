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
    class ThaiSanCtrl
    {
        ThaiSanMod nvMod = new ThaiSanMod();
        public DataTable GetData()
        {
            return nvMod.GetData();
        }
        public bool AddData(ThaiSanObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool UpdData(ThaiSanObj nvObj)
        {
            return nvMod.UpdData(nvObj);
        }

        public bool DelData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}
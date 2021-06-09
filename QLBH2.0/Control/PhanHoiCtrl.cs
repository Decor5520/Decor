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
    class PhanHoiCtrl
    {
        PhanHoiMod bhMod = new PhanHoiMod();
        public DataTable GetData()
        {
            return bhMod.GetData();
        }
        public bool AddData(PhanHoiObj bhObj)
        {
            return bhMod.AddData(bhObj);
        }
     
    }
}


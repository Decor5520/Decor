using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBH2._0.Object;

namespace QLBH2._0.Model
{
    class PhanHoiMod
    {
        ConectToSQL cinn = new ConectToSQL();
        SqlCommand _cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            _cmd.CommandText = "select * from  PhanHoi";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cinn.Connection;
            try
            {
                cinn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cinn.CloseConn();
            }
            return dt;
        }


        public bool AddData(PhanHoiObj bhObj)
        {

            _cmd.CommandText = "Insert into PhanHoi Values (N'" + bhObj.NguoiPhanHoi + "',N'" + bhObj.Chude + "',N'" + bhObj.NoiDung + "')";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cinn.Connection;
            try
            {
                cinn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cinn.CloseConn();
            }
            return false;
        }

   



       
    }
}


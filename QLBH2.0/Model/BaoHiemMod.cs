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
    class BaoHiemMod
    {
        ConectToSQL conn = new ConectToSQL();
        SqlCommand _cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            _cmd.CommandText = "select * from  BaoHiem";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conn.CloseConn();
            }
            return dt;
        }

      
        public bool AddData(BaoHiemObj bhObj)
        {

            _cmd.CommandText = "Insert into BaoHiem Values ('" + bhObj.MaNV + "','" + bhObj.MaBH + "','" + bhObj.MaLuong + "',N'" + bhObj.TenNhanVien + "','" + bhObj.SoCMT + "',CONVERT(DATE,'" + bhObj.NgayCap + "',103),'" + bhObj.NoiCap + "',N'" + bhObj.GhiChu + "')";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }

        public bool UpdData(BaoHiemObj bhObj)
        {

            _cmd.CommandText = "Update BaoHiem Set  MaBH = N'" + bhObj.MaBH + "', MaLuong = '" + bhObj.MaLuong + "',TenNhanVien = N'" + bhObj.TenNhanVien + "',CMT = '" + bhObj.SoCMT + "', NgayCap = CONVERT(DATE,'" + bhObj.NgayCap + "',103),  NoiCap = N'" + bhObj.NoiCap + "', GhiChu = N'" + bhObj.GhiChu + "' Where MaNV = '" + bhObj.MaNV + "'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }



        public bool DelData(string manv)
        {
            _cmd.CommandText = "Delete BaoHiem Where MaNV = '" + manv + "'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
    }
}

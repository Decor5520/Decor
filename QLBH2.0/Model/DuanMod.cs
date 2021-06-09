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
    class DuanMod
    {
        ConectToSQL cnd = new ConectToSQL();
        SqlCommand _cd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            _cd.CommandText = "select * from  DuAn";
            _cd.CommandType = CommandType.Text;
            _cd.Connection = cnd.Connection;
            try
            {
                cnd.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cd.Dispose();
                cnd.CloseConn();
            }
            return dt;
        }


        public bool AddData(DuanObj bhObj)
        {

            _cd.CommandText = "Insert into DuAn Values ('" + bhObj.TenDuAn + "','" + bhObj.BoPhanDamNhiem + "',N'" + bhObj.TruongBan + "','" + bhObj.SDT + "','" + bhObj.TienDo + "',CONVERT(DATE,'" + bhObj.NgayBatDau + "',103),CONVERT(DATE,'" + bhObj.DuKienHoanhThanh + "',103))";
            _cd.CommandType = CommandType.Text;
            _cd.Connection = cnd.Connection;
            try
            {
                cnd.OpenConn();
                _cd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cd.Dispose();
                cnd.CloseConn();
            }
            return false;
        }

        public bool UpdData(DuanObj bhObj)
        {

            _cd.CommandText = "Update DuAn Set  BoPhanDamNhiem = '" + bhObj.BoPhanDamNhiem + "',TruongBan = N'" + bhObj.TruongBan + "',SDT = '" + bhObj.SDT + "',TienDo = N'" + bhObj.TienDo + "', NgayBatDau = CONVERT(DATE,'" + bhObj.NgayBatDau + "',103),DuKienHoanThanh = CONVERT(DATE,'" + bhObj.DuKienHoanhThanh + "',103) Where TenDuAn = '" + bhObj.TenDuAn + "'";
            _cd.CommandType = CommandType.Text;
            _cd.Connection = cnd.Connection;
            try
            {
                cnd.OpenConn();
                _cd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cd.Dispose();
                cnd.CloseConn();
            }
            return false;
        }



        public bool DelData(string ten)
        {
            _cd.CommandText = "Delete DuAn Where TenDuAn = '" + ten + "'";
            _cd.CommandType = CommandType.Text;
            _cd.Connection = cnd.Connection;
            try
            {
                cnd.OpenConn();
                _cd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cd.Dispose();
                cnd.CloseConn();
            }
            return false;
        }
    }
}

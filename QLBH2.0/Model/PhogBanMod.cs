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
    class PhogBanMod
    {
        ConectToSQL cn = new ConectToSQL();
        SqlCommand _cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            _cmd.CommandText = "select * from  PhongBan";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cn.Connection;
            try
            {
                cn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cn.CloseConn();
            }
            return dt;
        }

        public bool AddData(PhogBanObj bhObj)
        {

            _cmd.CommandText = "Insert into Phongban Values ('" + bhObj.MaPB + "',N'" + bhObj.TenPB + "','" + bhObj.MaNV + "',N'" + bhObj.TenNV + "','" + bhObj.MaLuong + "','" + bhObj.MucLuong + "','" + bhObj.ChucVu + "','" + bhObj.Email + "','" + bhObj.ThangTongKet + "','" + bhObj.Chamcong + "','" + bhObj.TienLuongNhanDuoc + "',N'" + bhObj.GhiChu + "')";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cn.Connection;
            try
            {
                cn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cn.CloseConn();
            }
            return false;
        }

        public bool UpdData(PhogBanObj bhObj)
        {

            _cmd.CommandText = "Update PhongBan Set  MaPB = '" + bhObj.MaPB + "', TenPB = N'" + bhObj.TenPB + "',MaNV = N'" + bhObj.MaNV + "', TenNV = N'" + bhObj.TenNV + "',MaLuong = N'" + bhObj.MaLuong + "',MucLuong = N'" + bhObj.MucLuong + "',Email = N'" + bhObj.Email + "',ThangTongKet = '" + bhObj.ThangTongKet + "',ChamCong = '" + bhObj.Chamcong + "',TienLuongNhanDuoc = N'" + bhObj.TienLuongNhanDuoc + "', GhiChu = N'" + bhObj.GhiChu + "' Where MaPB = '" + bhObj.MaPB + "'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cn.Connection;
            try
            {
                cn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cn.CloseConn();
            }
            return false;
        }



        public bool DelData(string manv)
        {
            _cmd.CommandText = "Delete PhongBan Where MaPB = '" + manv + "'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = cn.Connection;
            try
            {
                cn.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                cn.CloseConn();
            }
            return false;
        }
    }
}
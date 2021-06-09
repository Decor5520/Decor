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
    class ThaiSanMod
    {
        ConectToSQL cnn = new ConectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from   ThaiSann";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn.Connection;
            try
            {
                cnn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cnn.CloseConn();
            }
            return dt;
        }

        public bool AddData(ThaiSanObj nvObj)
        {

            cmd.CommandText = "Insert into ThaiSann values ('" + nvObj.MaNV + "',N'" + nvObj.MaBoPhan + "',N'" + nvObj.MaPhong+ "',N'" + nvObj.Hoten + "',CONVERT(DATE,'" + nvObj.NgayBatDauNghi + "',103),CONVERT(DATE,'" + nvObj.NgaySinh + "',103),CONVERT(DATE,'" + nvObj.NgayQuayLai + "',103),N'" + nvObj.TroCap + "','" + nvObj.GhiChu+ "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn.Connection;
            try
            {
                cnn.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cnn.CloseConn();
            }
            return false;
        }

        public bool UpdData(ThaiSanObj nvObj)
        {

            cmd.CommandText = "Update ThaiSann set  MaBoPhan =  N'" + nvObj.MaBoPhan + "', MaPhong = N'" + nvObj.MaPhong + "', Hoten = N'" + nvObj.Hoten + "', NgayBatDauNghi = CONVERT(DATE,'" + nvObj.NgayBatDauNghi + "',103),NgaySinh = CONVERT(DATE,'" + nvObj.NgaySinh + "',103),NgayQuayLai = CONVERT(DATE,'" + nvObj.NgayQuayLai + "',103), TroCap = N'" + nvObj.TroCap + "', Ghichu = N'" + nvObj.GhiChu + "' Where MaNV = '" + nvObj.MaNV + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn.Connection;
            try
            {
                cnn.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cnn.CloseConn();
            }
            return false;
        }



        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete ThaiSann Where MaNV = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn.Connection;
            try
            {
                cnn.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                cnn.CloseConn();
            }
            return false;
        }
    }
}
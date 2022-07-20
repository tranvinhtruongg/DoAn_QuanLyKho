using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLoaiHang :DBConnect
    {
        public DataTable LayDSLoaiHang()
        {
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAIHANG", con);
            da.Fill(dtMatHang);
            return dtMatHang;
        }
        public void ThemLoaiHang(string TenLoaiHang, string ID_KHO)
        {
            try
            {
                string sql = @"INSERT INTO LOAIHANG(TenLoaiHang,ID_KHO) VALUES (@TenLoaiHang, @ID_KHO)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@TenLoaiHang", SqlDbType.NVarChar);
                cmd.Parameters["@TenLoaiHang"].Value = TenLoaiHang;
                cmd.Parameters.Add("@ID_KHO", SqlDbType.NVarChar);
                cmd.Parameters["@ID_KHO"].Value = ID_KHO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public bool xoaLoaiHang(string ID)
        {
            try
            {
                // Ket noi
                con.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [dbo].[LOAIHANG] WHERE ID='{0}'", ID);
                SqlCommand cmd = new SqlCommand(SQL, con);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }
       
        public bool suaLoaiHang(string ID, String TenLoaiHang, string ID_KHO)
        {
            try
            {
                //ket noi
                con.Open();
                //query string 
                string SQL = string.Format(" update LOAIHANG set  TenLoaiHang = N'{0}', ID_KHO = '{1}' where ID = '{2}'", TenLoaiHang, ID_KHO, ID);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    // Query và kiểm tra
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }
    }
}

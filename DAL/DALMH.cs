using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMH :DBConnect
    {
        public DataTable LayDSLoaiHang()
        {
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAIHANG", con);
            da.Fill(dtMatHang);
            return dtMatHang;
        }
        public void ThemLoaiHang(string ID, string TenMH)
        {
            try
            {
                string sql = @"INSERT INTO LOAIHANG(ID,TenLH) VALUES (@ID, @TenLH)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters.Add("@TenLH", SqlDbType.NVarChar);
                cmd.Parameters["@TenLH"].Value = TenMH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
    
}

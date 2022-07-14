using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALQuanLy  :   DBConnect
    {
        public DataTable LayDSMatHang()
        {
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MATHANG", con);
            da.Fill(dtMatHang);
            return dtMatHang;
        }
        public void ThemMatHang(string ID, string TenMH, string ID_LoaiHang)
        {
            try
            {
                string sql = @"INSERT INTO MATHANG(ID,TenMH,ID_LoaiHang) VALUES (@ID, @TenMH, @ID_LoaiHang)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar);
                cmd.Parameters["@ID"].Value = ID;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar);
                cmd.Parameters["@TenMH"].Value = TenMH;
                cmd.Parameters.Add("@ID_LoaiHang", SqlDbType.NVarChar);
                cmd.Parameters["@ID_LoaiHang"].Value = ID_LoaiHang;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

            }

        }
    }
}

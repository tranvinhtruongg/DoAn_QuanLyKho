using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMatHang  :   DBConnect
    {
        public DataTable LayDSMatHang()
        {
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MATHANG", con);
            da.Fill(dtMatHang);
            return dtMatHang;
        }

        public void ThemMatHang(string TenMatHang, string ViTri, string ID_LH)
        {
            try
            {
                string sql = @"INSERT INTO MATHANG(TenMatHang,ViTri,ID_LH) VALUES ( @TenMH,@ViTri, @ID_LoaiHang)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar);
                cmd.Parameters["@TenMH"].Value = TenMatHang;
                cmd.Parameters.Add("@ViTri", SqlDbType.NVarChar);
                cmd.Parameters["@ViTri"].Value = ViTri;
                cmd.Parameters.Add("@ID_LoaiHang", SqlDbType.NVarChar);
                cmd.Parameters["@ID_LoaiHang"].Value = ID_LH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

            }
        }
        public bool xoaMatHang(string mamh)
        {
            try
            {
                // Ket noi
                con.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [dbo].[MATHANG] WHERE ID='{0}'", mamh);
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
        public bool suaMatHang(string ID, String TenMatHang, string ViTri, string ID_LH)
        {
            try
            {
                //ket noi
                con.Open();
                //query string 
                string SQL = string.Format(" update MATHANG set  TenMatHang = N'{0}', ViTri = '{1}',ID_LH='{2}' where ID = '{3}'", TenMatHang, ViTri, ID_LH, ID);
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

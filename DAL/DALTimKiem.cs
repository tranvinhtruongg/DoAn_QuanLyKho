using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALTimKiem : DBConnect
    {
        public DataTable layDataLH()
        {
            DataTable dtDSTimKiem = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TenLoaiHang FROM LoaiHang", con);
            da.Fill(dtDSTimKiem);
            return dtDSTimKiem;
        }
        public DataTable timKiem(string TenLoaiHang, string TenMatHang)
        {
            DataTable dtDSTimKiem = new DataTable();
            try
            {
                con.Open();
                string sql = string.Format("select DISTINCT MATHANG.ID,TenMatHang,ViTri,SoLuongTon,ID_LH " +
                                            "from LOAIHANG,MATHANG " +
                                            "where LOAIHANG.TenLoaiHang like N'%{0}%' and MATHANG.TenMatHang like  N'%{1}%' " +
                                            "and MATHANG.ID_LH = LOAIHANG.ID ", TenLoaiHang, TenMatHang);

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dtDSTimKiem);
                return dtDSTimKiem;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}

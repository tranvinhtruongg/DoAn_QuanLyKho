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
        public void timKiem(string TenLoaiHang, string TenMatHang)
        {
            try
            {
                con.Open();
                DataTable dtdstimkiem = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from mathang", con);

                string sql = string.Format(" select MATHANG.ID,TenMatHang,ViTri,SoLuongTon,ID_LH " +
                                            "from LOAIHANG,MATHANG " +
                                            "where LOAIHANG.TenLoaiHang=N'Đồng hồ' and MATHANG.ID_LH=LOAIHANG.ID ", TenLoaiHang, TenMatHang);
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}

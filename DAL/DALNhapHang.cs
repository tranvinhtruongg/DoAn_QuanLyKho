using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhapHang : DBConnect
    {
        public DataTable layDataMH()
        {
            DataTable dtDSTimKiem = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,TenMatHang FROM MatHang", con);
            da.Fill(dtDSTimKiem);
            return dtDSTimKiem;
        }
        public DataTable layMH()
        {
            string sqlQuery = "select MATHANG.TenMatHang,CTPHIEUNHAP.SoLuong,CTPHIEUNHAP.DonGia from MATHANG, CTPHIEUNHAP where MATHANG.ID = CTPHIEUNHAP.ID_MatHang";
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(sqlQuery, con);
            daa.Fill(dtMatHang);
            return dtMatHang;
        }
    }
}

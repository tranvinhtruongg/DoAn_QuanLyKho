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
        public DataTable LayDSMatHang(string ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MATHANG", con);
            DataTable dtMatHang = new DataTable();
            da.Fill(dtMatHang);
            return dtMatHang;
        }
    }
}

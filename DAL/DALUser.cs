using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUser:DBConnect
    {
       public DataTable DsTaiKhoan()
        {
            DataTable dsTaiKhoan = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN", con);
            da.Fill(dsTaiKhoan);
            return dsTaiKhoan;
        }
    }
}

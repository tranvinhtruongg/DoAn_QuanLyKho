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
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM MATHANG", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ThemMatHang()
        {
            
        }
    }
}

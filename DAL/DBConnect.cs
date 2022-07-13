using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con = new SqlConnection(@"Data source=DESKTOP-9FKG708\MSSQLSERVER01;Initial catalog=Da_QLKho;Integrated security=True");
    }
}

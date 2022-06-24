using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBConnect
    {
        protected SqlConnection con = new SqlConnection("server=.\\MSSQLSERVER01; database=[Da_QLKho];integrated security=true");
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection con = new SqlConnection(@"Data source=LAPTOP-5UFPVGTR\SQLEXPRESS01;Initial catalog=DA_QLKk;Integrated security=True");
    }
}

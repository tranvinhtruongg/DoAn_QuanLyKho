﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLUser
    {
        DALUser dal = new DALUser();
        public DataTable dsTaiKhoan()
        {
            return dal.DsTaiKhoan();
        }
    }
}

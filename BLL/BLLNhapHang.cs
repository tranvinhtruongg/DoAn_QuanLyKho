using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLNhapHang
    {
        DALNhapHang dal = new DALNhapHang();
        public DataTable layDataMH()
        {
            return dal.layDataMH();
        }
        public DataTable layMH()
        {
            return dal.layMH();
        }
    }
}


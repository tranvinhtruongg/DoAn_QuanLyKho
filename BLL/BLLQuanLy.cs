using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLQuanLy
    {
        DALQuanLy dal = new DALQuanLy();
        public DataTable LayDSMatHang(string ID)
        {
            return dal.LayDSMatHang(ID);
        }
    }
}

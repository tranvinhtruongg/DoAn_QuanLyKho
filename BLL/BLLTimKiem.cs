using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLTimKiem
    {
        DALTimKiem dal = new DALTimKiem();
        public DataTable timKiem(string tenLoaiHang,string tenMatHang)
        {
            return dal.timKiem(tenLoaiHang, tenMatHang);
        }
        public DataTable layDataLH()
        {
            return dal.layDataLH();
        }
        
    }
}

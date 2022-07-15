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
        public DataTable LayDSMatHang()
        {
            return dal.LayDSMatHang();
        }
        
        public void ThemMatHang(string ID, string TenMH, string ID_LoaiHang)
        {
            dal.ThemMatHang(ID, TenMH, ID_LoaiHang);
        }
        
    }
}

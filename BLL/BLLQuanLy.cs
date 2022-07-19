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
        
        public void ThemMatHang( string TenMH, string ViTri,string ID_LoaiHang)
        {
            dal.ThemMatHang( TenMH,ViTri, ID_LoaiHang);
        }
        public bool xoaMatHang(string mamh)
        {
            return dal.xoaMatHang(mamh);
        }
        public bool suaMatHang(string ID,string TenMatHang,string ViTri, string ID_LH)
        {
            return dal.suaMatHang(ID, TenMatHang, ViTri, ID_LH);
        }

    }
}

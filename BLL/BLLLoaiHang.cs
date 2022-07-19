using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLLoaiHang
    {
        DALLoaiHang dal = new DALLoaiHang();
        public DataTable LayDSLoaiHang()
        {
            return dal.LayDSLoaiHang();
        }
        public void ThemLoaiHang(string TenLoaiHang, string ID_KHO)
        {
            dal.ThemLoaiHang(TenLoaiHang, ID_KHO);
        }
        public bool xoaLoaiHang(string masv)
        {
            return dal.xoaLoaiHang(masv);
        }
        public bool suaLoaiHang(string ID, string TenLoaiHang, string ID_KHO)
        {
            return dal.suaLoaiHang(ID, TenLoaiHang, ID_KHO);
        }
    }
    
}

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
        public void ThemLoaiHang(string ID, string TenMH)
        {
            dal.ThemLoaiHang(ID, TenMH);
        }
        public bool xoaLoaiHang(string masv)
        {
            return dal.xoaLoaiHang(masv);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLMH
    {
        DALMH dal = new DALMH();
        public DataTable LayDSLoaiHang()
        {
            return dal.LayDSLoaiHang();
        }
        public void ThemLoaiHang(string ID, string TenMH)
        {
            dal.ThemLoaiHang(ID, TenMH);
        }
        public bool xoaLoaiHang(string malh)
        {
            return dal.xoaLoaiHang(malh);
        }
        public bool suaLoaiHang(string ID, string TenLoaiHang, string ID_KHO)
        {
            return dal.suaLoaiHang(ID,TenLoaiHang,ID_KHO);
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien dal = new DALNhanVien();
        public DataTable LayDSNhanVien()
        {
            return dal.LayDSNhanVien();
        }
        public void ThemNhanVien(string ID_NV, string Ten_NV, bool Gioitinh, string Email, string DienThoai, DateTime NamSinh, string DiaChi)
        {
            dal.ThemNhanVien(ID_NV, Ten_NV, Gioitinh, Email, DienThoai, NamSinh, DiaChi);
        }
    }
}

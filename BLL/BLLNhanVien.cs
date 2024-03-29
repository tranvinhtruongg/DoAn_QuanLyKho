﻿using System;
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
        public void ThemNhanVien( string Ten_NV, bool Gioitinh, string Email, string DienThoai, DateTime NamSinh, string DiaChi)
        {
            dal.ThemNhanVien( Ten_NV, Gioitinh, Email, DienThoai, NamSinh, DiaChi);
        }
        public bool xoaNhanVien(string ID)
        {
            return dal.xoaNhanVien(ID);
        }
        public bool suaNhanVien( string ID, String Ten_NV, bool Gioitinh, string Email, string Dienthoai, DateTime NamSinh, string DiaChi)
        {
            return dal.suaNhanVien(ID, Ten_NV, Gioitinh, Email, Dienthoai, NamSinh, DiaChi);
        }
    }
}

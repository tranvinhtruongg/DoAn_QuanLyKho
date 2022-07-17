﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien: DBConnect
    {
        public DataTable LayDSNhanVien()
        {
            DataTable dtDSNhanVien = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", con);
            da.Fill(dtDSNhanVien);
            return dtDSNhanVien;
        }
        public void ThemNhanVien(string ID_NV, string Ten_NV, bool Gioitinh, string Email, string DienThoai, DateTime NamSinh, string DiaChi)
        {
            try
            {
                string sql = @"INSERT INTO NHANVIEN(ID_NV,Ten_NV,Gioitinh,Email,Dienthoai,NamSinh, DiaChi) VALUES (@ID_NV, @Ten_NV, @Gioitinh,@Email,@Dienthoai,@NamSinh,@Diachi)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID_NV", SqlDbType.NVarChar);
                cmd.Parameters["@ID_NV"].Value = ID_NV;
                cmd.Parameters.Add("@Ten_NV", SqlDbType.NVarChar);
                cmd.Parameters["@Ten_NV"].Value = Ten_NV;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.Bit);
                cmd.Parameters["@Gioitinh"].Value = Gioitinh;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar);
                cmd.Parameters["@Email"].Value = Email;
                cmd.Parameters.Add("@Dienthoai", SqlDbType.NVarChar);
                cmd.Parameters["@Dienthoai"].Value = DienThoai;
                cmd.Parameters.Add("@NamSinh", SqlDbType.Date);
                cmd.Parameters["@Namsinh"].Value = NamSinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
                cmd.Parameters["@Diachi"].Value = DiaChi;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

            }

        }
    }
}
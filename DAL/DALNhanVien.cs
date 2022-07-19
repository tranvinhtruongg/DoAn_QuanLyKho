using System;
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
        public void ThemNhanVien( string Ten_NV, bool Gioitinh, string Email, string DienThoai, DateTime NamSinh, string DiaChi)
        {
            try
            {
                string sql = @"INSERT INTO NHANVIEN(Ten_NV,Gioitinh,Email,Dienthoai,NamSinh, DiaChi) VALUES (@Ten_NV, @Gioitinh,@Email,@Dienthoai,@NamSinh,@Diachi)";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
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
        public bool xoaNhanVien(string ID)
        {
            try
            {
                // Ket noi
                con.Open();
                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO-ID là đủ
                string SQL = string.Format("DELETE FROM [dbo].[NHANVIEN] WHERE ID='{0}'", ID);
                SqlCommand cmd = new SqlCommand(SQL, con);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }
        public bool suaNhanVien(string ID, String Ten_NV, bool Gioitinh,string Email,string Dienthoai, DateTime NamSinh, string DiaChi)
        {
            try
            {
                //ket noi
                con.Open();
                //query string 
                string SQL = string.Format(" update NHANVIEN set  Ten_NV = N'{0}', Gioitinh = '{1}',Email='{2}',Dienthoai='{3}',NamSinh='{4}',DiaChi='{5}' where ID = '{6}'", Ten_NV, Gioitinh, Email, Dienthoai, NamSinh, DiaChi,ID);
                using (SqlCommand cmd = new SqlCommand(SQL, con))
                {
                    // Query và kiểm tra
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }
            return false;
        }
    }
}

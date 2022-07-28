using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALXuatHang :DBConnect
    {
        public DataTable layDataMH()
        {
            DataTable dtDSTimKiem = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,TenMatHang FROM MatHang", con);
            da.Fill(dtDSTimKiem);
            return dtDSTimKiem;
        }
        //datagridview
        public DataTable layMH()
        {
            string sqlQuery = "select MATHANG.TenMatHang,MATHANG.SoLuongTon,MATHANG.ViTri ,MATHANG.ID_LH, PHIEUNHAP.ID_NhanVien from MATHANG, PHIEUNHAP where MATHANG.ID = PHIEUNHAP.ID_MatHang";
            DataTable dtMatHang = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(sqlQuery, con);
            daa.Fill(dtMatHang);
            return dtMatHang;
        }
        
        public bool nhapMatHang(int ID_MatHang, int SoLuong, DateTime NgayLap, int ID_NhanVien, int ID_Kho)
        {
            try
            {
                //string sql = @"INSERT INTO MATHANG(TenMatHang,ViTri,ID_LH) VALUES ( @TenMH,@ViTri, @ID_LoaiHang)";
                string sql = @"INSERT INTO PHIEUXUAT (SoLuong,NgayLap,ID_NhanVien,ID_Kho,ID_MatHang) VALUES (@SoLuong,@NgayLap,@ID_NhanVien,@ID_Kho,@ID_MatHang)    ";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ID_MatHang", SqlDbType.Int);
                cmd.Parameters["@ID_MatHang"].Value = ID_MatHang;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmd.Parameters["@SoLuong"].Value = SoLuong;
                cmd.Parameters.Add("@NgayLap", SqlDbType.DateTime);
                cmd.Parameters["@NgayLap"].Value = NgayLap;
                cmd.Parameters.Add("@ID_NhanVien", SqlDbType.Int);
                cmd.Parameters["@ID_NhanVien"].Value = ID_NhanVien;
                cmd.Parameters.Add("@ID_Kho", SqlDbType.Int);
                cmd.Parameters["@ID_Kho"].Value = ID_Kho;
                /////update soluongton
                ///
                string update = @"update MATHANG set SoLuongTon=SoLuongTon-@SoLuong where ID=@ID_MatHang";
                SqlCommand cmdd = new SqlCommand(update, con);
                cmdd.CommandType = CommandType.Text;
                cmdd.Parameters.Add("@ID_MatHang", SqlDbType.NVarChar);
                cmdd.Parameters["@ID_MatHang"].Value = ID_MatHang;
                cmdd.Parameters.Add("@SoLuong", SqlDbType.Int);
                cmdd.Parameters["@SoLuong"].Value = SoLuong;
                //int modified = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                cmdd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                return false;
            }
            return false;
            
        }
    }
}

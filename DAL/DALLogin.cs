using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public  class DALLogin:DBConnect
    {
        private static DALLogin instance;
        public static DALLogin Instance
        {
            get { if (instance == null) instance = new DALLogin(); return instance; }
            private set { instance = value; }
        }
        private DALLogin()
        {


        }
        public bool Login(string username, string password)
        {
            string query = "select * from TAIKHOAN where TenDangNhap=N'"+username+ "'and MatKhau=N'" +password+"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count>0;
        }
    }
}

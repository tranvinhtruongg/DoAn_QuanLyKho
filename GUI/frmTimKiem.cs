using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class frmTimKiem : Form
    {
        BLLTimKiem bll = new BLLTimKiem();
        public frmTimKiem()
        {
            InitializeComponent();
            loadtimkiem();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbLoaiHang.SelectedIndex == null && txbMatHang.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin,vui lòng nhập thông tin!");
            }
            else
            {
                MessageBox.Show("Tim kiếm thành công!");
                dgvTimKem.DataSource = bll.timKiem(cmbLoaiHang.Text, txbMatHang.Text);
            }
        }
        void loadtimkiem()
        {
            DataTable dt = bll.layDataLH();
            cmbLoaiHang.DataSource = dt;
            cmbLoaiHang.DisplayMember = "tenLoaiHang";//Word là tên trường bạn muốn hiển thị trong combobox
        }
    }
}

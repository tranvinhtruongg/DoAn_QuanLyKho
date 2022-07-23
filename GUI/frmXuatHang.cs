using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class frmXuatHang : Form
    {
        BLLXuatHang bll = new BLLXuatHang();
        public frmXuatHang()
        {
           
            InitializeComponent();
            loadMatHang();
        }
        void loadMatHang()
        {
            DataTable dt = bll.layDataMH();
            cbmMH.DataSource = dt;
            cbmMH.DisplayMember = "tenMatHang";//tenMatHang là tên trường bạn muốn hiển thị trong
            cbmMH.ValueMember = "ID";

        }
        void loadNhapHang()
        {
            DataTable dt = bll.layMH();
            dgvNhapMH.DataSource = dt;
        }
       


        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txbSoLuong.Text == "" && txbNhanVien.Text == "")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                var idMH = cbmMH.SelectedValue as int? ?? 0;
                //var mh=cbmMH.SelectedItem.
                bll.nhapMatHang(idMH, txbSoLuong.Text, dtpNS.Value, txbNhanVien.Text, txbIDKho.Text);
                MessageBox.Show("Thêm thành công");
                loadNhapHang();
                //loadMH();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txbNhanVien.Text = "";
            txbSoLuong.Text = "";
            txbIDKho.Text = "";
        }

        private void btnDSNhapMH_Click_1(object sender, EventArgs e)
        {
            loadNhapHang();
        }
    }
}

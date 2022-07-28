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
    public partial class frmNhapHang : Form
    {
        BLLNhapHang bll = new BLLNhapHang();
        public frmNhapHang()
        {
            InitializeComponent();
            loadMatHang();
        }
        void  loadMatHang()
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbSoLuong.Text == "" && txbNhanVien.Text == "")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                var idMH = cbmMH.SelectedValue as int? ?? 0;
                //var mh=cbmMH.SelectedItem.
                bll.nhapMatHang(idMH,int.Parse(txbSoLuong.Text),dtpNS.Value, int.Parse(txbNhanVien.Text), int.Parse(txbIDKho.Text));
                MessageBox.Show("Thêm thành công");
                loadNhapHang();
                //loadMH();
            }
        }

        private void btnDSNhapMH_Click(object sender, EventArgs e)
        {
            loadNhapHang();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbNhanVien.Text = "";
            txbSoLuong.Text = "";
            txbIDKho.Text = "";
        }

        private void dgvNhapMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

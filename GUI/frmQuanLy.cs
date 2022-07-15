using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLy : Form
    {
        BLLQuanLy bll =new BLLQuanLy();
        public frmQuanLy()
        {
            InitializeComponent();
            
        }
        void loadMH()
        {
            DataTable dt = bll.LayDSMatHang();
            dgvMH.DataSource = dt;
        }
        void loadLH()
        {
            DataTable dt = bll.LayDSLoaiHang();
            dgvMH.DataSource = dt;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            txbTenMH.Text = "";
            txbIDLH.Text = "";
            txbMaMH.Text = "";   
            txbMaLH.Text= "";
            txbTenLH.Text="";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txbMaMH.Text=="" || txbTenMH.Text=="" || txbIDLH.Text=="")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else if(txbMaLH.Text=="" || txbTenLH.Text=="")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }    
            else if(txbMaLH.Text!= null && txbTenLH.Text!=null)
            {
                bll.ThemLoaiHang(txbMaLH.Text, txbTenLH.Text);
                MessageBox.Show("Thêm thành công");
                loadLH();
            }    
            else 
            {
                bll.ThemMatHang(txbMaMH.Text, txbTenMH.Text, txbIDLH.Text);
                MessageBox.Show("Thêm thành công");
                loadMH();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnDSMH_Click(object sender, EventArgs e)
        {
            loadMH();
        }

        private void btnDSLH_Click(object sender, EventArgs e)
        {
            loadLH();
        }

        
    }
}

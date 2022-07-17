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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        BLLNhanVien bll = new BLLNhanVien();
        void loadDSNV()
        {
            DataTable dt = bll.LayDSNhanVien();
            dtgvNV.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbTenNV.Text = "";
            txbEmail.Text = "";
            txbDienthoai.Text = "";
            txbDiachi.Text = "";
        }

        private void btnHTNV_Click(object sender, EventArgs e)
        {
            loadDSNV();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cmbGT.Items.Add("True");
            cmbGT.Items.Add("False");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txbID.Text == "" || txbTenNV.Text == "" || txbEmail.Text == "" || txbDienthoai.Text=="" || txbDiachi.Text=="" )
            //{
            //    MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            //}
            //else if (txbID.Text == "" || txbTenNV.Text == ""|| txbEmail.Text=="" || txbDienthoai.Text=="")
            //{
            //    MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            //}
            //else if (txbID.Text != null && txbTenNV.Text != null)
            //{
            //    bll.ThemNhanVien(txbID.Text, txbTenNV.Text, cmbGT.Items, txbEmail.Text, txbDienthoai.Text, dtpNS.Value, txbDiachi.Text);
            //    MessageBox.Show("Thêm thành công");
            //    loadDSNV();
            //}
            //else
            //{
            //    bll.ThemMatHang(txbMaMH.Text, txbTenMH.Text, txbIDLH.Text);
            //    MessageBox.Show("Thêm thành công");
            //    loadDSNV();
            //}
        }
    }
}

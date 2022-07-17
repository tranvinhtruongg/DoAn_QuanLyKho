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
            if (txbID.Text == "" || txbTenNV.Text == "" || txbEmail.Text == "" || txbDienthoai.Text == "" || txbDiachi.Text == "")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                bll.ThemNhanVien(txbID.Text, txbTenNV.Text, cmbGT.Enabled, txbEmail.Text, txbDienthoai.Text, dtpNS.Value, txbDiachi.Text);
                MessageBox.Show("Thêm thành công");
                loadDSNV();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvNV.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dtgvNV.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                // Xóa
                if (bll.xoaNhanVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    loadDSNV();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                    loadDSNV();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }
    }
}


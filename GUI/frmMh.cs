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
    
    public partial class frmMh : Form
    {
        BLLMH bll = new BLLMH();
        public frmMh()
        {
            InitializeComponent();
        }
        void loadLH()
        {
            DataTable dt = bll.LayDSLoaiHang();
            dgvMH.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            loadLH();
        }

        
        private void frmMh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txbMaLH.Text = "";
            txbTenLH.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbMaLH.Text == "" || txbTenLH.Text == "" )
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                bll.ThemLoaiHang(txbMaLH.Text, txbTenLH.Text);
                MessageBox.Show("Thêm thành công");
                loadLH();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvMH.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                // Xóa
                if (bll.xoaLoaiHang(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    loadLH();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                    loadLH();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }
    }
}

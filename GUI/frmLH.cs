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
    
    public partial class frmLH : Form
    {
        BLLLoaiHang bll = new BLLLoaiHang();
        public frmLH()
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
            txbKho.Text = "";
            txbTenLH.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbTenLH.Text == "" || txbKho.Text == "" )
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                bll.ThemLoaiHang(txbTenLH.Text,txbKho.Text);
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
                MessageBox.Show("Hãy chọn loại hàng muốn xóa");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvMH.SelectedRows.Count > 0)
            {
                if (txbTenLH.Text != "" && txbKho.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvMH.SelectedRows[0];

                    string ID = (row.Cells[0].Value.ToString());
                    string TenLoaiHang = txbTenLH.Text;
                    string ID_KHO = txbKho.Text;
                    // Sửa
                    if (bll.suaLoaiHang(ID, TenLoaiHang, ID_KHO))
                    {
                        MessageBox.Show("Sửa thành công");
                        loadLH();
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn loại hàng muốn sửa");
            }
        }


        private void dgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMH.SelectedRows[0];
            txbTenLH.Text = row.Cells[1].Value.ToString();
            txbKho.Text = row.Cells[2].Value.ToString();
        }
    }
}

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
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            txbTenMH.Text = "";
            txbIDLH.Text = "";
            txbMaMH.Text = "";   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txbMaMH.Text=="" || txbTenMH.Text=="" || txbIDLH.Text=="")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
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
            if (dgvMH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvMH.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                // Xóa
                if (bll.xoaMatHang(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    loadMH();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                    loadMH();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
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

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvMH.SelectedRows.Count > 0)
            {
                if ( txbTenMH.Text != "" && txbIDLH.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvMH.SelectedRows[0];
                    string ID = (row.Cells[0].Value.ToString());
                    string TenMh = txbTenMH.Text;
                    string ID_LoaiHang = txbIDLH.Text;

                    // Sửa
                    if (bll.suaMatHang(ID, TenMh, ID_LoaiHang))
                    {
                        MessageBox.Show("Sửa thành công");
                        loadMH();
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
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

    }
}


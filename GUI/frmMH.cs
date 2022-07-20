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
    public partial class frmMH : Form
    {
        BLLMatHang bll = new BLLMatHang();
        public frmMH()
        {
            InitializeComponent();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            txbTenMH.Text = "";
            txbIDLH.Text = "";
            txbViTri.Text = "";
        }
        void loadMH()
        {
            DataTable dt = bll.LayDSMatHang();
            dgvMHH.DataSource = dt;
        }
        

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnDSLH_Click(object sender, EventArgs e)
        {
            loadMH();
        }

        

      

        

        private void frmMatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txbTenMH.Text == "" && txbIDLH.Text == "" && txbViTri.Text == "")
            {
                MessageBox.Show("Thêm không thành công,vui lòng nhập dữ liệu!");
            }
            else
            {
                bll.ThemMatHang(txbTenMH.Text, txbViTri.Text, txbIDLH.Text);
                MessageBox.Show("Thêm thành công");
                loadMH();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMHH.SelectedRows.Count > 0)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvMHH.SelectedRows[0];
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

        private void dgvMHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMHH.SelectedRows[0];
            txbTenMH.Text = row.Cells[1].Value.ToString();
            txbViTri.Text = row.Cells[2].Value.ToString();
            txbIDLH.Text = row.Cells[4].Value.ToString();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            if (dgvMHH.SelectedRows.Count > 0)
            {
                if (txbTenMH.Text != "" && txbViTri.Text != "" && txbIDLH.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvMHH.SelectedRows[0];

                    string ID = (row.Cells[0].Value.ToString());
                    string TenMatHang = txbTenMH.Text;
                    string ViTri = txbViTri.Text;
                    string ID_LH = txbIDLH.Text;

                    // Sửa
                    if (bll.suaMatHang(ID, TenMatHang, ViTri, ID_LH))
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


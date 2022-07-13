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
            loadMH();
        }
        void loadMH()
        {
            DataTable dt = bll.LayDSMatHang();
            dgvMH.DataSource = dt;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            //xoa trang
            //XoaTrangChiTiet();
            //Cam nhap
            //HienChiTiet(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

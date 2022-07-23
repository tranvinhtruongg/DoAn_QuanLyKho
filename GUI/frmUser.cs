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
    public partial class frmUser : Form
    {
        BLLUser bll = new BLLUser();
        int index = -1;
        List<string> listTkType = new List<string>() { "admin", "user" };
        public frmUser()
        {
            InitializeComponent();
            LoadDsTK();

        }
        void LoadDsTK()
        {
            cboType.DataSource = listTkType;
            DataTable dt = bll.dsTaiKhoan();
            dtgvUser.DataSource = dt;
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txbTaiKhoan.Text = dtgvUser.Rows[index].Cells[0].Value.ToString();
            txbMatkhau.Text= dtgvUser.Rows[index].Cells[1].Value.ToString();
            
        }
    }
}

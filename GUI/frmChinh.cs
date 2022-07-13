using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmQuanLy frmQuanLy = new frmQuanLy();
            //frmQuanLy.Show();
            try
            {
                int x = int.Parse("a");
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
       
    }
}

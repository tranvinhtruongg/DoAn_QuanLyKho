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
        //private void btnNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    frmQuanLy f = new frmQuanLy();
        //    if (ExistForm(f)) return;
        //    f.MdiParent = this;
        //    f.Show();
        //}
        public bool ExistForm(Form form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnNhapMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMH f = new frmMH();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnNhapLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLH f = new frmLH();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnTimKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
    }
}

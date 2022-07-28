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

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapHang f = new frmNhapHang();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUser f = new frmUser();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }
        public event EventHandler Logout;
        public bool isExit=true;
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            //btnNhanVien.Enabled = btnUser.Enabled = false;
        }

        private void btnXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXuatHang f = new frmXuatHang();
            if (ExistForm(f)) return;
            f.MdiParent = this;
            f.Show();
        }

        private void báo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report r = new Report();
            if (ExistForm(r)) return;
            r.MdiParent = this;
            r.Show();
        }
    }
}

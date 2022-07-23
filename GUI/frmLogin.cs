using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace GUI
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection();
        public frmLogin()
        {
            InitializeComponent();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         bool Login(string username, string password)
        {
            return DALLogin.Instance.Login(username, password); 
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            if(Login(username,password ))
            {
                frmChinh f = new frmChinh();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mặt khẩu", "Lỗi", MessageBoxButtons.OK);
                txtUser.Focus();
                return;
            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as frmChinh).isExit = false;
            (sender as frmChinh).Close();
            this.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

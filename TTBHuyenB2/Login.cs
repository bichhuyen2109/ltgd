using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBHuyenB2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int soLan = 3;
        bool co = true;
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text != "admin")
            {
                MessageBox.Show("Sai thông tin đăng nhập");
                soLan--;
                co = false;
                //Nhập quá 3 lần thì thoát ứng dụng
                if (soLan == 0)
                {
                    Application.Exit();
                }
            }
            else
            {
                Bai23.tenDN = txtTenDN.Text;
                this.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!co)
            {
                Application.Exit();
            }
        }
    }
}

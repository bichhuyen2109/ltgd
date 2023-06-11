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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, tong =0;

            try
            {
                n = Int32.Parse(txtN.Text);

                for (int i = 1; i <= n; i++)
                {
                    tong += i;
                }

                txtTong.Text = tong.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Nhập sai định dạng");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

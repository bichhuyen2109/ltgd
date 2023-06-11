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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int so1, so2, kq = 0;
            string giatribt;
            try
            {
                so1 = int.Parse(txtSo1.Text);
                so2 = int.Parse(txtSo2.Text);
                giatribt = ((Button)sender).Text;
                switch (giatribt)
                {
                    case "+":
                        kq = so1 + so2;
                        break;
                    case "-":
                        kq = so1 - so2;
                        break;
                    case "*":
                        kq = so1 * so2;
                        break;
                    case "/":
                        kq = so1 / so2;
                        break;
                    default:
                        break;
                }
                lbKq.Text = kq.ToString();
                txtSo1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập hai số");
                throw;
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Không chia cho số 0");
                throw;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

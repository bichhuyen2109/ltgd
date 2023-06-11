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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int so1, so2;
            double kq = 0;
            string giatribt = "";
            RadioButton bt = (RadioButton)sender;
            try { 
            so1 = int.Parse(txtN1.Text);
            so2 = int.Parse(txtN2.Text);
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
            txtN1.Focus();
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

        private void btTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

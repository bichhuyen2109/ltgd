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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        int ketqua = 0;
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            string[] pheptoan = { "+", "-", "/", "*" };
            Random rand = new Random();
            int index;
            so1 = rand.Next(100);
            so2 = rand.Next(100);
            index = rand.Next(4);

            if (index == 3 && so2 == 0)
            {
                so2 = rand.Next(100);
            }

            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbDau.Text = pheptoan.ToString();
            switch(index)
            {
                case 0:
                    ketqua = so2 + so1;
                    break;
                case 1:
                    ketqua = so1 - so2;
                    break;
                case 2:
                    ketqua = so2 / so1;
                    break;
                case 3:
                    ketqua = so1 * so2;
                    break;
                default:
                    ketqua = so1 + so2;
                    break;
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int traloi;
            try
            {
                traloi = int.Parse(txtTraLoi.Text);
                if (traloi == ketqua)
                {
                    lbKetQua.Text = "Đúng";
                }
                else
                {
                    lbKetQua.Text = "sai, kết quả là" + ketqua.ToString();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text=="0"&& txtTraLoi.Text == String.Empty)
            {                
                    return;
            }
            txtTraLoi.Text += b.Text;
            txtTraLoi.Focus();
            txtTraLoi.SelectionStart = txtTraLoi.Text.Length;
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            string chuoi, kytudau;
            chuoi = txtTraLoi.Text;
            kytudau = chuoi.Substring(0, 1);
            if (kytudau=="-")
            {
                txtTraLoi.Text = chuoi.Remove(0, 1);
            }
            else
            {
                txtTraLoi.Text = "-" + chuoi;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string chuoi;
            chuoi=txtTraLoi.Text;
            if (chuoi!=String.Empty)
            {
                chuoi = chuoi.Remove(chuoi.Length - 1, 1);
            }
        }
    }
}

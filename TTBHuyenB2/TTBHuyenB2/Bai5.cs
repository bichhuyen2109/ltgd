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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
       int diem = 0;
        private void btQuaySo_Click(object sender, EventArgs e)
        {
            int so1, so2, so3, tong = 0;
            Random rand = new Random();
            so1 = rand.Next(7);
            so2 = rand.Next(7);
            so3 = rand.Next(7);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            tong = so1 + so2 + so3;
            if(rd3.Checked)
                {
                    if (tong < 10)
                        diem += 10;
                    else
                        diem -= 10;
                }
             else
                {
                    if(tong < 10)
                        diem -= 10;
                    else
                        diem += 10;
                }
            lbDiem.Text = diem.ToString();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            rb3.Checked = true;
            rb3.BackColor = Color.BurlyWood;
            rb11.BackColor = Color.LightBlue;
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            rb3.BackColor = Color.BurlyWood;
            rb11.BackColor = Color.LightBlue;
        }

        private void rb11_CheckedChanged(object sender, EventArgs e)
        {
            rb11.BackColor = Color.BurlyWood;
            rb3.BackColor = Color.LightBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

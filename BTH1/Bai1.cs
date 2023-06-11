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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btSoSanh_Click(object sender, EventArgs e)
        {
            int soA, soB, kq;
            string chuoiA, chuoiB;

            chuoiA = txtSoA.Text;
            chuoiB = txtSoB.Text;

            soA = Int32.Parse(chuoiA);
            soB = Convert.ToInt32(chuoiB);

            kq = (soA > soB ? soA : soB);

            txtKQ.Text = "Số lớn nhất là:" + kq.ToString();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}

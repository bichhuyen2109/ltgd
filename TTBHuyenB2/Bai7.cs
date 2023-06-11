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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        int[] mangGiaDV = { 100000, 120000, 200000, 800000 };
        private void Bai7_Load(object sender, EventArgs e)
        {
            lbCaoVoi.Text = String.Format("{0:N}", mangGiaDV[0]);
            lbTayTrang.Text = String.Format("{0:N}", mangGiaDV[1]);
            lbChupHinh.Text = String.Format("{0:N}", mangGiaDV[2]);
            lbTram.Text = String.Format("{0:N}", mangGiaDV[3]);
            chkCaoVoi.Enabled = chkChupHinh.Enabled = chkTayTrang.Enabled = false;
            numTramRang.Enabled = false;
            btTinhTien.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                chkCaoVoi.Enabled = chkChupHinh.Enabled = chkTayTrang.Enabled = false;
                numTramRang.Enabled = false;
                btTinhTien.Enabled = false;
            }
            else
            {
                chkCaoVoi.Enabled = chkChupHinh.Enabled = chkTayTrang.Enabled = true;
                numTramRang.Enabled = true;
                btTinhTien.Enabled = true;
            }
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            if (chkCaoVoi.Checked)
            {
                tongTien += mangGiaDV[0];

            }
            if (chkTayTrang.Checked)
            {
                tongTien += mangGiaDV[1];

            }
            if (chkChupHinh.Checked)
            {
                tongTien += mangGiaDV[2];

            }
            tongTien += (Convert.ToInt32(numTramRang.Value) * mangGiaDV[3]);
            txtTongTien.Text = String.Format("{0:N}", tongTien);
        }

        private void lbCaoVoi_Click(object sender, EventArgs e)
        {

        }
    }
} 


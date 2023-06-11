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
    public partial class Cau12 : Form
    {
        public Cau12()
        {
            InitializeComponent();
        }
        int dx, dy;
        bool trangthai;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PicBall.Right>ClientRectangle.Width || PicBall.Left<0)
            {
                dx = -dx;
            }
            if (PicBall.Bottom>ClientRectangle.Height || PicBall.Top<0)
            {
                dy = -dy;
            }
            PicBall.Top += dy;
            PicBall.Left += dx;
        }

        private void Cau12_Load(object sender, EventArgs e)
        {
            dx = 8;dy = 10;
            trangthai = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (trangthai==true)
            {
                timer1.Stop();
                trangthai = false;
            }
            else
            {
                timer1.Start();
                trangthai = true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}

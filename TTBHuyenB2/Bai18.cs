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
    public partial class Bai18 : Form
    {
        public Bai18()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        string path;
        Point p;
        PictureBox picAnh;
        int sl;
        #endregion

        private void Bai18_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\im\";
            RandomIM();
            sl = 0;
        }

        private void RandomIM()
        {
            Random rand = new Random();
            int so;
            picAnh = new PictureBox();
            sl++;
            picAnh.Name = "pic"+sl.ToString();    
            so = rand.Next(1, 8);
            picAnh.Image = Image.FromFile(path + so + ".jpg");
            picAnh.Width = picAnh.Height = 150;
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;

            picAnh.BringToFront();

            picAnh.MouseDown+=picAnh_MouseDown;
            picAnh.MouseMove+=picAnh_MouseMove; 
            picAnh.MouseUp+=picAnh_MouseUp;

            this.Controls.Add(picAnh);



           
        }

        

        private void picAnh_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void picAnh_MouseMove(object sender, MouseEventArgs e)
        {
            int dx, dy;
            if (e.Button==MouseButtons.Left)
            {
                dx = e.Location.X - p.X;
                dy = e.Location.Y - p.Y;

                picAnh.Left += dx;
                picAnh.Top += dy; 
            }
        }

        private void picAnh_MouseUp(object sender, MouseEventArgs e)
        {
            if (flpPicAnh.Bounds.Contains(picAnh.Bounds))
            {
                flpPicAnh.Controls.Add(picAnh);
                RandomIM();
            }
        }
    }
}

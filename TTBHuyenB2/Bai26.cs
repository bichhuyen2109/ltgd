using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTBHuyenB2
{
    public partial class Bai26 : Form
    {
        private object linearGradientMode;

        public Bai26()
        {
            InitializeComponent();
        }

        private void Bai26_Load(object sender, EventArgs e)
        {

        }

        private void Bai26_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush;
            HatchBrush hatchBruch;
            LinearGradientBrush linearGradientBrush;    
            TextureBrush textureBrush;
            Image image;
            StringFormat stringFormat=new StringFormat();

            string chuoi = "HELLO";
            Font font = new Font("Arial",50,FontStyle.Bold);

            solidBrush = new SolidBrush(Color.Green);
            hatchBruch = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Yellow, Color.Red);
            linearGradientBrush = new LinearGradientBrush(new Rectangle(10, 10, 10, 10),
                Color.Blue, Color.White, LinearGradientMode.Horizontal);
            image = Image.FromFile(@"D:\Lập Trình Giao Diện\TTBHuyenB2\im\2.jpg");
            textureBrush =new TextureBrush(image);

            
            //2
            stringFormat.Alignment = StringAlignment.Far;
            g.DrawString(chuoi, font, solidBrush, ClientRectangle, stringFormat);

            //4
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Far; 
            g.DrawString(chuoi, font, textureBrush, ClientRectangle, stringFormat);

            //1
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            g.DrawString(chuoi, font, hatchBruch, ClientRectangle, stringFormat);

            //3
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Far;
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(chuoi, font, linearGradientBrush, ClientRectangle, stringFormat);

           
            
        }
    }
}

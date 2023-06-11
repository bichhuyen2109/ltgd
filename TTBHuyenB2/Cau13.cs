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
    public partial class Cau13 : Form
    {
        public Cau13()
        {
            InitializeComponent();
        }
        #region BienToanCuc
        int soNguoiChoiChon;
        int soLanChoi;
        string s;
        #endregion

        private void BT()
        {

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            string path;
            s =Application.StartupPath + @"\HinhXucXac\";
            Button b = (Button)sender;
            soNguoiChoiChon = int.Parse(b.Text);
            path =s + soNguoiChoiChon + ".bmp";
            picC.Image = Image.FromFile(path);
        }

        private void Play()
        {
            string path, ketqua, chuoigiatri;
            int soRandom;
            Random rand = new Random();
            soRandom = rand.Next(1, 7);
            soLanChoi++;
            path = s + soRandom + ".bmp";
            picR.Image = Image.FromFile(path);
            if (soNguoiChoiChon == soRandom)
            {
                ketqua = "Thắng";
            }
            else
            {
                ketqua = "Thua";
            }
            chuoigiatri = string.Format("{0}. {1} (Đoán {2} ra {3})", soLanChoi, ketqua, soNguoiChoiChon, soRandom);
            ListResult.Items.Add(chuoigiatri);
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Cau13_Load(object sender, EventArgs e)
        {
            soNguoiChoiChon = 1;
            soLanChoi = 0;
        }

        private void Reset()
        {
            ListResult.Items.Clear();   
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Play();
                    return true;
                case Keys.Escape:
                    Reset();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

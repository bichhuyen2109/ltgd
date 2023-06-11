using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TTBHuyenB2
{
    public partial class Bai25 : Form
    {
        public Bai25()
        {
            InitializeComponent();
        }
        public void HienThiODia()
        {
            string[] drivers;
            TreeNode treeNode;
            drivers = Directory.GetLogicalDrives();
            foreach (string item in drivers)
            {
                treeNode = new TreeNode(item);
                treefolder.Nodes.Add(treeNode);
                treeNode.Nodes.Add("tam");
            }
        }

        private void Bai25_Load(object sender, EventArgs e)
        {
            HienThiODia();
        }

        private void treefolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node;
            string[] dSThuMucCon;
            node = e.Node;
            node.Nodes.Clear();
            dSThuMucCon = Directory.GetDirectories(node.FullPath);
            foreach (string item in dSThuMucCon)
            {
                TreeNode n = new TreeNode(Path.GetFileName(item));
                node.Nodes.Add(n);
                n.Nodes.Add("tam");
            }
        }

        private void treefolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node;
            string[] dSTapTin;
            node = e.Node;
            flowThum.Controls.Clear();
            dSTapTin = Directory.GetFiles(node.FullPath);
            foreach (string item in dSTapTin)
            {
                if (item.ToLower().EndsWith(".jpg") ||
                    item.ToLower().EndsWith(".jpeg") ||
                    item.ToLower().EndsWith(".png"))
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile("Image");
                    pic.Width = pic.Height = 100;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Cursor = Cursors.Hand;
                    flowThum.Controls.Add(pic);
                    pic.Click += Pic_Click;
                }

            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            picview.Image = ((PictureBox)sender).Image;
        }
    }
}

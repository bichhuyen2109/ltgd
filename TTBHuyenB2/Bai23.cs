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
    public partial class Bai23 : Form
    {
        public static string tenDN = "";
        public Bai23()
        {
            Login f = new Login();
            f.ShowDialog();
            InitializeComponent();
        }
        private void Bai23_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = tenDN;
            cbbQueQuan.Items.AddRange(new string[] { "Hồ Chí Minh", "Khánh Hòa", "Hà Nội" });
            lvNhanVien.View = View.Details;
            lvNhanVien.GridLines = true;
            lvNhanVien.FullRowSelect = true;

            lvNhanVien.Columns[0].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[1].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[2].Width = (int)(lvNhanVien.Width * 0.25);
            lvNhanVien.Columns[3].Width = (int)(lvNhanVien.Width * 0.25);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if (txtTen.Text != "")
            {
                item = new ListViewItem(txtTen.Text);//cot 1
                item.SubItems.Add(dtNgaySinh.Value.ToString("dd/MM/yyyy"));//cot 2
                item.SubItems.Add(rbNam.Checked ? "Nam" : "Nữ");//cot 3
                item.SubItems.Add(cbbQueQuan.SelectedItem.ToString());
                item.ImageIndex = (rbNam.Checked ? 0 : 1);

                lvNhanVien.Items.Add(item);
                txtTen.Text = "";
                txtTen.Focus();
            }
        }
     
        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvNhanVien.SelectedItems)
            {
                lvNhanVien.Items.Remove(item);
            }   
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gioiTinh = "";
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                txtTen.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtNgaySinh.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                gioiTinh = lvNhanVien.SelectedItems[0].SubItems[2].Text;
                if (gioiTinh == "Nam")
                {
                    rbNam.Checked = true;
                }
                else
                    rbNu.Checked = true;
                cbbQueQuan.SelectedValue = lvNhanVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //Lấy dòng đang chọn'
            lvNhanVien.SelectedItems[0].SubItems[0].Text = txtTen.Text;
            lvNhanVien.SelectedItems[0].SubItems[1].Text = dtNgaySinh.Value.ToString("dd/MM/yyyy");
            lvNhanVien.SelectedItems[0].SubItems[2].Text = rbNam.Checked ? "Nam" : "Nữ";
            lvNhanVien.SelectedItems[0].SubItems[3].Text = cbbQueQuan.SelectedItem.ToString();

            lvNhanVien.SelectedItems[0].ImageIndex = (rbNam.Checked ? 0 : 1);

        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

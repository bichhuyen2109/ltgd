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
    public partial class Bai20 : Form
    {
        public Bai20()
        {
            InitializeComponent();
        }
        #region Biến toàn cục
        string[] table = { "b1", "b2", "b3", "b4" };
        DataTable dSOrder = new DataTable();
        #endregion

        private void Bai20_Load(object sender, EventArgs e)
        {
            ccbBan.Items.AddRange(table);
            dSOrder=new DataTable();
            dSOrder.Columns.Add("Fooodname");
            dSOrder.Columns.Add("Quantity");
            gVOrder.DataSource = dSOrder;
            gVOrder.Columns[0].Width = (int)(gVOrder.Width * 0.6);
            gVOrder.Columns[1].Width = (int)(gVOrder.Width * 0.3);
        }

        private void ccbBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ccbBan.SelectedItem.ToString());
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Button bt = ((Button)sender);
            DataRow row;
            bool co = true;
            foreach (DataRow item in dSOrder.Rows)
            {
                if (bt.Text == item[0].ToString())
                {
                    co = false;
                    item[1] = (int.Parse(item[1].ToString()) + 1).ToString();
                    break;
                }
            }
            if (co)
            {
                row = dSOrder.NewRow();
                row[0] = bt.Text;
                row[1] = 1;
                dSOrder.Rows.Add(row);
            }
        }

        //private void btOrder_Click(object sender, EventArgs e)
        //{
        //    StreamWriter streamWriter;
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    string fileName = "";
        //    if(saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        fileName=saveFileDialog.FileName;
        //    }   
        //    else
        //    {
        //        fileName = @"D\FileLog.txt";
        //    }
        //    streamWriter = new StreamWriter(fileName);

        //    streamWriter.WriteLine(string.Format("{0,-10}", ccbBan.SelectedItem.ToString())
        //        + string.Format("{0-50}", dSOrder.Columns[0].hea);


        //    for(int i = 0; i < dSOrder.Rows.Count; i++)
        //    {
        //        streamWriter.WriteLine(dSOrder.Rows[i].ToString() + " " +
        //            dSOrder.Rows[i].ToString());
        //    }    
        //}

        private void btXoa_Click(object sender, EventArgs e)
        {
            dSOrder.Rows.Clear();
        }
    }
}

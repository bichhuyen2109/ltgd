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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtCode.Text += b.Text;
            txtCode.Focus();    
            txtCode.SelectionStart = txtCode.Text.Length -1;   
        }

        private void btC_Click(object sender, EventArgs e)
        {
            //Xóa từng ký tự
            //123456
            //12345
            //1234
            if (txtCode.Text != "")
            {
                txtCode.Text = txtCode.Text.Substring(0, txtCode.Text.Length - 1);
            }
        }

        private void btThang_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            //1. Lấy giá trị của textbox so sánh với 3 nhóm DL
            //2. Thêm dòng chữ -> ListLog
            string code;
            string result = "";
            code = txtCode.Text;
            if (e.KeyCode == Keys.Enter)
            {
                if (code.Length > 1)
                {
                    switch (code)
                    {
                        case "1645":
                        case "1689":
                            result = "Technicians";
                            break;
                        case "8345":
                            result = "Custodians";
                            break;
                        case "998":
                        case "1006":
                        case "1008":
                            result = "Scientist";
                            break;
                        default:
                            result = "Access denied";
                            break;
                    }
                }
                else
                    result = "Retristed Access";
                listbox.Items.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " " + result);
                listbox.Items.Add(String.Format("{0:dd/MM/yyyy HH:mm:ss} {1}",DateTime.Now, result));                
                txtCode.Text = "";
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            try
            {
                string path = Application.StartupPath + @"\Text\FileLog.txt";
                if (listbox.Items.Count > 0)
                {
                    //1. Nếu chưa có file FileLog.txt rồi thì ghi đè.
                    //2. Nếu có rồi thì nối thêm nội dung vào
                    if (!File.Exists(path))//chưa có thì tạo mới và ghi đè
                    {
                        using (StreamWriter s = new StreamWriter(path))
                        {
                            //Ghi nội dung trong file log xuống tex
                            foreach (string item in listbox.Items)
                            {
                                s.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter s = File.AppendText(path))
                        {
                            //Nối thêm nội dung trong file log xuống tex
                            foreach (string item in listbox.Items)
                            {
                                s.WriteLine(item);
                            }
                        }
                    }
                }
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu thất bại");
            }
        }
    }
}

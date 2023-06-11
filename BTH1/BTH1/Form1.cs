namespace BTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color[] c = { Color.DarkBlue, Color.OrangeRed, Color.Olive, Color.NavajoWhite };
            Random rand = new Random();
            int i = rand.Next(0, 4);
            this.BackColor = c[i];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.Location = new Point(rand.Next(0, 555), rand.Next(0, 555));
        }
    }
}
namespace clicker
{
    public partial class Form1 : Form
    {
        int cash;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash++;
            label1.Text = "Hajs: $"+cash.ToString();
        }
    }
}
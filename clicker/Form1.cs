namespace clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        System.Timers.Timer timer;
        int A1Ammount;
        int A1Interval;


        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
            pictureBox1.Visible = false;
            timer = new System.Timers.Timer(250);
            timer.Elapsed += timer_Elapsed;
            A1Ammount = 10;
            A1Interval = 0;
            textBox2.Text = A1Ammount.ToString();
            textBox3.Text = A1Interval.ToString();

            
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            pictureBox1.Visible=false;

       
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(2, buttonLevel - 1);
            label1.Text = "Hajs: $" + cash.ToString();
            pictureBox1.Visible = true;
            timer.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                textBox1.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                label1.Text = "Hajs: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                button2.Text = "Upgrade\n " + nextUpgradeCost;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            A1Interval++;
            A1Timer.Interval = (60 / A1Interval) = 1000;
            if(!A1Timer.Enabled)
                A1Timer.Enabled = true;


        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Ammount;
            label1.Text = "Kasa: $" + cash.ToString();
        }
    }
}
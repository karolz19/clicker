using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        System.Timers.Timer timer;
        int A1Ammount;
        int A1Interval;
        double time = 10;
        int clicks = 10;


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
            pictureBox1.Visible = false;



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
            SoundPlayer splayer = new SoundPlayer(clicker.Properties.Resources.nigggger);
            splayer.Play();
            

            if(time > 0)
            {
                clicks++;
                label6.Text = "Clicks: " + clicks;
                timer1.Start();
            }
            

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
            
            
            int upgradeCost = A1Ammount * 10;
            if (cash >= upgradeCost)
            {
                A1Ammount += 10;
                textBox2.Text = A1Ammount.ToString();

                cash -= upgradeCost;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if (cash >= upgradeCost)
            {
                A1Interval++;
                textBox3.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                cash -= upgradeCost;

            }
        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Ammount;
        }

        private void LEVEL(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 1)
            {
                time -= 0.1;
                label7.Text = time.ToString();

            } else
            {
                timer1.Stop();
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
} 

   

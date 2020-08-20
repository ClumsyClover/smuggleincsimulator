using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Smuggle_INC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            transition.Start();
        }
        int t = 0;
        private void transition_Tick(object sender, EventArgs e)
        {
            for (double i = 0.1; i <= 1.0; i++)
            {
                this.Opacity += 0.015;
                t++;
                if (t == 5)
                {
                    label1.Text = "Loading Dollars....";
                }
                if (t == 10)
                {
                    label1.Text = "Loading Renminbi....";
                    label2.Text = "Loading Dollars....";
                }
                if (t == 15)
                {
                    label1.Text = "Loading Rupees....";
                    label2.Text = "Loading Renminbi....";
                }
                if (t == 20)
                {
                    label1.Text = "Loading Ruble....";
                    label2.Text = "Loading Rupees....";
                }
                if (t == 25)
                {
                    label1.Text = "Loading Dirham....";
                    label2.Text = "Loading Ruble....";
                }
                if (t == 30)
                {
                    label1.Text = "Loading pointlessflashscreen.exe....";
                    label2.Text = "Loading Dirham....";
                }
                if (t == 35)
                {
                    label1.Text = "Loading Nothing....";
                    label2.Text = "Loading pointlessflashscreen.exe....";
                }
                if (t == 40)
                {
                    label1.Text = "Loading Smuggling....";
                    label2.Text = "Loading Nothing....";
                }
                if (t == 45)
                {
                    label1.Text = "Loading Clover Smuggle Base....";
                    label2.Text = "Loading Smuggling....";
                }
                if(t == 50)
                {
                    label1.Text = "Loading Complete!";
                    label2.Text = "Loading Clover Smuggle Base....";
                }
                
            }
            if (this.Opacity == 1.0)
            {
                transition.Stop();
                home open = new home();
                open.Show();               
            }
            
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void wait_Tick(object sender, EventArgs e)
        {

        }
    }
}

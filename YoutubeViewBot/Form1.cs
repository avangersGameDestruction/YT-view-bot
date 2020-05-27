using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeViewBot
{
    public partial class Form1 : Form
    {

        int i;
        int counter;
        bool a;
        public Form1()
        {
            InitializeComponent();

            i = 500;
            a = false;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                webBrowser1.Navigate(textBox1.Text);
                counter = 1;
                a = true;
                if (textBox2.Text == "0")
                {
                    MessageBox.Show("Timer Interval is not valid", "error");
                }

                else
                {
                    timer1.Interval = int.Parse(textBox2.Text) * i;
                    timer1.Start();
                }
            }

            else
            {
                if (a == true)
                {
                    timer1.Stop();
                    a = false;
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            label1.Text = Convert.ToString(counter);
            counter++;
        }
    }
}

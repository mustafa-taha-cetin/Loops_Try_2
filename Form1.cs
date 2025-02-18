using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, toplam = 0;
            while(i <= 5)
            {
                listBox1.Items.Add(i);
                toplam = toplam + i;
                listBox2.Items.Add(toplam);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sure;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            label2.Text = "süre: " + sure;
            if(sure == 10)
            {
                this.BackColor = Color.Red;
            }
            if (sure == 20)
            {
                this.BackColor = Color.Yellow;
            }
            if (sure == 30)
            {
                this.BackColor = Color.Green;
                sure = 0;
            }
        }
    }
}

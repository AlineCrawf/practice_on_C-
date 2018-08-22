using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._3
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
            i = 0;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            listBox1.Items.Add($"Прошло {i} сек");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            i = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            i = 0;
        }
    }
}

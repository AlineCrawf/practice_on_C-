using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form1 : Form
    {
        Form1 f1;
        Input ip;
        Calc cl;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
            this.calcToolStripMenuItem.Enabled = false;
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input ip = new Input();
            ip.Show();
            this.calcToolStripMenuItem.Enabled = true;
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc(ip);
            
            calc.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachet
{
    public partial class Form2 : Form
    {
        private int n;
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
            textBox1.Text = Convert.ToString(this.n);
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            int cx = pictureBox1.Width;
            int cy = pictureBox1.Height/ 2;

            PointF[] ptf = new PointF[cx];
            int cw = Convert.ToInt32(textBox1.Text);

            g.Clear(pictureBox1.BackColor);

            for (int i = 0; i < cx; i++)
            {
                ptf[i].X = i;
                ptf[i].Y = (float)((cy / 2) * (1 - Math.Sin(i * cw * Math.PI / (cx - 1))));
            }
            g.DrawLines(Pens.White, ptf);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}

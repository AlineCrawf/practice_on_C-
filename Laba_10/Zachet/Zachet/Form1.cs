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
    public partial class Form1 : Form
    {
        private int Last;
        class Eratosthenes_sieve
        {
            private List<int> mass;
            public Eratosthenes_sieve()
            {
                mass = new List<int>() { 2, 3, 5, 7, 11, 13,17, 19 };
            }
            public List<int> Mass
            {
                get
                {
                    return mass;
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int n = Convert.ToInt32(textBox1.Text);
            //if ((n > 3) || (n < 20))
            //{
            //    errorProvider1.Clear();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Eratosthenes_sieve es = new Eratosthenes_sieve();
                foreach(Char c in textBox1.Text)
                {
                    if (c < '0' || c > '9')
                        throw new Exception();
                }
                int n = Convert.ToInt32(textBox1.Text);
                if (n < 3 || n > 20)
                    MessageBox.Show("Incorrect value");
                else
                {
                    List<int> prime = es.Mass;
                    for (int i = 0; i < prime.LongCount(); i++)
                    {

                        if (prime[i] <= n)
                        {
                            richTextBox1.AppendText($"{Convert.ToString(prime[i])} ");
                            Last = prime[i];
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect type");
            }
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void windbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Last);
            f2.Show();
        }
    }
}

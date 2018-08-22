using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            button1.Enabled = false;
            button2.Enabled = false;
            if ((radioButton1.Checked || radioButton2.Checked) && (checkBox1.Checked || checkBox2.Checked) && textBox1.Text!="")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ans = 0;
                if(radioButton1.Checked)
                foreach(Char c in textBox1.Text)
                {
                        if (c == 'а')
                            ans++;
                }
                if (radioButton2.Checked)
                    foreach (Char c in textBox1.Text)
                    {
                        if (c == 'о')
                            ans++;
                    }
                if (checkBox1.Checked)
                    ansLabel.Text = ans==0?"Нет. ":"Да. ";
                if (checkBox2.Checked)
                    ansLabel.Text += $"{ans} раз(а)";
               
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ansLabel.Text = "";
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked) && (checkBox1.Checked || checkBox2.Checked) && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked || checkBox2.Checked) && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked || checkBox2.Checked) && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked) &&textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked) && textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
    }
}

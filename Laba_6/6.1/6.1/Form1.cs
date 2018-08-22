using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Rg
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                bool a = Convert.ToBoolean(Convert.ToInt32(textBox2.Text) % 5);
                bool b = Convert.ToBoolean(Convert.ToInt32(textBox1.Text) % 5);
                label4.Text = Convert.ToString(Convert.ToInt32(!a) + Convert.ToInt32(!b));
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                    MessageBox.Show("Enter all data");
                else
                    MessageBox.Show("You can enter only digit");

                foreach (Char c in textBox1.Text)
                {
                    if (Char.IsDigit(c))
                        errorProvider1.SetError(textBox1, "Contain a forbitten char");
                }
                foreach (Char c in textBox2.Text)
                {
                    if (Char.IsDigit(c))
                        errorProvider2.SetError(textBox1, "Contain a forbitten char");
                }
                if (textBox1.Text == "")
                    errorProvider1.SetError(textBox1, "Empty");
                if (textBox2.Text == "")
                    errorProvider2.SetError(textBox2, "Empty");
            }
        }
    }
}

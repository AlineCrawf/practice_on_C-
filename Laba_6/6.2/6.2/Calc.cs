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
    public partial class Calc : Form
    {
        class Prog
        {
            private int a, b;
            public Prog(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public int Even()
            {
                int sum = 0;
                for (int i = a + 1; i < b; i++)
                {
                    if (i % 2 == 0)
                        sum++;
                }
                return sum;
            }
            public int Palindrome()
            {
                int sum = 0;
                for (int i = a + 1; i < b; i++)
                {
                    if (i == 11 || i == 22 || i == 33 || i == 44 || i == 55 || i == 66 || i == 77 || i == 88 || i == 99)
                    {
                        sum++;
                        continue;
                    }
                    string str = Convert.ToString(i);
                    string str1 = str.Substring(0, str.Length / 2);
                    str = str.Substring((str.Length / 2) + 1);
                    if (str == str1)
                        sum++;
                }
                return sum;
            }
        }
        public Calc(Input ip)
        {
            Input ipp = ip;
            InitializeComponent();
            ip.Controls.Find;
        }
    }
}

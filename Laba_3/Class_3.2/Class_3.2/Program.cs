using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3._2
{
    class Mass
    {
        private int [] numbs;
        private int size;
        private int moreThan100;
        public Mass(int n)
        {
            numbs = new int[n];
            size = n;
            for(int i =0,j=1;i<n;++i, j = (i+1)*(i+1))
            {
                numbs[i] = j;
            }
        }
        public Mass(string name)
        {
            int i = 0;
           StreamReader reader = new StreamReader(name);
            string ss = "";
            while(ss!=null)
            {
                ss = reader.ReadLine();
                if (ss != null)
                    i++;
            }
            this.size = i;
            numbs = new int[size];
            reader.Close();
            StreamReader f = new StreamReader(name);
            ss = "";
            i = 0;
            while (ss != null)
            {
                ss = f.ReadLine();
                if(ss!=null)
                {
                    numbs[i] = Convert.ToInt32(ss);
                    i++;
                }
            }
            f.Close();
            //numbs = System.IO.File.ReadAllText(name).Split(' ').Select(n => int.Parse(n)).ToArray();
            //while(numbs[i]>='0'&&numbs[i]<='9')
            //{
            //    i++;
            //}
            //size = i;
        }
        public void Print()
        {
            for (int i = 0; i < this.size; i++)
            {
                Console.Write(numbs[i]);
                Console.Write(" ");
            }
        }
        private int IndOfMin()
        {
            int min = numbs[0];
            int ind = 0;
            for(int i=0;i<size;i++)
            {
                if (numbs[i] < min)
                {
                    min = numbs[i];
                    ind = i;
                }

            }
            return ind;
        }
        private int IndOfMax()
        {
            int max = numbs[0];
            int ind = 0;
            for (int i = 0; i < size; i++)
            {
                if (numbs[i] > max)
                {
                    max = numbs[i];
                    ind = i;
                }

            }
            return ind;
        }

        public double product_of_numbers()
        {
            double sum = 1;
            int a = this.IndOfMin();
            int b = this.IndOfMax();
            if(a>b)
            {
                a = b;
                b = this.IndOfMax();
            }
            for(int i = a ;i<b; i++)
            {
                sum *= numbs[i];
            }
            return sum;
        }
        public int MoreThan100
        {
            get
            {
                int j = 0;
                for (int i = 0; i < this.size; i++)
                {
                    if (numbs[i] > 100)
                        j++;
                }
                moreThan100 = j;
                return this.moreThan100;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter size of mass");
                int n = Convert.ToInt32(Console.ReadLine());
                Mass mass = new Mass(n);
                mass.Print();
                Console.WriteLine();
                Console.WriteLine("Product of numbers : " + mass.product_of_numbers());
                Console.WriteLine();
                Console.WriteLine("More than 100: " + mass.MoreThan100);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine(/*"Enter name of file"*/);
                // string name = Console.ReadLine();
                Mass mass_1 = new Mass("E:\\1.txt");
                mass_1.Print();
                Console.WriteLine();
                Console.WriteLine("Product of numbers : " + mass_1.product_of_numbers());
                Console.WriteLine();
                Console.WriteLine("More than 100: " + mass_1.MoreThan100);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("No such file");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("(Index Out Of Range Exception");
            }
            Console.ReadKey();
        }
    }
}

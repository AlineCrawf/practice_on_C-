using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Apartment
    {
        private int number;
        private int amount;//kolichectvo jilcov
        private double area;
        private double sum;
        public Apartment()
        {
            number = 0;amount = 0;area = 10;
        }
        public Apartment(int numb, int amount, double area)
        {
            this.number = numb;
            this.amount = amount;
            this.area = area;
            sum = 5 * amount + 2 * area;
        }
        public int Numb => number;
        public int Amount => amount;
        public double Area => area;
        public double Sum => sum;
        public string ToStr()
        {
            return "Info about apartment.\nNumber is: " + number + '\n'
                + "Amount is: " + amount + '\n'
                + "Area is:" + area + '\n'
                + "Sum is:" + sum + '\n';
        }
    }

    class House
    {
        private Apartment[] app;
        private int size;
        public House(int n)
        {
            size = n;
            app = new Apartment[n];
        }
        public bool Zap(Apartment ap)
        {
            bool ans = false;
            for(int i=0;i<app.Length;i++)
            {
                if(app[i]==null)
                {
                    app[i] = ap;
                    ans = true;
                    break;
                }
            }
            return ans;
        }
        public string ToStr()
        { 
            string str = "";
            for(int i=0;i<size;i++)
            {
               str += i+1 +": " + app[i].ToStr();
            }
            return str;
        }
        public double All()
        {
            double ans = 0;
            for(int i=0;i<app.Length;i++)
            {
                ans += app[i].Sum;
            }
            return ans; 
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Apartment [] mass = new Apartment [5];
            Random rd2 = new Random();
            Random rd1 = new Random();
            for (int i=0;i<5;i++)
            {
                mass[i] = new Apartment(i+1, rd1.Next(0, 6), rd2.Next(1, 100));
                Console.WriteLine(mass[i].ToStr());
            }
            int size = rd1.Next(2, 6);
            House hs = new House(size);
            for (int i = 0; i < size; i++)
            {
                hs.Zap(mass[i]);
                //если такой квартиры в доме нет - вывести номер квартиры 
            }
            Console.WriteLine(hs.ToStr());
            Console.WriteLine(hs.All());
        }
    }
}

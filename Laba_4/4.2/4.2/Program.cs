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
            number = 0; amount = 0; area = 10;
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
        private List <Apartment> app;
        private int size;
        public House(int n)
        {
            size = n;
            app = new List <Apartment>();
        }
        public bool Zap(Apartment ap_)
        {
            bool ans = false;
            foreach (Apartment ap in app )
            {
                if (ap == null)
                    app.Add(ap_);
            }
            return ans;
        }
        public string ToStr()
        {
            string str = "";
            int i = 1;
            foreach (Apartment ap in app)
            {
                str += i + 1 + ": " + ap.ToStr();
                i++;
            }
            return str;
        }
        public double All()
        {
            double ans = 0;
            foreach (Apartment ap in app)
            {
                ans += ap.Sum;
            }
            return ans;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List <Apartment> mass = new List <Apartment>();
            Random rd2 = new Random();
            Random rd1 = new Random();
            for ( int i = 0;i<5;i++)
            {
                Apartment app = new Apartment(i + 1, rd1.Next(0, 6), rd2.Next(1, 100));
                mass.Add(app);
                Console.WriteLine(app.ToStr());
            }
            int size = rd1.Next(2, 6);
            House hs = new House(size);
            foreach (Apartment ap in mass)
            {
                hs.Zap(ap);
                //если такой квартиры в доме нет - вывести номер квартиры 
            }
            Console.WriteLine(hs.ToStr());
            Console.WriteLine(hs.All());
        }
    }
}
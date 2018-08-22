using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class House
    {
        private int rooms;
        private int year;
        public House()
        {
            rooms = 1;
            year = 2018;
        }
        public House(int r,int y)
        {
            rooms = r;
            year = y;
        }
        public double Q(int t)
        {
            return (rooms + 2.0 / (t-year));
        }
        public int Room => rooms;
        public int Year => year;
    }

    class DHouse: House
    {
        private string area;
        public DHouse(int room,int year,bool isCent):base(room,year)
        {
            if (isCent)
                this.area = "central";
            else this.area = "outskirts";
        }
        public void Info()
        {
            Console.WriteLine("Room: {0}\nYear: {1}\nArea: {2}",this.Room,this.Year,area);
        }
        public double Qp(int t)
        {
            if(area == "central")
                return base.Q(t) * 2;
            return base.Q(t) * 0.5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random Rroom = new Random();
            Random Ryear = new Random();
            Random IsCent = new Random();
            Random Rt = new Random();
            for (int i=0;i<5;i++)
            {
                DHouse ap = new DHouse(Rroom.Next(1,10) ,Ryear.Next(1500, 2018), Convert.ToBoolean(IsCent.Next()%2));
                Console.WriteLine("{0} room info", i+1);
                Console.WriteLine("----------------------------");
                ap.Info();
                Console.WriteLine("Method Q: {0}",ap.Q(2018));
                Console.WriteLine("Method Qp: {0}",ap.Qp(2018));
                Console.WriteLine("----------------------------");
            }
        }
    }
}

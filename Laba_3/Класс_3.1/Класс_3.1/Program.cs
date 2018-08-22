using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Класс_3._1
{
    class Rhombus
    {
        private double diag_a, diag_b;
        public Rhombus()
        {
            this.diag_a = 1;
            this.diag_b = 1;
        }

        public Rhombus(double diag_1, double diag_2)
        {
            if (diag_1 <=0 || diag_2 <= 0)
                throw new Exception ("Wrong value of diagonal") ;
            this.diag_a = diag_1;
            this.diag_b = diag_2;
        }

        public double Area()
        {
            return (diag_a * diag_b) / 2;
        }
        public double Side()
        {
            return Math.Sqrt(diag_a * diag_a + diag_b * diag_b) / 2;
        }

        public void Print()
        {
            Console.WriteLine("Diadonal a is " + diag_a);
            Console.WriteLine("Diadonal b is " + diag_b);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                Rhombus rhb = new Rhombus(rand.Next(10), rand.Next(10));
                rhb.Print();
                Console.WriteLine("Area is : " + rhb.Area());
                Console.WriteLine("Side is : " + rhb.Side());

            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
              //  Console.WriteLine("Метод: " + ex.TargetSite);
            }
            Console.ReadKey();
        }
    }
}

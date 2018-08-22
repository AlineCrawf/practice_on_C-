using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        interface IBody
        {
            double Surface_Area();
            double Amount();
            string Info();
        }

        class Parallelepiped:IBody
        {
            private double a, b, c;
            public Parallelepiped(double a,double b,double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double Surface_Area()
            {
                return 2 * (a * b + b * c + a * c);
            }
            public double Amount()
            {
                return a * b * c;
            }
            public string Info()
            {
                return $"Parallelepiped:\n a = {a},b = {b},c = {c}\nArea  = {Surface_Area()}\tAmount= {Amount()}\n\n";
            }
        }

        class Cone : IBody
        {
            private double r, h;
            public Cone(double r,double h)
            {
                this.r = r;
                this.h = h;
            }
            public double Surface_Area()
            {
                return Math.PI*r*(r+Math.Sqrt(r*r+h*h));
            }
            public double Amount()
            {
                return Math.PI*r*r*h/3;
            }
            public string Info()
            {
                return $"Cone:\n r = {r},h = {h}\nArea  = {Surface_Area()}\tAmount= {Amount()}\n\n";
            } 
        }
         class Ball : IBody
        {
            private double r;
            public Ball(double r)
            {
                this.r = r;
            }
            public double Surface_Area()
            {
                return 4*Math.PI*r*r;
            }
            public double Amount()
            {
                return (4*r*Math.PI*r*r/3);
            }
            public string Info()
            {
                return $"Ball:\nR = {r}\nArea  = {Surface_Area()}\tAmount= {Amount()}\n\n";
            }
        }

        static void Main(string[] args)
        {
            Cone cone = new Cone(1,7);
            Parallelepiped pl = new Parallelepiped(2, 6, 8);
            Ball ball = new Ball(5);
            Console.WriteLine(cone.Info());
            Console.WriteLine(pl.Info());
            Console.WriteLine(ball.Info());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{ 
    public class PointSpase
    {
        protected double x;
        protected double y;
        protected double z;
        public PointSpase(double x,double y, double z =0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Print()
        {
            Console.WriteLine("X: {0}\tY: {1}\tZ: {2}", x, y, z);
        }
        public virtual double Leng()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    public class PointPlane : PointSpase
    {
        public PointPlane(double x, double y) : base(x, y) { }
        public override double Leng()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PointSpase ps1 = new PointSpase(2, 2, 1);
            Console.WriteLine("Point in space\nCoordinates: ");
            ps1.Print();
            Console.WriteLine("L = {0}", ps1.Leng());
            PointSpase ps2 = new PointSpase(3, 2, 1);
            Console.WriteLine("Point in space\nCoordinates: ");
            ps2.Print();
            Console.WriteLine("L = {0}", ps2.Leng());
            PointPlane pn1 = new PointPlane(5, 3);
            Console.WriteLine("Point in space\nCoordinates: ");
            pn1.Print();
            Console.WriteLine("L = {0}", pn1.Leng());
        }
    }
}

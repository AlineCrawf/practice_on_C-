using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    abstract class Carriage
    {
        protected double price;
        protected int place;
        protected double sum;
        public Carriage(double price,int place)
        {
            this.price = price;
            this.place = place;

        }
        public abstract double Cost();
        public abstract void Info();
    }

    class General:Carriage
    {
        public General(double price, int place) : base(price, place)
        {

        }
        public override double Cost()
        {
            sum = price * place;
            return sum;
        }
        public override void Info()
        {
            Console.WriteLine($"General: price = {price}\tplace = {place}\tsum = {this.Cost()}");
        }
    }

    class Reserved:Carriage
    {
        private double dopCost;
        public Reserved (double price, int place,double dopCost) : base(price, place)
        {
            this.dopCost = dopCost;
        }
        public override double Cost()
        {
            sum = price * place + dopCost * place * 0.5;
            return sum;
        }
        public override void Info()
        {
            Console.WriteLine($"Reserved: price = {price}\tplace = {place}\tDop price = {dopCost}\tsum = {this.Cost()}");
        }
    }

    class Slepping: Carriage
    {
        private double dopCost;
        public Slepping(double price, int place, double dopCost) : base(price, place)
        {
            this.dopCost = dopCost;
        }
        public override double Cost()
        {
            sum = place * (price + dopCost);
            return sum;
        }
        public override void Info()
        {
            Console.WriteLine($"Slepping: price = {price}\tplace = {place}\tDop price = {dopCost}\tsum = {this.Cost()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Carriage> list = new List<Carriage>();
            list.Add(new General(100, 200));
            list.Add(new Reserved(200, 50, 10));
            list.Add(new Slepping(300, 20, 50));
            foreach(Carriage cg in list)
            {
                cg.Info();
            }
        }
    }
}

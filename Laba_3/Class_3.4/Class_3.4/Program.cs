using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3._4
{
    class TelConv
    {
        private string telNumb;
        private string surname;
        private string address;
        private string cityCode;
        private string city;
        private double tarif;//стоимость одной минуті разговора
        private string date;//выборка
        private string time;
        private double duration;// продолжительность переговоров
        private string phone;

        public TelConv()
        {
            telNumb = "063-525-45-00";
            surname = "Tkachenko";
            address = "Address";
            cityCode = "12345";
            city = "Odessa";
            tarif = 1.5;
            date = "03.07.2018";
            time = "12:45";
            duration = 30;
            phone = "Meizu";
        }
        public TelConv(string TN, string SN, string Add, string CC, string City, double TF, string Date, string Time, double DT, string Phone)
        {
            telNumb = TN;
            surname = SN;
            address = Add;
            cityCode = CC;
            city = City;
            tarif = TF;
            date = Date;
            time = Time;
            duration = DT;
            phone = Phone;
        }
        public void Info()
        {
            Console.WriteLine("Telephine number is {0}", this.telNumb);
            Console.WriteLine("Surname is {0}", this.surname);
            Console.WriteLine("Address is {0}", this.address);
            Console.WriteLine("City code is {0}", this.cityCode);
            Console.WriteLine("City is {0}", this.city);
            Console.WriteLine("Tarif is {0}", this.tarif);
            Console.WriteLine("Date is {0}", this.date);
            Console.WriteLine("Time is {0}", this.time);
            Console.WriteLine("Duration is {0}", this.duration);
            Console.WriteLine("Phone is {0}", this.phone);
        }
        public string Date
        {
            get
            {
                return this.date;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<TelConv> list = new List<TelConv>();
            bool isDate = false;
            list.Add(new TelConv());
            list.Add(new TelConv("123-456-78-90", "Surname", "Dvoryanska", "12345", "Odessa", 1.65, "12.06.2017", "11:05", 95, "Smartphone"));
            list.Add(new TelConv("069-737-64-74", "Sidorov", "Dalnickaya", "12345", "Odessa", 1.65, "24.03.2018", "14:35", 65, "Apple"));
            list.Add(new TelConv("093-373-71-43", "Ivanov", "Street", "12345", "Odessa", 1.65, "03.07.2018", "5:45", 25, "Smartph"));
            Console.WriteLine("Enter date");
            string Date = Console.ReadLine();
            foreach(var abonent in list)
            {
                if (Date == abonent.Date)
                {
                    Console.WriteLine("---------------------------------------");
                    abonent.Info();
                    Console.WriteLine("---------------------------------------");
                    isDate = true;
                }
            }
            if (!isDate)
                Console.WriteLine("No such date");
        }
    }
}

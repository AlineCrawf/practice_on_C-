using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3._3
{
    class Bell
    {
        public delegate void isBell();
        public event isBell Event1;
        public event isBell Event2;

        private int numb_of_lesson;
        public Bell(int n)
        {
            numb_of_lesson = n;
        }
        public void Bell_to_less()
        {
            Console.WriteLine("Bell to {0} lesson", numb_of_lesson);
        }
        public void Bell_from_lesson()
        {
            Console.WriteLine("Bell from {0} lesson", numb_of_lesson);
        }
        public void bell()
        {
            Event1();
            Event2();
        }
        
    }
    class Teacher
    {
        private string name;
        public Teacher(string name)
        {
            this.name = name;
        }
        public void TBell_to_less()
        {
            Console.WriteLine("Teacher {0} goes to class", name);
        }
        public void TBell_go()
        {
            Console.WriteLine("Teacher {0} goes to teacher's", name);
        }
    }
    class Student
    {
        private string name;
        public Student(string name)
        {
            this.name = name;
        }
        public void SBell_to_less()
        {
            Console.WriteLine("Student {0} goes to class", name);
        }
        public void SBell_from_less()
        {
            Console.WriteLine("Student {0} goes to break", name);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lessons");
            int n = Convert.ToInt32(Console.ReadLine());
            Teacher tch = new Teacher("Helen");
            Student sd = new Student("Ivanov");
            for(int i=1;i<=n;i++)
            {
                Bell bl = new Bell(i);
                bl.Event1 += bl.Bell_to_less;
                bl.Event1 += tch.TBell_to_less;
                bl.Event1 += sd.SBell_to_less;
                bl.Event2 += bl.Bell_from_lesson;
                bl.Event2 += sd.SBell_from_less;
                bl.Event2 += tch.TBell_go;
                bl.bell();
            }
        }
    }
}

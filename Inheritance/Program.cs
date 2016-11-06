using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person //"sealed class Person" will make the person class uninheritable
    {
        public string name="";
        public long phone=0;
        private string email="";
        protected int age=0; //like private but inheriting classes can see it
        public virtual void print()  //virtual means you give permission for people to change your code
        {
            Console.WriteLine(name + " " + phone + " " + email);
        }

        public Person()
        {
            Console.WriteLine("In person constructor");
        }
        public Person(string nam, long phn)
        {
            this.name = nam
                ;
            this.phone = phn;
        }
        ~Person() //destructor
        {
            Console.WriteLine("In person destructor");
            Console.ReadLine();
        }
    }

    class Worker : Person
    {
        public long sin_number=0;
        public double salary=0;
        public override void print() //override replaces parent code by your code
        {
            base.print(); //runs parnet code; like SUPER in Java
            Console.WriteLine(sin_number + " " + salary);
        }


        public Worker()
        {
            Console.WriteLine("In worker constructor");
        }
        public Worker(string nam, long phn, long sin, double sal):base(nam,phn)
        {
            this.sin_number = sin;
            this.salary = sal;
        }
        ~Worker() //destructor
        {
            Console.WriteLine("In worker destructor");
        }
    }

    class SalesPerson : Worker // 3rd level inheritance
    {
        public double commission = 0;

        public SalesPerson()
        {
            Console.WriteLine("In sales person constructor");
        }
        public SalesPerson(string nam, long phn, long sin, double sal, double com):base(nam,phn,sin,sal)
        {
            this.commission = com;
        }
        ~SalesPerson() //destructor
        {
            Console.WriteLine("In sales person destructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson s = new SalesPerson("Bob", 4036252753, 1, 50000, 0.10);
            Worker w = new Worker("Bob", 4036252753, 1, 50000);
            Person p = new Person("Bob", 4036252753);
            Console.ReadLine();
        }
    }
}

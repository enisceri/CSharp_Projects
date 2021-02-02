using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Manager manager = new Manager();
            person.setIsim("Enis");
            person.setSoyisim("Ceri");
            person.yazdir();

            manager.setIsim("M. Eren");
            manager.setSoyisim("Ceri");
            manager.setSalary(4900);
            manager.yazdir();

            Console.Read();
        }


    }

    class Person
    {
        private string isim;

        private string soyisim;

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return isim;
        }

        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public string getSoyisim()
        {
            return soyisim;
        }

        public virtual void yazdir()
        {
            Console.WriteLine("Name    : {0}", getIsim());
            Console.WriteLine("Surname : {0}", getSoyisim());

        }
    }

    class Manager:Person
    {
        private int salary;

        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        int getSalary()
        {
            return salary;
        }

        public override void yazdir()
        {
            base.yazdir();

            Console.WriteLine("Override (Ezme) islemi");
            Console.WriteLine("Salary  : {0}", getSalary());
            
        }

    }
}

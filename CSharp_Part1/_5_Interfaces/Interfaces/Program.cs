using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Student student = new Student()
            {
                id = 1,
                firstName = "Mustafa Eren",
                lastName = "Ceri",
                departmant = "Computer"

            };


            manager.add(new Customer { id = 1, firstName = "Enis", lastName = "Ceri", address = "Istanbul" });
            manager.add(student);


            IPerson person = new Customer();
            person.firstName = "Ahmed";
            Console.WriteLine("IPerson reference Customer = {0}", person.firstName);

            Console.Read();


        }
    }

    interface IPerson
    {
        int id { get; set; }
        string firstName { set; get; }
        string lastName { set; get; }
    }

    class Customer : IPerson
    {
        public int id { get; set; }
        public string firstName { set; get; }
        public string lastName { get; set; }
        public string address { get; set; }

    }

    class Student : IPerson
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string departmant { get; set; }

    }

    class PersonManager
    {
        public void add(IPerson person)
        {
            Console.WriteLine(person.firstName + " " + person.lastName + " veri tabanina eklendi.");
        }


    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bu desen klonlama amaciyla kullanilir.

namespace _4_PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { FirstName = "Enis", LastName = "Ceri", CustomerCity = "Ankara", Id = 1 };

            //Customer customer2 = customer1; Bu sekilde yaparsak ikisi de M.Eren olur.
            //Cunkur referans tip.

            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "M.Eren";

            Customer customer3 = (Customer)customer1.DeepClone();
            customer3.FirstName = "Husna";

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer3.FirstName);


            

            Console.ReadLine();
        }
    }
    public abstract class Person
    {
        //Prototip deseninde TEMEL NESNEYI prototip haline getirebilmek icin onun soyut 
        //bir clone metodu olmalidir.
        public abstract Person Clone();

        public abstract Person DeepClone();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public string CustomerCity { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

        public override Person DeepClone()
        {
            
            Person clone = (Person)this.MemberwiseClone();
            clone.Id = Id;
            clone.FirstName = String.Copy(FirstName);
            clone.LastName = String.Copy(LastName);

            return clone;            
        }
    }
    public class Employee : Person
    {
        public decimal Salary  { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }

        public override Person DeepClone()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Id = Id;
            clone.FirstName = String.Copy(FirstName);
            clone.LastName = String.Copy(LastName);

            return clone;
        }
    }
}

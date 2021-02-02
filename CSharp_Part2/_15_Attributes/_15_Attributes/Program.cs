using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1 ,Age = 22,LastName="Ceri"  };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

         



            Console.Read();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        [GerekliTip] //Kullanici FirstName girmeli.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}", customer.Id);
            Console.WriteLine("{0}", customer.FirstName);
            Console.WriteLine("{0}", customer.LastName);
            Console.WriteLine("{0}", customer.Age);

        }
    }

    class GerekliTip:Attribute
    {

    }
 
    
}

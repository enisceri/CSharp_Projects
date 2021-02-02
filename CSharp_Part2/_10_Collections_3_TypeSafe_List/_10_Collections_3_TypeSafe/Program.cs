using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections_3_TypeSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Amasya");

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(10);
            sayilar.Add(100);


            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            customer1.setId(1);
            customer1.setName("Enis");
            customer2.setId(2);
            customer2.setName("Mustafa Eren");
            customers.Add(customer1);
            customers.Add(customer2);

            int count = customers.Count();
            Console.WriteLine("Collection Generic List Customer eleman sayisi : {0}", count);


            Customer[] customerArray = new Customer[3];
            Customer customerArrayMember1 = new Customer();
            customerArrayMember1.setName("Umran");
            customerArrayMember1.setId(3);

            Customer customerArrayMember2 = new Customer();
            customerArrayMember2.setId(4);
            customerArrayMember2.setName("Husna");

            Customer customerArrayMember3 = new Customer();
            customerArrayMember3.setName("Seyit");
            customerArrayMember3.setId(5);

            customerArray[0] = customerArrayMember1;
            customerArray[1] = customerArrayMember2;
            customerArray[2] = customerArrayMember3;

            customers.AddRange(customerArray); //Verilen Customer arrayini customers listesine ekledik.
            //customers.Clear();
            customers.RemoveAll(c => c.getName() == "Enis");
            Console.WriteLine("---------Customer List--------");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.getId() + " " + customer.getName());
            }
           
            Console.Read();
        }
    }

    class Customer
    {
        int id { get; set; }

        string name { get; set; }
    
        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Classes
________
1. Gruplama
2. Property/Attribute (Özellikleri) tutmak


 
 */

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            ProductManager product = new ProductManager();
            product.add();
            product.update();

            Customer customer = new Customer();

            customer.customerInfo();
            customer.firstName = "Enis";
            customer.lastName = "Çeri";
            customer.city = "İstanbul";
            customer.id = 12;

            customer.customerInfo();

            Console.Read();
        }
    }



}

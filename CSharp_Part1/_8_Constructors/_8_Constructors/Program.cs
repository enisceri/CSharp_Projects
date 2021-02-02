using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager manager = new CustomerManager();
            StudentManager student = new StudentManager();
            Product product = new Product { id = 1, name = "Su" };

          
            



            Console.Read();
      

        }
    }

    class CustomerManager
    {
        
        public CustomerManager()
        {
            Console.WriteLine("CustomerManager Constructor calisti.");
        }

        public CustomerManager(int customerNumber)
        {
            Console.WriteLine("Customer Number : {0}", customerNumber);
          
        }
        ~CustomerManager()
        {
            Console.WriteLine("CustomerManager Destructor calisti.");
        }

    }
    class StudentManager
    {
        public StudentManager()
        {
            Console.WriteLine("StudentManager Constructor calisti.");
        }

        ~StudentManager()
        {
            Console.WriteLine("StudentManager Destructor calisti.");

        }


    }

    class Product
    {
        public int id { get; set; }

        public  string name { get; set; }



    }


}


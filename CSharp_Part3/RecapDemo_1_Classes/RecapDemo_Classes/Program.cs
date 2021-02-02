using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.setName("Enis Ceri");
            customer.setID(5);

            CustomerManager manager = new CustomerManager();
            manager.logger = new SmsLogger();
            manager.icustomer = customer;
          

            manager.add();
            manager.delete();
                    


            Console.Read();
        }
    }


    
   

    interface ICustomer
    {
        void setName(string name);

        string  getName();

        void setID(int id);

        int getID();
    }
    class Customer : ICustomer
    {
        private string name;

        private int id;

        public int getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }

    class CustomerManager
    {
        public ICustomer icustomer;
        
        public ILogger logger { get; set; }
  


    
        public void add()
        {
            Console.WriteLine(icustomer.getName() + " eklendi.");
            logger.log();


        }

        public void delete()
        {
            Console.WriteLine(icustomer.getName() + " silindi.");
            logger.log();

        }

    }

    interface ILogger
    {
        void log();
        
    }

    class DataBaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to DataBase.");
        }
    }

    class FileLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to File.");
        }
    }
    
    class SmsLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to SMS.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Constructors_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Constructor kullanarak loglama ve kullanmadan loglama farki.
                CustomerManager -> Constructor kullanilmadi.
                EmployeeManager -> Constructor kullanildi.
             */
            
            CustomerManager manager = new CustomerManager();
            manager.logger = new FileLogger();
            manager.add();
            
            Console.WriteLine("-----------------");

            //Programcinin log'u parametre olarak vermesini zorunlu kilarak unutmasini engeller.
            EmployeeManager employee = new EmployeeManager(new DataBaseLogger());
            employee.add();

            Manager.addManager();

            Manager manager1 = new Manager();
            manager1.update();

            Console.Read();
        }
    }

    interface ILogger
    {
        void log();
    }

    class DataBaseLogger:ILogger
    {        
        public void log()
        {
            Console.WriteLine("Logged to dataBase.");
        }
    }
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file.");
        }
    }

    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void add()
        {
            logger.log();
            Console.WriteLine("Customer Added.");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void add()
        {
            _logger.log();
            Console.WriteLine("Employee Added.");
        }
    }

    class Manager
    {
        public static void addManager()
        {
            Console.WriteLine("Manager added.");
        }

        public void update()
        {
            Console.WriteLine("Manager updated.");
        }
        
    }


}

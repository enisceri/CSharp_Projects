using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();

            Console.Read();
        }
    }

    class Logging : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
    class Caching : ICache
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
    class Authorize : IAuthorize
    {
        public void UserCheck()
        {
            Console.WriteLine("Checked");
        }
    }

    class CustomerManager: ICustomerService
    {
        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.UserCheck();
            _concerns.Logging.Log();
            Console.WriteLine("Saved");
        }
    }
    class CrossCuttingConcernsFacade
    {
        public ILogger Logging;
        public ICache Caching;
        public IAuthorize Authorize;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }

internal interface ICustomerService
    {
    }

    internal interface IAuthorize
    {
        void UserCheck();
    }

    internal interface ICache
    {
        void Cache();
    }

    internal interface ILogger
    {
        void Log();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2(new MailLogger()));
            customerManager.Save();

            CustomerManager customerManager2 = new CustomerManager(new LoggerFactory(new SmsLogger()));

           

            Console.ReadLine();
        }
    }

    public class LoggerFactory:ILoggerFactory
    {
        private ILogger _logger;
        public LoggerFactory(ILogger logger)
        {
            _logger = logger;
        }
        public ILogger CreateLogger()
        {
            return _logger;
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {
        private ILogger _logger;
        public LoggerFactory2(ILogger logger)
        {
            _logger = logger;
        }
        public ILogger CreateLogger()
        {
            return _logger;
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log();
    }

    public class MailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to mail");
        }
    }

    public class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS");
        }
    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Customer Saved");
            //ILogger logger = new MailLogger();
            //Bu sekilde MailLogger'a bagimliyiz. Yarin obur gun
            //Baska bir logger sinifini kullanmak istesek sikinti var.
            //O nedenle asagidaki gibi kullanilir.
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}

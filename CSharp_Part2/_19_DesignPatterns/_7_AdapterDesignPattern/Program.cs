using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Baska bir servisi projemize dahil edip sanki bizimmiscesine kullanmaya yarar.

namespace _7_AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new WebLoggerAdapter());
            productManager.Save();


            Console.Read();
        }
    }

    class ProductManager:IProductService
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
            _logger.Log("User Data");
        }
    }

    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged {0}", message);
        }
    }

    //Bu class'i Nuget'ten indirdigimizi ve dokunamadigimizi varsayalim.
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with log4net {0}", message);
        }
    }
    
    //Bunu da Nuget'ten indirdik diyelim.
    class WebLogger
    {
        public void LogWebMessage(string message)
        {
            Console.WriteLine("Logged with webMessage {0}", message);
        }
    }
    class WebLoggerAdapter:ILogger
    {

        public void Log(string message)
        {
            WebLogger webLogger = new WebLogger();
            webLogger.LogWebMessage(message);
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }
    internal interface IProductService
    {
    }
    interface ILogger
    {
        void Log(string message);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory2());
            productManager.GetAll();

            Console.Read();
        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);
    }
    public abstract class Cashing   
    {
        public abstract void Cache(string data);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nLogger");
        }
    }

    public class MemCache : Cashing
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCache");
        }
    }
    public class RedisCache : Cashing
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with RedisCache");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Cashing CreateCashing();

    }
    public class Factory1:CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }

        public override Cashing CreateCashing()
        {
            return new RedisCache();
        }
    }
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogger()
        {
            return new NLogger();
        }

        public override Cashing CreateCashing()
        {
            return new RedisCache();
        }
    }

    public class ProductManager:IProductService
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Cashing _cashing;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogger();
            _cashing = _crossCuttingConcernsFactory.CreateCashing();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _cashing.Cache("Cached");
            Console.WriteLine("Products Listed");
        }
    }

    public interface IProductService
    {
    }
}

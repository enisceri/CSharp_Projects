using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nesne bir kez uretildi.
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.SaveCustomers();

            Console.Read();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject = new object();
        private CustomerManager()
        {
                
        }
        public static CustomerManager CreateAsSingleton()
        {
            //if(_customerManager == null)
            //{
            //    _customerManager = new CustomerManager();
            //}

            //return _customerManager;

            //YA DA asagidaki gibi yazilir.

            //NULL degilse ??'inin sol tarafini dondurur. NULL ise sag tarafta olusturup return eder.

            lock (_lockObject)
            {
                if(_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }

            return _customerManager;
        }

        public void SaveCustomers()
        {
            Console.WriteLine("Musteriler kaydedildi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {


            CustomerManager manager = new CustomerManager(new OracleCustomerDal());
            manager.addCustomer();
            manager.deleteCustomer();
            manager.updateCustomer();

            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void addCustomer()
        {
            Console.WriteLine("Musteri sqlServer'a eklendi.");
        }

        public void deleteCustomer()
        {
            Console.WriteLine("Musteri sqlServer'dan silindi.");
        }

        public void updateCustomer()
        {
            Console.WriteLine("Musteri sqlServer'dan guncellendi.");
        }
    }
}

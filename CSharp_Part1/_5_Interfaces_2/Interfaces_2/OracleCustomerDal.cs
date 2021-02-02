using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class OracleCustomerDal : ICustomerDal
    {
        public void addCustomer()
        {
            Console.WriteLine("Musteri Oracle'a eklendi.");
        }

        public void deleteCustomer()
        {
            Console.WriteLine("Musteri Oracle'dan silindi.");
        }

        public void updateCustomer()
        {
            Console.WriteLine("Musteri Oracle'da guncellendi.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int id{ get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string city;

        public void customerInfo()
        {
            Console.WriteLine("{0} Numarali Musteri Bilgileri\n*****************", id);
            Console.WriteLine("Ad    : {0}", firstName);
            Console.WriteLine("Soyad : {0}", lastName);
            Console.WriteLine("Sehir : {0}", city);
            Console.WriteLine("ID    : {0}\n", id);
        }
    }
}

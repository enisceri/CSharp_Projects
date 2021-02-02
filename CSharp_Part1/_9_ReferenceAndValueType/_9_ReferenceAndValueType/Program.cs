using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] { "Ankara", "Amasya" };
            string[] sehirler2 = new string[] { "Tokat", "Samsun" };

            sehirler1 = sehirler2;
            Console.WriteLine(sehirler1[0]);

            sehirler2[0] = "Zonguldak";
            Console.WriteLine(sehirler1[0]);

            Console.Read();
        }
    }
}

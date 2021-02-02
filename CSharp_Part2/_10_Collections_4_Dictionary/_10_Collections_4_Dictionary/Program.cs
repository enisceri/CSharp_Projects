using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections_4_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictUlkelerveBaskentler = new Dictionary<string, string>();
            dictUlkelerveBaskentler.Add("Turkiye", "Ankara");
            dictUlkelerveBaskentler.Add("Almanya", "Berlin");
            dictUlkelerveBaskentler.Add("Fransa", "Paris");

            foreach (var dict in dictUlkelerveBaskentler)
            {
                Console.WriteLine(dict.Key + " in baskenti {0} 'dir.",dict.Value);
            }

           

            Console.Read();
        }
    }
}

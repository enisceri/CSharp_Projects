using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
 *  Tip guvenli olmayan ArrayList (Type Safe)
 */

namespace _10_Collections_2_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            
            cities.Add("Ankara");
            cities.Add("Amasya");
            cities.Add(34);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            Console.Read();

        }
    }
}

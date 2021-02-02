using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Array olusturdugumuz zaman yeni bir eleman ekleme sikintisi vardir.
 * Bunun onune gecmek icin collections kullanilir.
 * Gunumuzde artik array neredeyse kullanilmamaktadir.
 */

namespace _10_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Enis", "Eren", "Enes" };
            string[] newisimler = new string[5];

            for(int i = 0; i <isimler.Length;++i)
            {
                newisimler[i] = isimler[i];
            }
            newisimler[3] = "Emir";
            newisimler[4] = "Ekin";

            foreach (var item in newisimler)
            {
                Console.WriteLine(item);

            }

            Console.Read();
       }
    }
}

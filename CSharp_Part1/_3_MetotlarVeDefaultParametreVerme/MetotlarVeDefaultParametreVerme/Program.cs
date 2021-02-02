using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarVeDefaultParametreVerme
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas;
            Console.WriteLine("Yasinizi giriniz :");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiginiz yas {0}", yasGir(yas));
            Console.Read();
        }

        static int yasGir(int yas=0)
        {
            yas = yas < 0 ? 0 : yas;

            return yas;
        }
    }
}

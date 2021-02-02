using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Reflection_2_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 15, sayi2 = 30;
            Console.WriteLine("1. Parametre vererek toplama yap.\n" +
                              "2. Constructor ile toplama yap.");

            int sec = Convert.ToInt32(Console.ReadLine());

            var tip = typeof(DortIslem);
            if(sec == 1)
            {
                Console.WriteLine("Parametreleri verin");
                int s1 = Convert.ToInt32(Console.ReadLine());
                int s2 = Convert.ToInt32(Console.ReadLine());
                DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip);
                Console.WriteLine("Parametreli Toplam : " + dortIslem.ToplaParametreli(s1, s2));
            }
            else
            {
                DortIslem dortIslem = (DortIslem) Activator.CreateInstance(tip,sayi1,sayi2);
                Console.WriteLine("Constructor ile Toplam : " + dortIslem.ToplaConstructor());

            }


            Console.Read();
        }
    }

    class DortIslem
    {
        private int sayi1;
        private int sayi2;
        public DortIslem()
        {
                
        }

        public DortIslem(int sayi1, int sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }

        public int ToplaParametreli(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int ToplaConstructor()
        {
            return sayi1 + sayi2;
        }
    }
}

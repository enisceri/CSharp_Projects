using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay, payda,sonuc;
            Console.WriteLine("Payi girin:");
            pay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Paydayi girin:");
            payda = Convert.ToInt32(Console.ReadLine());

            try
            {
                sonuc = pay / payda;
                Console.WriteLine("Sonuc : {0}", sonuc);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Sifira bolunmez. Hata mesaji : {0}", exception.Message);
                
            }

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    OZET:
    ref keywordu ile degiskenin referansini gonderiririz ve bu sayede referans ile calisabiliriz.
    ref yerine out da olur. Ancak ref'de degiskenin ilk degeri olmasi gerekmektedir.
    AMA out degisken de kullanildigi fonk. icinde set edilmelidir.
 */

namespace RefAnahtarKelimesi
{
    class Program
    {
        static void swap(int sayi1, int sayi2)
        {
            int temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;
        }

        static void refSwap(ref int sayi1, ref int sayi2)
        {
            int temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;
        }

        static void refOutFarki_DegerDegistirFonksiyonu(out int sayi)
        {
            sayi = 100;
        }

        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            Console.WriteLine("--Call By Value--");
            Console.WriteLine("Sayi 1 = {0}\nSayi 2 = {1}", sayi1, sayi2);

            swap(sayi1, sayi2);
            Console.WriteLine("After Swap");
            Console.WriteLine("Sayi 1 = {0}\nSayi 2 = {1}", sayi1, sayi2);

            Console.WriteLine("--Call By Reference--");
            Console.WriteLine("Sayi 1 = {0}\nSayi 2 = {1}", sayi1, sayi2);

            refSwap(ref sayi1, ref sayi2);
            Console.WriteLine("After Swap");
            Console.WriteLine("Sayi 1 = {0}\nSayi 2 = {1}", sayi1, sayi2);
                        

            Console.WriteLine();
            int sayi3 = 10;
            refOutFarki_DegerDegistirFonksiyonu(out sayi3);
            Console.WriteLine("Sayi 3 = {0}", sayi3);


            int[] dizi = new int[5];

            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            dizi[3] = 4;
            dizi[4] = 6;

            foreach(int i in dizi)    
            {
                Console.WriteLine(i);
            }

            int[,] sayilar = new int[3, 3];

            sayilar[0, 0] = 10;
            sayilar[0, 1] = 20;
            sayilar[0, 2] = 30;
            sayilar[1, 0] = 40;
            sayilar[1, 1] = 50;
            sayilar[1, 2] = 60;
            sayilar[2, 0] = 70;
            sayilar[2, 1] = 80;
            sayilar[2, 2] = 90;

            foreach(var i in sayilar)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }
    }
}

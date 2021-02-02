using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * Reflection Neden Kullanilir ?
 * Calisma aninda nesneler hakkinda bilgi alip istersek bu nesneleri calistirmak icin.
1-Kullanicinin ne girecegini bilmiyoruz. O an kullanicinin girdigi degere gore karar vermemiz gereken durumlarda kullanilir.
2-Nesne ile alakali bilgilere ulasmak icin kullanilir.
Yani nesnenin sahip oldugu fonksiyonlar, fonk. parametreleri, attribute'lari vs. gorebiliriz.
 */
namespace _16_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Normalde bu sekilde kullaniyoruz.
            //DortIslem dortIslem = new DortIslem(2, 3); ->  (KOD 1)
            //Console.WriteLine("Constructor parametreleri ile toplama      : " + dortIslem.Topla2());
            //Console.WriteLine("Nesneye ait toplama fonksiyonu ile toplama : " + dortIslem.Topla(3, 4)); 

            //Reflection kullanarak ayni islemleri calisma aninda yapalim.

            /*
            var tip = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,10,9);//Burda yaptigimiz islem ile KOD 1 ayni seydir.
            Console.WriteLine(dortIslem.Topla(4, 5));
            Console.WriteLine(dortIslem.Topla2());
            */

            var tip = typeof(DortIslem);
            var instance = Activator.CreateInstance(tip,6,5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance,null));

            MethodInfo[] metodlar = tip.GetMethods();

            foreach (var metod in metodlar)
            {
                Console.WriteLine("Metod Adi : " + metod.Name);
                foreach (var parameter in metod.GetParameters())
                {
                     Console.WriteLine("Parametre : " + parameter.Name);
                }




            }




            Console.Read();
        }
    }

    class DortIslem
    {
        private int sayi1, sayi2;

        public DortIslem()
        {

        }
        public DortIslem(int sayi1, int sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }
        
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return sayi1 + sayi2;
        }

        public int Carp2()
        {
            return sayi1 * sayi2;
        }
    }
}

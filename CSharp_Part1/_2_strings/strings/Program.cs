using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    
    class Program
    {
        static void degistir(string s1, string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }
        static void Main(string[] args)
        {
            string string1 = "Enis";
            string string2 = "M. Eren";

            Console.WriteLine("S1 : {0}\nS2 : {1}", string1, string2);
            degistir(string2, string1);
            Console.WriteLine("Degisim Sonrasi");
            Console.WriteLine("S1 : {0}\nS2 : {1}", string1, string2);
            Console.Read();

        }
    }
}

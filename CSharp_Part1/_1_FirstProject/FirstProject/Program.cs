using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        enum EGunler
        {
            Pazartesi = 1, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
        }
        static void Main(string[] args)
        {
            //ValueTypes
            int iDegisken  = 2147483647;
            long lDegisken = 214748364721474836;
            short sDegisken = 2147;
            byte bDegisken = 255;
            char cDegisken = 'A';
            bool boolDegisken = true;
            double dDegisken = 12.41;
            decimal decDegisken = 12.56536544539890893242423423432532532532324324234434234346436897983758457389473289474973294832423m;

 

            Console.WriteLine("int  degisken    = {0}", iDegisken);
            Console.WriteLine("char degisken    = {0}", cDegisken);
            Console.WriteLine("long degisken    = {0}", lDegisken);
            Console.WriteLine("short degisken   = {0}",sDegisken);
            Console.WriteLine("byte degisken    = {0}", bDegisken);
            Console.WriteLine("bool degisken    = {0}", boolDegisken);
            Console.WriteLine("double degisken  = {0}", dDegisken);
            Console.WriteLine("decimal degisken = {0}", decDegisken);
            Console.WriteLine("Ilk Gun          = {0}", EGunler.Pazartesi);
            Console.WriteLine("Son Gun Haftanin {0}. gunudur.", (int)EGunler.Pazar);
            


            Console.Read();



        }


    }
}

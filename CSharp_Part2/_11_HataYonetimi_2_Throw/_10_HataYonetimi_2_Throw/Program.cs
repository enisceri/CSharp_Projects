using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HataYonetimi_2_Throw
{
    class Program
    {
        static void Main(string[] args)
        {
    
            try
            {
                List<string> isimler = new List<string> { "Enis", "Seyit", "M.Eren" };

                if (!isimler.Contains("Ahmet"))
                {
                    throw new RecordNotFoundException("Kayit bulunamadi");
                }

                else
                {
                    Console.WriteLine("Ahmet bulundu.");
                }
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }


            Console.ReadLine();
        }
    }
}

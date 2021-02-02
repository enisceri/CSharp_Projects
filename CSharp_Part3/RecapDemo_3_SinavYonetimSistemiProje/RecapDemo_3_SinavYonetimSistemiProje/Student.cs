using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_3_SinavYonetimSistemiProje
{
    class Student
    {
        private string name;

        private int no;

        public void setName(string name)
        {
            this.name = name;
        }

        public void setNo(int no)
        {
            if(no > 0)
            {
                this.no = no;
            }
        }

        public string getName()
        {
            return name;
        }
    
        public int getNo()
        {
            return no;
        }

        public void yazdir()
        {
            Console.WriteLine("\n-----Ogrenci Bilgiler-----");
            Console.WriteLine("Ogrenci No      : {0}", no);
            Console.WriteLine("Ogrenci Ad Soyad: {0}", name);            
        }
    }
}

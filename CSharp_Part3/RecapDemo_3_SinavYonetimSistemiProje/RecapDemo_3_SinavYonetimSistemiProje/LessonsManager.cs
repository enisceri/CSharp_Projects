using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_3_SinavYonetimSistemiProje
{
    class LessonsManager
    {
        private Dictionary<int, int> ogrenciVizeler = new Dictionary<int, int>();
        private Dictionary<int, int> ogrenciFinaller = new Dictionary<int, int>();
        private StudentManager studentManager;
        public LessonsManager(StudentManager studentManager)
        {
            this.studentManager = studentManager;
        }
        public void vizeNotGir(int no ,int not)
        {
            for(int i = 0; i < studentManager.getStudents().Count; ++i)
            {
                if(no == studentManager.getStudents()[i].getNo())
                {
                    ogrenciVizeler.Add(no, not);
                }
            }    
        }

        public void finalNotGir(int no, int not)
        {
            for (int i = 0; i < studentManager.getStudents().Count; ++i)
            {
                if (no == studentManager.getStudents()[i].getNo())
                {
                    ogrenciFinaller.Add(no, not);
                }
            }
        }

        public string harfNotuHesapla(int no)
        {
            for (int i = 0; i < studentManager.getStudents().Count; ++i)
            {
                if (no == studentManager.getStudents()[i].getNo())
                {
                    int sonuc = (ogrenciVizeler[no] * 40) / 100 + (ogrenciFinaller[no] * 60) / 100;
                    return harfHesapla(sonuc);
                }
            }




            return "";
        }

        private static string harfHesapla(int sonuc)
        {
            string harfNotu;

            if (sonuc >= 90)
            {
                harfNotu = "AA";
            }
            else if (sonuc < 90 && sonuc >= 85)
            {
                harfNotu = "BA";
            }
            else if (sonuc < 85 && sonuc >= 80)
            {
                harfNotu = "BB";
            }

            else if (sonuc < 80 && sonuc >= 75)
            {
                harfNotu = "CB";
            }

            else if (sonuc < 75 && sonuc >= 65)
            {
                harfNotu = "CC";
            }
            else if (sonuc < 65 && sonuc >= 58)
            {
                harfNotu = "DC";
            }
            else if (sonuc < 58 && sonuc >= 50)
            {
                harfNotu = "DD";
            }

            else
            {
                harfNotu = "FF";
            }

            return harfNotu;

        }
    }
}

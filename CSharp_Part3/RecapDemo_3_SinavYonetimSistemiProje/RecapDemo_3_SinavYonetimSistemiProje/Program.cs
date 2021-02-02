using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_3_SinavYonetimSistemiProje
{
    class Program
    {

        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            Lessons lessons = new Lessons();
            lessons.addLesson("Matematik");
            lessons.addLesson("Turkce");
            lessons.addLesson("Ingilizce");

            LessonsManager lessonsManager = new LessonsManager(studentManager);
            LessonsManager lessonsManager2 = new LessonsManager(studentManager);
            LessonsManager lessonsManager3 = new LessonsManager(studentManager);

            int secim;
            while (true)
            {
                Console.WriteLine("\n1. Sisteme Ogrenci Ekle\n" +
                                  "2. Not Gir\n" +
                                  "3. Ogrenci Sorgula\n" +
                                  "4. Cikis\n");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 4)
                {
                    break;
                }

                else if (secim == 1)
                {
                    Student student = new Student();
                    string name;
                    int no;
                    Console.Write("Ogrenci isim : ");
                    name = Console.ReadLine();
                    Console.Write("Ogrenci No : ");
                    no = Convert.ToInt32(Console.ReadLine());

                    student.setName(name);
                    student.setNo(no);

                    studentManager.addStudent(student);

                }

                else if (secim == 2)
                {
                    //Console.WriteLine(lessons.getLessons()[0]);
                    //Console.WriteLine(lessons.getLessons().Count);

                    int no;
                    int vize;
                    int final;
                    Console.WriteLine("Ogrenci No Girin : ");
                    no = Convert.ToInt32(Console.ReadLine());
                    int i = 0;
                    
                    for(i = 0; i < lessons.getLessons().Count;++i)
                    {
                        Console.WriteLine(lessons.getLessons()[i] + " dersi vize notunu girin :");
                        vize = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(lessons.getLessons()[i] + " dersi final notunu girin :");
                        final = Convert.ToInt32(Console.ReadLine());
                        if (i == 0)
                        {
                            lessonsManager.vizeNotGir(no, vize);
                            lessonsManager.finalNotGir(no, final);
                        }
                        else if(i == 1)
                        {
                            lessonsManager2.vizeNotGir(no, vize);
                            lessonsManager2.finalNotGir(no, final);
                        }
                        else
                        {
                            lessonsManager3.vizeNotGir(no, vize);
                            lessonsManager3.finalNotGir(no, final);
                        }
                    }
                    





                }

                else if (secim == 3)
                {
                    int no;
                    Console.WriteLine("Ogrenci no :");
                    no = Convert.ToInt32(Console.ReadLine());
                    
                    studentManager.ogrenciBilgisiAl(no, lessonsManager, lessons);
                    studentManager.ogrenciBilgisiAl(no, lessonsManager2, lessons);
                    studentManager.ogrenciBilgisiAl(no, lessonsManager3, lessons);

                }
            }
            Console.Read();

        }
    }
}

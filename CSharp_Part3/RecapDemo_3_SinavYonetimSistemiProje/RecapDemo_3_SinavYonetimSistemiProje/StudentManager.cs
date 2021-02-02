using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_3_SinavYonetimSistemiProje
{
    class StudentManager
    {
        private List<Student> students = new List<Student>();

        public List<Student> getStudents()
        {
            return students;
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void removeStudent(int no)
        {
            foreach (var student in students)
            {
                if(student.getNo() == no)
                {
                    students.Remove(student);
                    break;
                }
            }
             
        }
        
        public int ogrenciSayiBilgisi()
        {
            return students.Count;
        }

        public void ogrenciBilgisiAl(int numara, LessonsManager lessonsManager,Lessons lessons)
        {
            foreach (var student in students)
            {
                if(student.getNo() == numara)
                {
                    student.yazdir();
                    //Not bilgisi eklenecek.
                    getDersBilgi(lessons, "Matematik", lessonsManager, numara);
                    getDersBilgi(lessons, "Turkce", lessonsManager, numara);
                    getDersBilgi(lessons, "Ingilizce", lessonsManager, numara);

                }
            }
       
           
        }

        public void getDersBilgi(Lessons lessons, string lessonName, LessonsManager lessonsManager, int numara)
        {
            for(int i = 0;i < lessons.getLessons().Count; i++)
            {
                if(lessons.getLessons()[i] == lessonName)
                {
                        Console.WriteLine(lessons.getLessons()[i] + " harf notu : {0}", lessonsManager.harfNotuHesapla(numara));
                
                }
            }

        }
    }
}

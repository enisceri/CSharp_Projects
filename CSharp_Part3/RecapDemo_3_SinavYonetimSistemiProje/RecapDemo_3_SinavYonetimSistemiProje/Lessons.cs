using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_3_SinavYonetimSistemiProje
{
    class Lessons
    {

        private List<string> lessons = new List<string>();

        public List<string> getLessons()
        {
            return lessons;
        }
        public void addLesson(string lesson)
        {
            lessons.Add(lesson);
        }

        public void removeLesson(string lesson)
        {
            lessons.Remove(lesson);
        }


    }
}

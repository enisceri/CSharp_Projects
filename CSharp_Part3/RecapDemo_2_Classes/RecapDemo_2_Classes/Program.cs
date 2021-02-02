using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo_2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.setName("Enis Ceri");
            student.setNo(180);

            ILogger logger = new TelephoneLogger();

            StudentManager studentManager = new StudentManager(student, logger);
            studentManager.add();
            studentManager.updateExams();
            studentManager.query();

            Console.Read();

            
        }
    }

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
            this.no = no;
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
            Console.WriteLine("---Student Infos---");
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("No   : {0}", no);
        }
    }

    class StudentManager
    {
        private Student student;

        private ILogger logger;
        public StudentManager(Student student, ILogger logger)
        {
            this.student = student;
            this.logger = logger;
        }
        public void add()
        {
            Console.WriteLine(student.getNo() + " " + student.getName() + " sisteme eklendi.");
            logger.log();

        }

        public void updateExams()
        {
            Console.WriteLine(student.getNo() + " " + student.getName() + " sinavlar eklendi.");
            logger.log();
        }

        public void query()
        {
            student.yazdir();
        }
    }

    interface ILogger
    {
        void log();
    }

    class SmsLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to SMS.");
        }
    }
    class MailLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to mail.");
        }
    }
    class TelephoneLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to telephone.");
        }
    }
}

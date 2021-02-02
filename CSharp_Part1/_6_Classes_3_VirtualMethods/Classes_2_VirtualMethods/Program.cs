using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2_VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.setName("Husna");
            person.setSurname("Ceri");
            person.yazdir();

            Worker worker = new Worker();
            worker.setName("Seyid");
            worker.setSurname("Ceri");
            worker.setDepartmant("Machine");
            worker.setSalary(6000);
            worker.yazdir();

            Student student = new Student();
            student.setName("Mustafa Eren");
            student.setSurname("Ceri");
            student.setGrade(10);
            student.yazdir();


            Console.Read();

        }
    }

    class Person
    {
        private string name;

        private string surname;

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }
    
        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public virtual void yazdir()
        {
            Console.WriteLine("\n----Person Infos----");
            Console.WriteLine("Name       : {0}", getName());
            Console.WriteLine("Surname    : {0}", getSurname());
        }
    }

    class Worker:Person
    {
        private string departmant;

        private int salary;

        public void setDepartmant(string departmant)
        {
            this.departmant = departmant;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public string getDepartmant()
        {
            return departmant;
        }

        public int getSalary()
        {
            return salary;
        }

        public override void yazdir()
        {
            base.yazdir();

            Console.WriteLine("Departmant : {0}", getDepartmant());
            Console.WriteLine("Salary     : {0}", getSalary());
        }
    }

    class Student:Person
    {
        private int grade;

        public void setGrade(int grade)
        {
            this.grade = grade;
        }

        public int getGrade()
        {
            return grade;
        }

        public override void yazdir()
        {
            base.yazdir();

            Console.WriteLine("Grade      : {0}", getGrade());
        }
    }


}


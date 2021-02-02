using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void work()
        {

        }

        public void eat()
        {

        }

        public void getSalary()
        {

        }
      
    }

    class Robot:IWorker
    {
        public void work()
        {

        }
    }
}

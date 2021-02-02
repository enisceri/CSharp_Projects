using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example.Engine
{
    public class DizelEngine : IEngine
    {
        public void CreateEngine()
        {
            Console.WriteLine("Dizel engine created");
        }
    }
}

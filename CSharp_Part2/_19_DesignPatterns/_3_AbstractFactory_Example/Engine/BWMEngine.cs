using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example.Engine
{
    public class BWMEngine : IEngine
    {
        public void CreateEngine()
        {
            Console.WriteLine("BMW Engine Created");
        }
    }
}

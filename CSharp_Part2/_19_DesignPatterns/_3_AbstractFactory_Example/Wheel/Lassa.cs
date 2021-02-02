using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example.Wheel
{
    public class Lassa : IWheel
    {
        public void CreateWheel()
        {
            Console.WriteLine("Lassa created");
        }
    }
}

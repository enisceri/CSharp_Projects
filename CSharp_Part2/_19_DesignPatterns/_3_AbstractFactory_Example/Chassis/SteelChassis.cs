using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example.Chassis
{
    public class SteelChassis : IChassis
    {
        public void CreateChassis()
        {
            Console.WriteLine("Steel chassis created");
        }
    }
}

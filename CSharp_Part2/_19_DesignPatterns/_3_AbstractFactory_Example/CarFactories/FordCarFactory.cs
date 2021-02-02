using _3_AbstractFactory_Example.Chassis;
using _3_AbstractFactory_Example.Engine;
using _3_AbstractFactory_Example.Wheel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example.CarFactories
{
    public class FordCarFactory : ICarFactory
    {
        public IChassis CreateChassis()
        {
            return new SteelChassis();
        }

        public IEngine CreateEngine()
        {
            return new DizelEngine();
        }

        public IWheel CreateWheel()
        {
            return new Lassa();
        }
    }
}

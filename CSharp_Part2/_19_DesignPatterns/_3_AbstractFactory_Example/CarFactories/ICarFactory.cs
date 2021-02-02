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
    public interface ICarFactory
    {        
        IWheel CreateWheel();
        IEngine CreateEngine();
        IChassis CreateChassis();
        
    }
}

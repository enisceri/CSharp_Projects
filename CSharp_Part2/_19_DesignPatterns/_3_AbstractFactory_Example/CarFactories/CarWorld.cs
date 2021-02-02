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
    public class CarWorld:ICarWorld
    {
        private ICarFactory _carFactory;
        private IEngine _engine;
        private IChassis _chassis;
        private IWheel _wheel;

        public CarWorld(ICarFactory carFactory)
        {
            _carFactory = carFactory;
            _engine = _carFactory.CreateEngine();
            _chassis = _carFactory.CreateChassis();
            _wheel = _carFactory.CreateWheel();
        }

        public void CarInfos()
        {
            _engine.CreateEngine();
            _chassis.CreateChassis();
            _wheel.CreateWheel();
        }
    }
}

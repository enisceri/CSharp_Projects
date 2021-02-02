using _3_AbstractFactory_Example.CarFactories;
using _3_AbstractFactory_Example.Chassis;
using _3_AbstractFactory_Example.Engine;
using _3_AbstractFactory_Example.Wheel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_AbstractFactory_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory fordCar = new FordCarFactory();
            ICarFactory bmwCar = new BMWCarFactory();

            CarWorld carWorld = new CarWorld(bmwCar); //fordCar yerine bmwCar yaz ve dene.            
            carWorld.CarInfos();
           
            Console.Read();


        }
    }








}

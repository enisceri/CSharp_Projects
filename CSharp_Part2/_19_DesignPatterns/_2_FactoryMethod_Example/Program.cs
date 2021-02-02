using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Huawei huawei = new Huawei("P10");
            FactoryTelephone factoryTelephone = new FactoryTelephone(huawei);

            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryMethod_Example
{
    public class Huawei : ITelephone
    {
        private string _telephoneModel;
        public Huawei(string model)
        {
            _telephoneModel = model;
            Console.WriteLine(_telephoneModel + " olusturuldu");
        }

        public string getModel()
        {
            return _telephoneModel;
        }
    }
}

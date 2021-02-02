using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryMethod_Example
{
    public class FactoryTelephone : IFactoryTelephone
    {
        private ITelephone _telephone;
        public FactoryTelephone(ITelephone telephone)
        {
            _telephone = telephone;
        }

        public ITelephone CreateTelephone()
        {
            return _telephone;
        }
    }
}

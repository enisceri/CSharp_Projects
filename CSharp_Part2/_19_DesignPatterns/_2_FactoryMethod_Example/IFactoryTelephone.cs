using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FactoryMethod_Example
{
    interface IFactoryTelephone
    {
        ITelephone CreateTelephone();

    }
}

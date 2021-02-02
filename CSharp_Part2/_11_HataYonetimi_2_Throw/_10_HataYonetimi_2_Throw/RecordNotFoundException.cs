using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HataYonetimi_2_Throw
{
    class RecordNotFoundException:Exception
    {

        public RecordNotFoundException(string message):base(message)
        {
            
        }
    }
}

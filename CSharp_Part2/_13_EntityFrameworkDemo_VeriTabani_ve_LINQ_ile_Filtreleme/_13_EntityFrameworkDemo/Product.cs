using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Bu class tablo ile eslesecek. Bu isi UNIT OF WORK PATTERN'i yapar.
 * 
 */

namespace _13_EntityFrameworkDemo
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ADONET_1_Giris
{
    public class Product
    {
        private int Id;
        private string ProductName;
        private decimal UnitPrice;
        private int StockAmount;

        public void setId(int Id)
        {
            this.Id = Id;
        }
        public void setProductName(string ProductName)
        {
            this.ProductName = ProductName;
        }
        public void setUnitPrice(int UnitPrice)
        {
            this.UnitPrice = UnitPrice;
        }
        public void setStockAmount(int StockAmount)
        {
            this.StockAmount = StockAmount;
        }

        public int getId()
        {
            return Id;
        }
        public string getProductName()
        {
            return ProductName;
        }
        public decimal getUnitPrice()
        {
            return UnitPrice;
        }
        public int getStockAmount()
        {
            return StockAmount;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
    class CustomerManager
    {
        ICustomerDal customer;

        public CustomerManager(ICustomerDal customer)
        {
            this.customer = customer;
        }
    
        public void addCustomer()
        {
            customer.addCustomer();
        }

        public void deleteCustomer()
        {
            customer.deleteCustomer();
        }

        public void updateCustomer()
        {
            customer.updateCustomer();
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.Print()
        {
            return "Customer details";
        }

        string IOrder.Print()
        {
            return "Order details";
        }
    }


}




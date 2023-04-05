using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface IPrintable
    {
        string Print();
    }

    // explicit interface
    public interface ICustomer
    {
        string Print();
    }
    public interface IOrder
    {
        string Print();
    }




}

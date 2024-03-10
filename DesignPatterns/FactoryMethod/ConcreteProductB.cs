using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    public class ConcreteProductB : IProduct
    {
        //This method is used to show which product is being used in the Concrete Creator
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductB");
        }
    }
}

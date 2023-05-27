using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    public class ConcreteProductA : IProduct
    {
        public void Use()
        {
            Console.WriteLine("Using ConcreteProductA");
        }
    }
}

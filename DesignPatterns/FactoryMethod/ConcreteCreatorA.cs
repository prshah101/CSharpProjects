using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    public class ConcreteCreatorA : Creator
    {
        //Implementing the factory method to create a ConcreteProductA object
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}

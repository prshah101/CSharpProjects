using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    internal class ConcreteCreatorB : Creator
    {
        //Implementing the factory method to create a ConcreteProductB object
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}

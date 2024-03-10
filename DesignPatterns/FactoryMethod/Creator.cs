using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    //Is the base of all creators
    public abstract class Creator
    {
        // The factory method creates a product (Which is implemented by the concrete creators)
        public abstract IProduct FactoryMethod();

        // The factory method is used to create a product and perform an operation
        public void Operation()
        {
            //Object creation
            IProduct product = FactoryMethod();
            //Perform operation
            product.Use();
        }
    }
}

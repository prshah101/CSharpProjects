using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void Operation()
        {
            IProduct product = FactoryMethod();
            product.Use();
        }
    }
}

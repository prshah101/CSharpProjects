using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //Makes the Adaptee's interface compatible with the Target's interface
    public class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        // The Adapter's implementation of the target interface method
        public void Request()
        {
            adaptee.SpecificRequest();

        }
    }
}

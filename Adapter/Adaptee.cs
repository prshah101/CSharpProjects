using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //This class has a different interface than the client
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's Specific Request");
        }
    }
}

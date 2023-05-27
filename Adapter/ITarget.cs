using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //The interface that the client code wats to work with
    public interface ITarget
    {
        void Request();
    }
}

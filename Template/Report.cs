using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Report : Template
    {
        //Implement the abstract method Part2() from Template
        protected override void Part2()
        {
            Console.WriteLine("Discussion");
        }

        //Implement the abstract method Part3() from Template
        protected override void Part3()
        {
            Console.WriteLine("Recomendation");
        }
    }
}

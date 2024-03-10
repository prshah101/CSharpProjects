using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Template
    {
        // The template method that defines the algorithm
        public void TemplateMethod()
        {
            Heading();
            Part1();
            Part2();
            Part3();
            Part4();
        }

        //Method that already has an implementation and can't be changed by subclasses
        protected void Heading()
        {
            Console.WriteLine("Heading");
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void Part2();
        protected abstract void Part3();

        // A method that can be optionally overridden by subclasses
        protected virtual void Part4()
        {
            Console.WriteLine("Conclusion");
        }

        // A method that can be optionally overridden by subclasses
        protected virtual void Part1()
        {
            Console.WriteLine("Introduction");
        }
    }
}

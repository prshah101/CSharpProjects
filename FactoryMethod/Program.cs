namespace Demonstrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creatorA = new ConcreteCreatorA();
            creatorA.Operation(); 

            Creator creatorB = new ConcreteCreatorB();
            creatorB.Operation(); 
        }
    }
}
namespace Demonstrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates an instance of the ConcreteCreatorA
            Creator creatorA = new ConcreteCreatorA();
            creatorA.Operation(); //Outputs the product being made, so ConcreteProductA

            //Creates an instance of the ConcreteCreatorB
            Creator creatorB = new ConcreteCreatorB();
            creatorB.Operation(); //Outputs the product being made, so ConcreteProductB
        }
    }
}
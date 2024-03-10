namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Adaptee
            Adaptee adaptee = new Adaptee();

            // Create an instance of the Adapter, passing the Adaptee instance to it
            ITarget adapter = new Adapter(adaptee);
        }
    }
}
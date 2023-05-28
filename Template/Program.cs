namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Blog
            Template blog = new Blog();
            // Call the TemplateMethod() on blog, which will execute the algorithm defined in Template
            blog.TemplateMethod();

            Console.WriteLine();

            // Create an instance of Report
            Template report = new Report();
            // Call the TemplateMethod() on report, which will execute the algorithm defined in Template
            report.TemplateMethod();
        }
    }
}
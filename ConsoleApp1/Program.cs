namespace DesignPatterns;
class TestClass
{
    static void Main(string[] args)
    {
        Singleton instance =Singleton.GetInstance();
        instance.Addone();
        Console.WriteLine(instance.count.ToString());
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
    }
}


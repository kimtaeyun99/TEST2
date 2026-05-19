namespace TEST2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test();
            Hello();
        }
        static bool Test()
        {
            Console.WriteLine("과제가 왜 쌓이지???");
            if (true)
            { return true; }
        }
        static void Hello()
        {
            Console.WriteLine("Hello heekang");
        }
    }
}

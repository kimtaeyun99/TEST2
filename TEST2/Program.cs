namespace TEST2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("김수지입니다"); //수정
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

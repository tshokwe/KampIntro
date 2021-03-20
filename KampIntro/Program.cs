using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine("rmzn");
                Console.WriteLine(args.Length);
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}

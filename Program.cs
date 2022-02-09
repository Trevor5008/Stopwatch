using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var quit = false;
            var watch = new Stopwatch();
            Console.Write("Press any key to start the stopwatch: ");
            Console.Read();
            watch.Start();

            while (quit == false)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                {
                    watch.Stop();
                }
                else if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    watch.Start();
                }
                else if (key == ConsoleKey.Q)
                {
                    quit = true;
                }
            }
        }
    }
}

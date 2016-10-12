using System;

namespace hello_world
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Program requiress at least one argument");
                return;
            }

            var module = new HelloModule();

            Console.WriteLine(module.SayHello(args[0]));

            Console.ReadLine();
        }
    }
}

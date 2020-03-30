using System;

namespace Classwork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            do
            {
                Console.ReadLine();
                continue;
            }
            while (Console.ReadLine() != "exit");

        }
    }
}

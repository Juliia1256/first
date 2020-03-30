using System;
using System.Reflection.Metadata.Ecma335;

namespace Classwork6
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the string: ");
           var answer = Console.ReadLine();
            do
            {
                if (answer.Length < 15)
                {
                    Console.WriteLine($"Entered string length is {answer.Length}");
                    break;
                }
                if (answer.Length > 15)
                {
                    Console.WriteLine($"Too long string. Try another: {answer.Length}");
                }
            }
            while (Console.ReadLine() != "exit");

        }
    }
}

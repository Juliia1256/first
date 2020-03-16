using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 12;
            short b = 2;
            float c = 20.01f;
            decimal d = 10.00M;

            Console.WriteLine($"int is: {a}");
            Console.WriteLine($"short is: {b}");
            Console.WriteLine($"float is: {c}");
            Console.WriteLine($"decimal is: {d}");*/
            string line = Console.ReadLine();
            decimal number = decimal.Parse(line);
            Console.WriteLine(number);
            
        }
    }
}

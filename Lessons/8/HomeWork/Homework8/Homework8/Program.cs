using System;
using System.Collections.Generic;

namespace Homework8
{

    class Program
    {

        static string GetBreckets()
        {
            string checkbreckets = null;
            Console.WriteLine($"Введите набор скобок. Каждая скобка должна иметь закрывающую пару: ");
            do
            {
                checkbreckets = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(checkbreckets))
                {
                    Console.WriteLine("Попробуйте еще раз");
                }
            }
            while (string.IsNullOrWhiteSpace(checkbreckets));
            return checkbreckets;
        }
        static bool CalculationBreckets()
        {
            var calculationBreckets = GetBreckets();

            Stack<char> roundbreckets = new Stack<char>();
            Stack<char> squearebreckets = new Stack<char>();
            if (calculationBreckets.Length % 2 != 0)
            {
                Console.WriteLine($"The answer is {!(calculationBreckets.Length % 2 != 0)}");
                return false;
            }

            for (var i = 0; i < calculationBreckets.Length; i++)
            {

                if (calculationBreckets[i] == '(')
                {
                    roundbreckets.Push('(');
                    continue;
                }
                if (calculationBreckets[i] == ')')
                {
                    if (roundbreckets.Count == 0)
                    {
                        break;
                    }
                    if (roundbreckets.Pop() == '(')
                    {
                        continue;
                    }

                }
                if (calculationBreckets[i] == '[')
                {
                    squearebreckets.Push('[');
                    continue;
                }
                if (calculationBreckets[i] == ']')
                {
                    if (squearebreckets.Count == 0)
                    {
                        break;
                    }
                    if (squearebreckets.Pop() == '[')
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine($"The answer is {(roundbreckets.Count == 0) && (squearebreckets.Count == 0)}");
            return ((roundbreckets.Count == 0) && (squearebreckets.Count == 0));
        }



        static void Main(string[] args)
        {

            CalculationBreckets();
        }

    }

}



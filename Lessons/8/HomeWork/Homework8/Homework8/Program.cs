using System;
using System.Collections.Generic;

namespace Homework8
{


    class Program
    {
        static Dictionary<char, char> brecketstype = new Dictionary<char, char>
        {
            { '(' , ')' },
            { '[' , ']' },
            { '{' , '}' },
            { '<' , '>' },
        };

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

            Stack<char> openbreckets = new Stack<char>();
            if (calculationBreckets.Length % 2 != 0) //first check
            {
                Console.WriteLine($"The answer is {!(calculationBreckets.Length % 2 != 0)}");
                return false;
            }
            int count;
            for (count = 0; count < calculationBreckets.Length; count++)
            {

                if (brecketstype.ContainsKey(calculationBreckets[count])) //add open type to stack
                {
                    openbreckets.Push(calculationBreckets[count]);
                    continue;
                }
                if (brecketstype.ContainsValue(calculationBreckets[count]))
                {
                    if ((brecketstype[openbreckets.Peek()] == calculationBreckets[count]) &&  openbreckets.Count >0)
                    {
                        openbreckets.Pop();  
                        if (openbreckets.Count == 0 && (calculationBreckets.Length -count) > 0)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"The answer is {openbreckets.Count == 0 && (calculationBreckets.Length==count)}");
            return (openbreckets.Count == 0 && (calculationBreckets.Length == count));  //forth check, stack balance
        }



        static void Main(string[] args)
        {

            CalculationBreckets();
        }

    }

}



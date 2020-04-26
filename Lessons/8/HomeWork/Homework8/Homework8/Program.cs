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
                return false;
            }
            for (int count = 0; count < calculationBreckets.Length; count++)
            {

                if (brecketstype.ContainsKey(calculationBreckets[count])) //add open type to stack
                {
                    openbreckets.Push(calculationBreckets[count]);
                    continue;
                }
                if(openbreckets.Count == 0) //second check
                {
                    return false;
                }
                if (brecketstype.ContainsValue(calculationBreckets[count]))
                {
                    var item = openbreckets.Pop();
                    if (brecketstype[item] != calculationBreckets[count]) //third check
                    {
                        return false;
                    }
                }
            }
            return (openbreckets.Count == 0 );  //forth check, stack balance
        }



        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {CalculationBreckets()}");

        }

    }

}



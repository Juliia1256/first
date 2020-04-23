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

            for (var i = 0; i < calculationBreckets.Length; i++)
            {

                if (brecketstype.ContainsKey(calculationBreckets[i])) //add open type to stack

                {
                    openbreckets.Push(calculationBreckets[i]);
                }
                if (brecketstype.ContainsValue(calculationBreckets[i])) 

                {
                    if (openbreckets.Peek().Equals('(')&& calculationBreckets[i].Equals(')')) //second and third check
                    {
                        openbreckets.Pop();
                        continue;
                    }
                    if (openbreckets.Peek().Equals('[') && calculationBreckets[i].Equals(']'))
                    {
                        openbreckets.Pop();
                        continue;
                    }
                    if (openbreckets.Peek().Equals('{') && calculationBreckets[i].Equals('}'))
                    {
                        openbreckets.Pop();
                        continue;
                    }
                    if (openbreckets.Peek().Equals('<') && calculationBreckets[i].Equals('>'))
                    {
                        openbreckets.Pop();
                        continue;
                    }
                }
            }

            Console.WriteLine($"The answer is {openbreckets.Count == 0}");
            return (openbreckets.Count == 0);  //forth check, stack balance
        }



        static void Main(string[] args)
        {

            CalculationBreckets();
        }

    }

}



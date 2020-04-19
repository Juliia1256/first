﻿using System;
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

            Stack<char> openbreckets = new Stack<char>();
            if (calculationBreckets.Length % 2 != 0) //first check
            {
                Console.WriteLine($"The answer is {!(calculationBreckets.Length % 2 != 0)}");
                return false;
            }

            for (var i = 0; i < calculationBreckets.Length; i++)
            {

                if (calculationBreckets[i] == '(') //add open type to stack
                {
                    openbreckets.Push('(');
                }
                if (calculationBreckets[i] == '[')
                {
                    openbreckets.Push('[');
                }
                if (calculationBreckets[i] == ')')  //second and third check, brecket type
                {

                    if (openbreckets.Peek()== '[')
                    {
                        break;
                    }
                    else if (openbreckets.Peek()=='(')
                    {
                        openbreckets.Pop();
                    }

                }
                if (calculationBreckets[i] == ']')
                {

                    if (openbreckets.Peek()=='(')
                    {
                        break;
                    }
                    else if (openbreckets.Peek()=='[')
                    {
                        openbreckets.Pop();
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



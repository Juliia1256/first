﻿using System;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // user input request
            Console.WriteLine("Enter the first operand:");
            var operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator:");
            var oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second operand:");
            var operand2 = Convert.ToDouble(Console.ReadLine());

            // processing the result, depending on the selected operator
            double result;
            if (oper == '/')
            {
                result = operand1 / operand2;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();

            }
            else if (oper == '%')
            {
                result = operand1 % operand2;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();
            }
            else if (oper == '*')
            {
                result = operand1 * operand2;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();

            }
            else if (oper == '+')
            {
                result = operand1 + operand2;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();
            }
            else if (oper == '-')
            {
                result = operand1 - operand2;
                Console.WriteLine("Result is " + result);
                Console.ReadLine();
            }
            else if (oper == '^')
            {
                result = Math.Pow(operand1, operand2);
                Console.WriteLine("Result is " + result);
                Console.ReadLine();
            }
            // exception handling
            else
            {
                Console.WriteLine("Sorry, unknow operator. Please, try again");
            }
         
        }
        
    }
}

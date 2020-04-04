using System;

namespace HW7_2
{
    class Program
    {
        static string CheckStringFornatOrEmptySpase()
        {
            string checkstring= null;
            Console.WriteLine($"Введите предложение: ");
            do
            {                     
                    checkstring = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(checkstring))
                    {
                        Console.WriteLine("Попробуйте еще раз");
                    }
            }
            while (string.IsNullOrWhiteSpace(checkstring));
            return checkstring.ToLower();
        }
        static string StringInReverseArray()
        {
            string toreversearray = CheckStringFornatOrEmptySpase();
            char [] letterarray = toreversearray.ToCharArray();

            Array.Reverse(letterarray);
            letterarray.ToString();
            string solution = string.Join("", letterarray);
            Console.WriteLine(solution);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
            return solution;
        }



        static void Main(string[] args)
        {
            StringInReverseArray();

        }
    }
}

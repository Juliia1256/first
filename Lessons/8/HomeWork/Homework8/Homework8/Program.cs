using System;
using System.Collections.Generic;

namespace Homework8
{
    //[Flags]
    //enum TypeOfBreckets : byte
    //{
    //    openround = 0b00000001,
    //    opensqueare = 0b00000010,
    //    closeround = 0b00000100,
    //    closesqueare = 0b00001000
    //}
    class Program
    {

        static List<char> GetBreckets()
        {
            var listBreckets = new List<char>();
            Console.WriteLine($"Введите набор скобок. Каждая скобка должна иметь закрывающую пару, для остановки ввода, нажмите 's'.");
            char input;
            while (true)
            {
                try
                {
                    input = Convert.ToChar(Console.ReadLine());
                    if (input == 's')
                    {
                        break;
                    }
                    listBreckets.Add(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Ошибка!");
                    throw;
                }
            }

            var showString = string.Join("", listBreckets);
            Console.WriteLine($"Введена строка: {showString}. Проверка на правильность:");

            return listBreckets;
        }

        static bool CalculationBreckets()
        {
            var calcBreckets = GetBreckets();
            //var brecketflags = 0;
            var openround = 0;
            var opensqueare = 0;
            var closeround = 0;
            var closesqueare = 0;
            if (calcBreckets.Count % 2 != 0)
            {
                return false;
            }

            for (var i=0; i< calcBreckets.Count;i++)
            {

                if (calcBreckets[i] == '(')
                {
                    openround +=1;
                    continue;
                }
                if (calcBreckets[i] == ')')
                {
                    closeround +=1;
                    if (calcBreckets[i-1]== '[')
                    {
                        return false;
                    }
                    continue;
                }
                if (calcBreckets[i] == '[')
                {
                    opensqueare +=1;
                    continue;
                }
                if (calcBreckets[i] == ']')
                {
                    closesqueare +=1;
                    if (calcBreckets[i - 1] == '(')
                    {
                        return false;
                    }
                    continue;
                } 
            }
            if (openround-closeround !=0)
            {
                return false;
            }
            if (opensqueare - closesqueare != 0)
            {
                return false;
            }
            
                return ((openround - closeround) == (opensqueare - closesqueare));

        }

            static void Main(string[] args)
            {
           Console.WriteLine(CalculationBreckets());
            
        }


        

    }
}

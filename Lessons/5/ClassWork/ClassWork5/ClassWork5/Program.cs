using System;

namespace ClassWork5
{
    enum containers
    {   //how it's working?
        fulltwenty,
        fullfive,
        fullone
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст: ");

            int age = Convert.ToInt32(Console.ReadLine());
            /*if (age <100)
             {
                 if (age == 1)
                     Console.WriteLine($" {age} год");
                 else if (age < 5)
                     Console.WriteLine($" {age} года ");
                 else if (age < 21)
                     Console.WriteLine($" {age} лет ");
                 else if (age == 21)
                     Console.WriteLine($" {age} год ");
                 else if (age < 25)
                     Console.WriteLine($" {age} года ");
                 else if (age < 31)
                     Console.WriteLine($" {age} лет ");
                 else if (age == 31)
                     Console.WriteLine($" {age} год ");
                 else if (age < 35)
                     Console.WriteLine($" {age} года ");
                 else if (age < 41)
                     Console.WriteLine($" {age} лет");
                 else if (age == 41)
                     Console.WriteLine($" {age} год");
                 else if (age == 4)
                     Console.WriteLine($" {age} год");*/
            int lastof = age % 10;
            if (age < 100)
                if (lastof == 1)
                {
                    Console.WriteLine($" {age} год");
                }
                else if (lastof == 0)
                {
                    Console.WriteLine($" {age} лет");
                }
             
                else if (lastof == 3 || lastof == 4 || lastof == 2)
                {
                    Console.WriteLine($" {age} года");
                }
            
                //else if (lastof == 5 || lastof == 6 || lastof == 7 ||lastof == 8 || lastof ==9)
                    else if (9 > lastof || lastof > 5)
                        {
                    Console.WriteLine($" {age} лет");
                }
         
                    Console.WriteLine("Error");
        }
    }
}

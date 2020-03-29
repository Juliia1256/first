using System;

namespace HomeWork5
{
    class Program
    {
        enum figures
        {
            circle = 1,
            triangle = 2,
            rectangle = 3
        }
        static void Main(string[] args)
        {
            Console.Write("Выберите фигуру из списка: 1 - Круг, 2 - Равносторонний треугольник, 3 - Прямоугольник: ");
            var userAnswer = int.Parse(Console.ReadLine());
            switch userAnswer
                case figures.circle:
                var diametr = 
                

            /*static int ReadInt();
            {
                for (; ;)
                {
                    try
                    {
                        Console.Write(); // add parameters
                        return int.Parse(Console.ReadLine());
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine("Entered wrong value");
                    }
                }
            }
            */


        }
    }
}

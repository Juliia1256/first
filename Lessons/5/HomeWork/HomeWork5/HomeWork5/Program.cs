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
        { // method for handling user input
            static int ReadInt()
            {
                for (; ;)
                {
                    try
                    {
                        Console.WriteLine(); 
                        return int.Parse(Console.ReadLine());
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine("Введены не корректные параметры, попробуйте снова");
                    }
                }
            }
            //the loop allows you to continue the program after handling the exception
            for (;;)
                try
                {
                    Console.Write("Выберите фигуру из списка: 1 - Круг, 2 - Равносторонний треугольник, 3 - Прямоугольник: ");
                    var answer = Enum.Parse(typeof(figures), Console.ReadLine());
                    try
                    {
                        switch (answer)
                        {
                            case figures.circle:
                                Console.Write("Введите диаметр круга: ");
                                var diametrC = ReadInt();
                                Console.WriteLine($"Площадь круга равна {(Math.PI * Math.Pow(diametrC, 2)) / 4}");
                                Console.WriteLine($"Периметр круга равен {diametrC * Math.PI}");
                                Console.WriteLine("Нажмите любую клавишу для продолжения");
                                Console.ReadLine();
                                break;
                            case figures.triangle:
                                Console.Write("Введите длину основания треугольника: ");
                                var osnovT = ReadInt();
                                var hightT = 0.5 * Math.Sqrt(4 * Math.Pow(osnovT, 2) - Math.Pow(osnovT, 2));
                                Console.WriteLine($"Площадь треугольника равна {(osnovT * hightT) / 2}");
                                Console.WriteLine($"Пеример треугольника равен {osnovT + (2 * osnovT)}");
                                Console.WriteLine("Нажмите любую клавишу для продолжения");
                                Console.ReadLine();
                                break;
                            case figures.rectangle:
                                Console.Write("Введите длину прямоугольника: ");
                                var lengthR = ReadInt();
                                Console.Write("Введите ширину прямоугольника: ");
                                var widthR = ReadInt();
                                Console.WriteLine($"Площадь прямоугольника равна {lengthR * widthR}");
                                Console.WriteLine($"Пеример прямоугольника равен {2 * lengthR + 2 * widthR}");
                                Console.WriteLine("Нажмите любую клавишу для продолжения");
                                Console.ReadLine();
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Выбрано значение вне диапозона 1-3, символ или буква. Нажмите любую клавишу для повторного ввода");
                        Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Выбрано значение вне диапозона 1-3, символ или буква. Нажмите любую клавишу для повторного ввода");
                    Console.ReadLine();
                }
        }
    }
}


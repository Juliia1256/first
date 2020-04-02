using System;

namespace HomeWork5
{
    class Program
    {
        enum Figures
        {
            Circle = 1,
            Triangle = 2,
            Rectangle = 3
        }
        // method for handling user input
        static object ReadFigures()
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine();
                    return (Figures)Enum.Parse(typeof(Figures), Console.ReadLine());

                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Введены не корректные параметры, попробуйте снова");
                }
            }
        }
        static double CheckDouble()
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine();
                    return double.Parse(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Введены не корректные параметры, попробуйте снова");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Выберите фигуру из списка: 1 - Круг, 2 - Равносторонний треугольник, 3 - Прямоугольник: ");
            var figure = ReadFigures();
            switch (figure)
            {
                case Figures.Circle:
                    Console.Write("Введите диаметр круга: ");
                    var diametrC = CheckDouble();
                    Console.WriteLine($"Площадь круга равна {(Math.PI * Math.Pow(diametrC, 2)) / 4}");
                    Console.WriteLine($"Периметр круга равен {diametrC * Math.PI}");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    break;
                case Figures.Triangle:
                    Console.Write("Введите длину основания треугольника: ");
                    var osnovT = CheckDouble();
                    var hightT = 0.5 * Math.Sqrt(4 * Math.Pow(osnovT, 2) - Math.Pow(osnovT, 2));
                    Console.WriteLine($"Площадь треугольника равна {(osnovT * hightT) / 2}");
                    Console.WriteLine($"Пеример треугольника равен {osnovT + (2 * osnovT)}");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    break;
                case Figures.Rectangle:
                    Console.Write("Введите длину прямоугольника: ");
                    var lengthR = CheckDouble();
                    Console.Write("Введите ширину прямоугольника: ");
                    var widthR = CheckDouble();
                    Console.WriteLine($"Площадь прямоугольника равна {lengthR * widthR}");
                    Console.WriteLine($"Пеример прямоугольника равен {2 * lengthR + 2 * widthR}");
                    Console.WriteLine("Нажмите любую клавишу для продолжения");
                    Console.ReadLine();
                    break;
            }
        }
        
    }
}


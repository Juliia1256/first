using System;

namespace HW6_2
{
    class Program
    {
        static double CheckDouble()
        {
            for (; ;)
            {                
                try
                {
                    var check = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                    if (check > 0)
                    {
                        return check;
                    }
                    else
                    {
                        Console.WriteLine("Введенные параметры не пригодны для расчета");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены не корректные параметры, попробуйте снова");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"Введено число слишком большое число: {double.MaxValue}");
                }
                catch
                {
                    Console.WriteLine("Упс! Что-то пошло не так...");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите сумму первоначального взноса: ");
            var hensel = CheckDouble();
            Console.Write("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0,01): ");
            var profit = CheckDouble();
            Console.Write("Введите желаемую сумму накопления в рублях: ");
            var accumulation = CheckDouble();
            double calculation = hensel * profit;
            int i = 0;
            double sum = 0;
            for ( i=0; ; i++)
            {
                sum += calculation;
                if (sum>(accumulation-hensel))
                {
                    break;
                }   
            }

            Console.WriteLine($"Первоначальный взнос {hensel} руб.");
            Console.WriteLine($"Желаемая сумма накопления {accumulation} руб.");
            Console.WriteLine($"Ежедневное пополнение в {profit*100}% составит {Math.Round(calculation)} руб.");
            Console.WriteLine($"Количество дней для достижения желаемой суммы {i+1}, сумма накоплений на {i+1} день составит {Math.Round(sum + hensel)}");

        }    
    }
}

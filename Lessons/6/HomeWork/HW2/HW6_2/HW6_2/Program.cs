using System;

namespace HW6_2
{
    class Program
    {
        static double CheckDouble()
        {

            while (true)
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
                        Console.Write("Сумма дожна быть положительным числом");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Введены не корректные параметры, попробуйте снова");
                }
                catch (System.OverflowException)
                {
                    Console.Write("Введено слишком большое число");
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
            int count = 0;
            double sum = 0;
            for ( count=0; ; count++)
            {
                sum += calculation;
                if (sum>(accumulation-hensel))
                {
                    break;
                }   
            }
            Console.WriteLine($"Ежедневное пополнение в {(profit*100):0.##}% составит {calculation:0.##} руб.");
            Console.WriteLine($"Количество дней для достижения желаемой суммы {count+1}, сумма накоплений на {count+1} день составит {(sum + hensel):#.##} руб.");

        }    
    }
}

using System;


namespace HW6_1
{
    class Program
    {
        static int CheckIntFormat()
        {
            Console.WriteLine($"Введите натуральное число больше 0 и меньше 2 000 000 000: ");
            int upperLimit = 2000000000; // if you want change a condition
            while (true)
            {
                try
                {

                    var check = int.Parse(Console.ReadLine());
                    if (upperLimit >check && check > 0)
                    {
                        Console.Write($"Введено число {check}. ");
              
                        return check;                       
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Введены не корректные параметры, попробуйте снова");
                }
                catch (OverflowException)
                {
                    Console.Write("Введено число большего значения, чем указано в инструкции");
                }
            }
        }
        static int Counter()
        {
            var checkCounter = CheckIntFormat();
            var evenElements = 0;
            var iteration = checkCounter;
            var balanceiteration = checkCounter;
            var i= 0;
            for ( ; iteration > 0; i++)
            {
                iteration = iteration / 10;
                balanceiteration = iteration % 10;

                if (balanceiteration % 2 == 0 )
                {
                    evenElements += 1;
                }                 

            }
            Console.WriteLine($@"Количество символов в полученном числе: {i}.
Количество четных элементов: {evenElements}.");
            return evenElements;
        }
        static void Main(string[] args)
        {
            Counter();
            
        }  
    }
}

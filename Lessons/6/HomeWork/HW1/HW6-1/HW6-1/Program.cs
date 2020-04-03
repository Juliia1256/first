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
                catch (System.OverflowException)
                {
                    Console.Write("Введено число большего значения, чем указано в инструкции");
                }
            }
        }
        static int Counter(string answer)
        {
            int evenElements = 0;
            for (int i=1; i<answer.Length; i++)
            {
                string b = answer.Substring(i, 1);
                int condition = int.Parse(b) % 2;
                if (condition == 0)
                {
                    evenElements = evenElements + 1;
                }
            }
            Console.WriteLine($@"Количество символов в полученном числе {answer.Length}.
            Количество четных элементов {evenElements}.");
            return evenElements;
        }
        static void Main(string[] args)
        {
            var answer = CheckIntFormat();
            answer = Counter(Convert.ToString(answer));
            
        }  
    }
}

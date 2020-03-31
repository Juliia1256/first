using System;

namespace HW6_1
{
    class Program
    {
        static int CheckInt()
        {
            int upperLimit = 2000000000; // if you want change a condition
            for (; ; )
            {
                try
                { 
                    Console.WriteLine();
                    var check = int.Parse(Console.ReadLine());
                    if (upperLimit >check && check > 0)
                    {
                        return check;
                    }
                    else
                    {
                        Console.WriteLine("Введенные параметры вне доступного диапазона");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены не корректные параметры, попробуйте снова");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Введено число большего значения, чем указано в инструкции");
                }
                catch 
                {
                    Console.WriteLine("Упс! Что-то пошло не так...");
                }
            }

        }
        static int Counter(string content)
        {
            int characters = content.Length;
            Console.WriteLine($"Количество символов в полученном числе {characters}");
            int evenElements = 0;
            for (int i=1; i<characters; i++)
            {
                string b = content.Substring(i, 1);
                var c = int.Parse(b);
                int condition = c % 2;
                if (condition == 0)
                {
                    evenElements = evenElements + 1;
                }
            }
            return evenElements;
        }
        static void Main(string[] args)
        {

            Console.Write($"Введите натуральное число больше 0 и меньше 2 000 000 000:");
            var answer = CheckInt();
            Console.WriteLine($"Введено число {answer}");
            var content = Convert.ToString(answer);
       
            Console.WriteLine($"Количество четных элементов {Counter(content)}");
            Console.ReadLine();
        }  
    }
}

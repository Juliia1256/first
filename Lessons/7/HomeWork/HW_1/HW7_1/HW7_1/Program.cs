using System;

namespace HW7_1
{
    class Program
    {
        static string []  CheckString()
        {
            Console.WriteLine($"Введите предложение минимум из 2х слов: ");
            string [] treatment = null;
            do
            {

                var forCheck = Console.ReadLine();
                treatment = forCheck.Split(' '); //break the string into an array of words
                if (treatment.Length < 2)
                {
                    Console.WriteLine($"Введено меньше двух слов, повторите попытку:");
                }
        
            }
            while (treatment.Length < 2);

            return treatment;
            
        }

        static string СalculationString()
        {
            var processedarray = CheckString();
            var count = 0;
            foreach (string letter in processedarray)
            {
                if (letter.StartsWith("a", StringComparison.InvariantCultureIgnoreCase))   //if more than two words, consider starting with the letter "a"
                {
                    count += 1;
                }
            }
            string positivanswer = $"Количество слов, на чинающихся с буквы 'А' равно {count}";
            string negativeanswer = $"В введенном предложении нет слов, начинающихся с буквы 'А'.";
            var msg = (count > 0) ? positivanswer : negativeanswer;                 //choose the answer depending on the result of the count
            Console.WriteLine(msg);
            return msg;
        }

        static void Main(string[] args)
        {
            СalculationString();
        }
    }
}

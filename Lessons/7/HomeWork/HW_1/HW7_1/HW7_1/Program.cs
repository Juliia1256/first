using System;

namespace HW7_1
{
    class Program
    {
        static string CheckStringFormatAndLetterCounter()
        {
            Console.WriteLine($"Введите предложение минимум из 2х слов: ");
            while (true)
            {
                try
                {
                    var forCheck = Console.ReadLine();
                    var treatment = forCheck.Split(' '); //break the string into an array of words
                    var count = 0;
                    var lettercount = 0;
                    foreach (string str in treatment)     
                    {
                        for (var i = 0; i < treatment.Length; i++)     //count the number of words, if less than two, repeat
                            lettercount += 1;
                            if (lettercount < 2)
                            {
                                Console.WriteLine($"Введено меньше двух слов, повторите попытку:");
                                break;
                            }
                    }
                    if (lettercount >= 2)
                    {
                        foreach (string letter in treatment)
                        {
                            if (letter.StartsWith("a", StringComparison.InvariantCultureIgnoreCase))   //if more than two words, consider starting with the letter "a"
                            {
                                count += 1;
                            }
                        }
                        string positivanswer = $"Количество слов, на чинающихся с буквы 'А' равно {count}";
                        string negativeanswer = $"В введенном предложении нет слов, начинающихся с буквы 'А'.";
                        var msg = (count > 0) ? positivanswer : negativeanswer;                 //choose the answer depending on the result of the count
                        return msg;
                    }
                }       
                catch (FormatException)
                {
                    Console.Write("Введены не корректные параметры, попробуйте снова");
                }
            }
        }
        static void Main(string[] args)
        {
           Console.WriteLine(CheckStringFormatAndLetterCounter());
        }
    }
}

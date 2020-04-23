using System;

namespace HW10
{
    class Program
    {
        static string CheckName()
        {
            while(true)
            {
                var checkstring = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(checkstring))
                {
                    Console.WriteLine("Попробуйте еще раз");
                    continue;
                }
                return checkstring.ToUpper().Trim();
            }
            
        }
        static int CheckAge()
        {
            while (true)
            {
                try
                {
                    var checkint = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (checkint > 0 && checkint < 140)
                    {
                        return checkint;
                    }
                    Console.WriteLine("Возраст должен находиться в приемлемом диапазоне");
                }
                catch (FormatException)
                {
                    Console.Write("Введены не корректные параметры, попробуйте снова");
                }

            }
        }
        static void Main(string[] args)
        {
            {
                var persons = new Person[3];

                for (var i = 0; i < persons.Length; i++)
                {
                    persons[i] = new Person();

                    Console.Write($"Enter {i + 1} name: ");
                    persons[i].Name = CheckName();

                    Console.Write($"Enter {i + 1} age: ");
                    persons[i].Age = CheckAge();
                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person.Description);
                }
                Console.ReadKey();
            }
        }
    }
}

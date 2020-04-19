using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var persons = new Person[3];

                for (var i = 0; i < persons.Length; i++)
                {
                    persons[i] = new Person();

                    Console.Write($"Enter {i + 1} name: ");
                    persons[i].Name = Console.ReadLine();

                    Console.Write($"Enter {i + 1} age: ");
                    persons[i].Age = int.Parse(Console.ReadLine());
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

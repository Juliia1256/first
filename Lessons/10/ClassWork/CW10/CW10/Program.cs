using System;

namespace CW10
{
    class Pet
    {
        public string Kind;
        public string Name;
        public char Sex;
        public int Age;


    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet();
            p1.Kind = "Pig";
            p1.Name = "Dusi";
            p1.Sex = 'F';
            p1.Age = 2;
            Console.WriteLine($"Name {p1.Name} is a {p1.Kind } {p1.Sex} of {p1.Age} years old.");

            Pet p2 = new Pet
            {
                Kind = "cat",
                Name = "Maru",
                Sex = 'F',
                Age = 7
            };
        
            Console.WriteLine($"Name {p2.Name} is a {p2.Kind } {p2.Sex} of {p2.Age} years old.");
        }
    }
}

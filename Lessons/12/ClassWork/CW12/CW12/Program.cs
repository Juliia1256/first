using System;

namespace CW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc1 = new BaseDocument("Document", "123456789", 2020, 04, 17, 15, 30, 0);
            var pas1 = new Passport("Russia", "Ivanov Ivan", "6554332322", 2010, 12, 14, 15, 30, 0);



            pas1.WriteToConsole();
        }
    }
}

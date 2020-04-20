using System;

namespace CW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc1 = new BaseDocument
            {
                Title = "Document",
                Number = "123456789",
                IssueDate = new DateTime(2020, 04, 17, 15, 30, 0),
            };
            var pas1 = new Passport
            {
                Country = "Russia",
                PersonName = "Ivanov Ivan",
                Title = "Pass",
                Number = "6554332322",
                IssueDate = new DateTime(2010, 12, 14, 15, 30, 0),
            };


            pas1.WriteToConsole();
        }
    }
}

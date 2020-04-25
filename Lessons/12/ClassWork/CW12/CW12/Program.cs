using System;

namespace CW12
{
    class Program
    {
        static void Main(string[] args)
        {
            var documents = new BaseDocument[4]
            {
            new BaseDocument(title: "Document", number: "123456789", issueDate: DateTimeOffset.Parse("2012-04-12")),
            new Passport(number: "123456789", issueDate: DateTimeOffset.Parse("2010-07-10"), country: "Russia", personName: "Ivanov Igor"),
            new Passport(number: "153455555", issueDate: DateTimeOffset.Parse("2000-01-01"), country: "Ukraine", personName: "Sydorov Nikolay"),
            new BaseDocument(title: "Document", number: "111111189", issueDate: DateTimeOffset.Parse("2019-05-09"))
            };
        
            foreach (var document in documents)
            {
                if (document is Passport passport)
                {
                    passport.ChangeIssueDate(DateTimeOffset.UtcNow);
                }
                document.WriteToConsole();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class BaseDocument
    {
        public string Title {get; set;}
        public string Number { get; set; }
        public DateTimeOffset IssueDate { get; set; }
        public virtual string Description => $"Type of document: {Title} \n Documet's number: {Number} \n Issue date: {IssueDate:dd-MM-yyyy}";

        public BaseDocument(string title, string number, DateTimeOffset issueDate)
        {
            Title = title;
            Number = number;
            IssueDate = issueDate;
        }

        public void WriteToConsole()
        {
            Console.WriteLine(Description);
        }

    }
}

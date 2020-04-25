using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }
        public Passport (string number, DateTimeOffset issueDate, string country, string personName) 
            :  base("Passport", number, issueDate)
        {
            Country = country;
            PersonName = personName;
        }

        public override string Description => $"Type of document: {Title} \n Documet's number: {Number} \n Issue date: {IssueDate:dd-MM-yyyy} \n Country: {Country} \n Person name: {PersonName}";
        public void ChangeIssueDate(DateTimeOffset newIssueDate)
        {
            IssueDate = newIssueDate;
        }
    }
}

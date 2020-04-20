using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class Passport : BaseDocument
    {
        public string Country;
        public string PersonName;
        public Passport (string Country, string PersonName, string Number, DateTime IssueDate) :  base(Number, IssueDate)
        {

        }

        public override string Description
        {
            get
            {
                return $"{Country} , {PersonName} , {Title} , {Number} , {IssueDate} ";
            }
        }


        //public new void WriteToConsole()
        //{
        //    Console.WriteLine(Description);
        //}
    }
}

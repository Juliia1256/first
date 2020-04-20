using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class Passport : BaseDocument
    {
        public string Country { get; set; }
        public string PersonName { get; set; }

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

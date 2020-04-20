using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class BaseDocument
    {
        public string Title;
        public string Number;
        public DateTime IssueDate;

        public BaseDocument(string Title, string Number, DateTime IssueDate) : base(Number, IssueDate)
        {

        }

        public virtual string Description
        {
            get
            {
                return $"{Title} , {Number} , {IssueDate}  ";
            }
        }


        public void WriteToConsole()
        {
            Console.WriteLine(Description);
        }
    }
}

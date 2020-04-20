using System;
using System.Collections.Generic;
using System.Text;

namespace CW12
{
    class BaseDocument
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }


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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CW14
{
    static class ErrorList 
    {
        public static string Category { get; set; }
        private static List<string> _errors;
        public static string OutputPrefixFormat { get; set; }

        private static string _outputPrefix
        {
            get
            {
                return DateTime.Now.ToString(OutputPrefixFormat);
            }
        }

        static ErrorList()
        {
            Category = "error";
            _errors = new List<string>();
            OutputPrefixFormat = "MMMM d, yyyy (hh:mm tt)";
        }

        public static void Add(string errorMessage)
        {
            _errors.Add(errorMessage);
        }


        public static void WrightToConsole()
        {
            foreach(var item in _errors)
            {
                Console.WriteLine(string.Format($"{_outputPrefix} {Category} {item}"));
            }
            
        }


        public static IEnumerator<string> GetEnumerator()
        {
            var iitem = _errors.GetEnumerator();
            return iitem;
        }
    }
}

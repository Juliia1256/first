using System;

namespace CW14
{
    class Program
    {
        static void Main(string[] args)
        {
            ErrorList.Category = "Errors";
            ErrorList.Add("new error");
            ErrorList.Add("some error");
            ErrorList.WrightToConsole();



        }
    }
}

using System;

namespace CW14
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var examp = new ErrorList(category: "error"))
            {
                examp.Add("new error");
                foreach (var item in examp.Errors)
                {
                    Console.WriteLine(item);
                }
             }

        }
    }
}

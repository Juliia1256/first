using System;

namespace ClassWork4
{
    enum colors
    {
        black,
        blue,
        gray,
        green,
        magenta,
        red,
        white,
        yellow,
        cyan
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the name of color: ");
            var answer = Enum.Parse(typeof (colors), Console.ReadLine());
            Console.WriteLine($"Your color is {answer}");
            /*  
             var a= Convert.ToDouble (Console.ReadLine());
             var hsmall = Convert.ToDouble(Console.ReadLine());


              double sBrink = 3 * (a * hsmall);
              double sfull = (3.0 / 2) * a *(a * Math.Sqrt(3.0) + 2.0 * hsmall);
              double hbig = Math.Sqrt(hsmall * hsmall - (a * a) / 12.0);
              double v = ((a * a)/ 2.0) * hbig * Math.Sqrt(3.0);

              Console.WriteLine("SBrink " + sBrink);
              Console.WriteLine("Sfull " + sfull);
              Console.WriteLine("V " + v);*/

        }
    }
}

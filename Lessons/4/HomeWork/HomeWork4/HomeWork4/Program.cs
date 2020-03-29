using System;
using System.Dynamic;

namespace HomeWork4
{
    enum Containers :byte
    {   
        conttwenty = 0b00010100,
        contfive = 0b00000101,
        contone = 0b00000001
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");

            var desiredvolume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вам потребуются следующие контейнеры:");

            int fulltwenty = (int)desiredvolume / (int)Containers.conttwenty;

            if (fulltwenty > 0)
            {
                Console.WriteLine($" 20 л: {fulltwenty} шт.");
 
            }
            else 
            {
            }
            double balancetwenty = (double)desiredvolume % (double)Containers.conttwenty;
            

            int fullfive = (int)balancetwenty / (int)Containers.contfive;
            if (fullfive > 0)
            {
                Console.WriteLine($" 5 л: {fullfive} шт.");

            }
            else
            {
            }
            double balancefive = (double)balancetwenty % (double)Containers.contfive;
           
            double fullone = Math.Ceiling((double)balancefive / (double)Containers.contone);
            if (fullone > 0)
            {
                Console.WriteLine($" 1 л: {fullone} шт.");
            }
            else
            {
            }
            Console.ReadLine();
        }

    }
}

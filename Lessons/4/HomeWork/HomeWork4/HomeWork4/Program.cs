using System;

namespace HomeWork4
{
    enum Containers :byte
    {   
        conttwenty = 0b00010100,
        contfive =   0b00000101,
        contone =    0b00000001
    }
    enum ContType :byte
    {
        typetwenty = 0b00000100,
        typefive =   0b00000010,
        typeone =    0b00000001
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");
            var desiredvolume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вам потребуются следующие контейнеры:");

            int fulltwenty = (int)desiredvolume / (int)Containers.conttwenty;
            var flagfulltwenty = fulltwenty | (byte)ContType.typetwenty; //add flag
            flagfulltwenty = flagfulltwenty & (byte)ContType.typetwenty; //check with container
            double balancetwenty = (double)desiredvolume % (double)Containers.conttwenty; //remainder of division for calculation
            
            int fullfive = (int)balancetwenty / (int)Containers.contfive;
            var flagfullfive = fullfive | (byte)ContType.typefive; //add flag
            flagfullfive = flagfullfive & (byte)ContType.typefive; //check with container
            double balancefive = (double)balancetwenty % (double)Containers.contfive; //remainder of division for calculation

            double fullone = Math.Ceiling((double)balancefive / (double)Containers.contone); //rounding operation
            var flagfullone = (int)fullone | (byte)ContType.typeone; //add flag
            flagfullone = flagfullone & (byte)ContType.typeone; //check with container


            if (flagfulltwenty == (byte)ContType.typetwenty) //check availability
            {
                Console.WriteLine($" 20 л: {fulltwenty} шт.");
            }
            else if (flagfulltwenty != (byte)ContType.typetwenty)
            {
            }
            if (flagfullfive == (byte)ContType.typefive) //check availability
            {
                    Console.WriteLine($" 5 л: {fullfive} шт.");
            }
            else if (flagfullfive != (byte)ContType.typefive)
            {
            }
            if (flagfullone == (byte)ContType.typeone) //check availability
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

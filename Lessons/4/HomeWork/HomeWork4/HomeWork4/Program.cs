using System;
using System.Reflection.Metadata.Ecma335;

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
            int fulltwenty = (int)desiredvolume / (int)Containers.conttwenty;
            double balancetwenty = (double)desiredvolume % (double)Containers.conttwenty; //remainder of division for calculation
            int fullfive = (int)balancetwenty / (int)Containers.contfive;
            double balancefive = (double)balancetwenty % (double)Containers.contfive; //remainder of division for calculation
            double fullone = Math.Ceiling((double)balancefive / (double)Containers.contone); //rounding operation


            var flags = 0b00000000;
            if (fulltwenty > 0) 
            {
                flags = flags |(byte)ContType.typetwenty; //add flag 20
                
            }
            if (fullfive > 0)
            {
                flags = flags | (byte)ContType.typefive; //add flag 5
            }
            if (fullone > 0)  
            {
                flags = flags | (byte)ContType.typeone; //add flag 1
            }

            Console.WriteLine("Вам потребуются следующие контейнеры:");
            if ((flags & (byte)ContType.typetwenty) == (byte)ContType.typetwenty) //check availability 20
            {
                Console.WriteLine($" 20 л: {fulltwenty} шт.");
            }
            if ((flags & (byte)ContType.typefive) == (byte)ContType.typefive) //check availability 5
            {
                Console.WriteLine($" 5 л: {fullfive} шт.");
            }
            if ((flags & (byte)ContType.typeone) == (byte)ContType.typeone) //check availability 5
            {
                Console.WriteLine($" 1 л: {fullone} шт.");
            }
        }
    }
}

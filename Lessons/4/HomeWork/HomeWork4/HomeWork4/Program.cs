using System;

namespace HomeWork4
{
    enum Containers :byte
    {   
        conttwenty = 0b00010100,
        contfive =   0b00000101,
        contone =    0b00000001
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока (в литрах) требуется упаковать?");

            var desiredvolume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вам потребуются следующие контейнеры:");
            

            int fulltwenty = (int)desiredvolume / (int)Containers.conttwenty;
            var flagfulltwenty = fulltwenty | (int)Containers.conttwenty;
            if (fulltwenty > 0) //в этом случае работает, и при пустом else контейнеры не выводятся
            //if ((flagfulltwenty & (int)Containers.conttwenty) == (int)Containers.conttwenty)
                /* например, мы ввели число 21, тогда, при включении флага, переменная = 20 (стр.23):
                   |
                 0   0  0
                 1   1  1
                 0   0  0
                 1   1  1
                 0   0  0
                 1   0  0
                 при проверке в части if(стр.24) мы объединяем переменную с флагом и контейнер 20 и далее сравниваем результат с контейнером 20, но он уже равен 20! Зачем?:
                    &       ==
                 0   0  0    0
                 1   1  1    1
                 0   0  0    0
                 1   1  1    1
                 0   0  0    0
                 0   0  0    0 */
            {
                Console.WriteLine($" 20 л: {fulltwenty} шт.");
            }
            //else if ((flagfulltwenty & (int)Containers.conttwenty) == 0) 
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

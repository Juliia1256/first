
using System;

namespace HomeWork3JSH
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //declaring an array requesting names
                int sizearray = 3;
                Console.WriteLine("Please, enter Your name:");
                string[] usersname = new string[sizearray];
                try
                {
                    for (var i = 0; i < 3; i++)
                    {
                        usersname[i] = Console.ReadLine();
                    }
                    //declaring an array requesting age

                    Console.WriteLine("Please, enter Your age:");
                    int[] usersage = new int[sizearray];

                    for (int i = 0; i < 3; i++)
                    {
                        usersage[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    //output array values, users age after 4 years
                    int aging = 4;
                    for (var i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Name:" + usersname[i] + ", age in 4 years: " + (usersage[i] + aging));
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect data entered");
                }
            }
        }
    }
}

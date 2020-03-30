
using System;

namespace HomeWork3JSH
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                Console.WriteLine("Please, enter the length of array:");
                int count = int.Parse(Console.ReadLine());

                //declaring an array requesting names
                Console.WriteLine("Please, enter Your name:");
                string[] usersname = new string [count];

                    for (var i = 0; i < usersname.Length; i++)
                    {
                        usersname[i] = Console.ReadLine();
                    }
                    //declaring an array requesting age

                    Console.WriteLine("Please, enter Your age:");
                    int[] usersage = new int[count];

                    for (int i = 0; i < usersage.Length; i++)
                    {
                        usersage[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    //output array values, users age after 4 years
                    int aging = 4;
                    for (var i = 0; i < usersname.Length; i++) //output equals typed names
                    {
                        Console.WriteLine("Name:" + usersname[i] + ", age in 4 years: " + (usersage[i] + aging));
                    }
            }
        }
    }
}

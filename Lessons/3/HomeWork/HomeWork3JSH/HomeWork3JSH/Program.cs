using Microsoft.VisualBasic;
using System;

namespace HomeWork3JSH
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //declaring an array requesting names

                Console.WriteLine("Please, enter Your name:");
                string[] usersname = new string[3];
                
                    for (var i = 0; i < 3; i++)
                    {
                        usersname[i] = Console.ReadLine();
                    }
                //declaring an array requesting age

                Console.WriteLine("Please, enter Your age:");
                int[] usersage = new int[3];
               
                for ( int h = 0; h < 3; h++)
                {
                        usersage[h] = Convert.ToInt32(Console.ReadLine()); 
                }
                //output array values, users age after 4 years
                int b = 4;
                for (var a = 0; a < 3; a++)
                {
                    Console.WriteLine("Name:" + usersname[a] + ", age in 4 years: " + Convert.ToInt32(usersage[a] + b));
                }

            }
        }
    }
}
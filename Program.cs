// Programmer: Ashley Hills
// Project: Tech Project 3b
// Date: 09/24/2020
// Description: A console program that demonstrates the use of an Auto-Populated Array 
using System;

namespace Tech_Project_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new[] {  0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            for (int i = 1; i < 26; i++)
            {
                Console.WriteLine("Element Value = " + Array[i]);

                if (Array[i] == 25)
                {
                    Console.WriteLine("Array interations have ended...");
                    Console.WriteLine("Press any key to exit this program...");
                }
            }

            Console.ReadKey(true);
        }
    }
}

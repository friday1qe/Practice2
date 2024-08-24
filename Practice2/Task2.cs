using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Task2
    {
        public static void SecondTask()
        {
            Console.WriteLine("Write your number");
            string number = Console.ReadLine();
            int heightNumber = int.Parse(number);

            int spaces = heightNumber;
            for (int i = 1; i <= heightNumber; i++)
            {
                for (int s = spaces; s > 0; s--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write(" \n");
                spaces--;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Task1
    {
        public static void FirstTask()
        {
            Console.WriteLine("Hello, Write year!");
            string year = Console.ReadLine();
            int yearNumber = int.Parse(year);

            bool isDividedby4 = yearNumber % 4 == 0;
            bool isDividedby100 = yearNumber % 100 == 0;
            bool isDividedby400 = yearNumber % 400 == 0;
            bool isLeapYear = isDividedby400 || isDividedby4 && isDividedby100;

            if (isLeapYear)
            {
                Console.WriteLine("Year is leap");
            }
            else { Console.WriteLine("Year is not leap"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Task3
    {
        public static void ThirdTask()
        {
            int currentUserScore = 0;
            Console.WriteLine("Це гра Хто хоче стати міліонером\n");


            Console.WriteLine("Your score: " + currentUserScore);
            Console.WriteLine("Питання 1 \nЯкі кольори у прапора України? \n    1. жовтий і блакитний \n    2. червоний і зелений \n    3. чорний і жовтий \n    4. зелений і фіолетовий");
            Console.Write("Обер1ть номер відповіді: ");
            string answer1 = Console.ReadLine();
            int yourAnswer1 = int.Parse(answer1);
            if (yourAnswer1 == 1)
            {
                Console.WriteLine("Відповідь правильна!");
                currentUserScore += 100;
            } else
            {
                Console.WriteLine("Відповідь не правильна!");
            }


            Console.WriteLine("\nYour score: " + currentUserScore);
            Console.WriteLine("Питання 2 \nСкільки регіонів в Україні? \n    1. 52 \n    2. 5 \n    3. 27 \n    4. 160");
            Console.Write("Обер1ть номер відповіді: ");
            string answer2 = Console.ReadLine();
            int yourAnswer2 = int.Parse(answer2);
            if (yourAnswer2 == 3)
            {
                Console.WriteLine("Відповідь правильна!");
                currentUserScore += 100;
            }
            else
            {
                Console.WriteLine("Відповідь не правильна!");
            }


            Console.WriteLine("\nYour score: " + currentUserScore);
            Console.WriteLine("Питання 2 \nКрим? \n    1. Український \n    2. Український \n    3. Український \n    4. Український");
            Console.Write("Обер1ть номер відповіді: ");
            string answer3 = Console.ReadLine();
            int yourAnswer3 = int.Parse(answer3);
            if (yourAnswer3 == 1 || yourAnswer3 == 2 || yourAnswer3 == 3 || yourAnswer3 == 4)
            {
                Console.WriteLine("Відповідь правильна!");
                currentUserScore += 100;
            }
            else
            {
                Console.WriteLine("Відповідь - Український");
            }


            Console.WriteLine("\nYour score: " + currentUserScore);
            Console.WriteLine("Питання 2 \nВ якому місті знаходиться ДТЕУ? \n    1. Вінниця \n    2. Київ \n    3. Львів \n    4. Одеса");
            Console.Write("Обер1ть номер відповіді: ");
            string answer4 = Console.ReadLine();
            int yourAnswer4 = int.Parse(answer4);
            if (yourAnswer4 == 2)
            {
                Console.WriteLine("Відповідь правильна!");
                currentUserScore += 100;
            }
            else
            {
                Console.WriteLine("Відповідь не правильна!");
            }


            Console.WriteLine("\nYour score: " + currentUserScore);
            Console.WriteLine("Питання 2 \nСкільки факультетів в ДТЕУ? \n    1. 10 \n    2. 2 \n    3. 15 \n    4. 6");
            Console.Write("Обер1ть номер відповіді: ");
            string answer5 = Console.ReadLine();
            int yourAnswer5 = int.Parse(answer5);
            if (yourAnswer5 == 4)
            {
                Console.WriteLine("Відповідь правильна!");
                currentUserScore += 100;
            }
            else
            {
                Console.WriteLine("Відповідь не правильна!");
            }

            Console.WriteLine("\nГра закінчена!\nYour score: " + currentUserScore);
        }
    }
}

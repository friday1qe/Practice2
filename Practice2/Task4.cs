using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Task4
    {
        public static void FourthTask()
        {
            Console.WriteLine("Введіть математичний вираз:");
            string input = Console.ReadLine();

            try
            {
                // Використовуємо DataTable для обчислення виразу
                DataTable table = new DataTable();
                var result = table.Compute(input, "");

                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка в обчисленні: " + ex.Message);
            }
        }
    }
}

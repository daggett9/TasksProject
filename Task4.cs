using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task4
    {
        enum DayWeek
        {
            Понедельник = 1, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье
        }
        public static void Days()
        {
            int num;

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите день недели:");
                string input = Console.ReadLine();
                DayWeek DW;

                if (Int32.TryParse(input, out num))
                {
                    num = int.Parse(input);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод!");
                }

                DW = (DayWeek)num;

                if (num == 1)
                    Console.WriteLine(DW.ToString() + " - Начало рабочей недели");
                else if (((num == 2) || (num == 3) || (num == 4)))
                    Console.WriteLine(DW.ToString() + " - Середина рабочей недели");
                else if ((num == 5))
                    Console.WriteLine(DW.ToString() + " - Конец рабочей недели");
                else if ((num == 6) || (num == 7))
                    Console.WriteLine(DW.ToString() + " - Выходной день");
                else
                {
                    Console.WriteLine("Пожалуйста, введите значение от 1 до 7");
                    flag = true;
                    continue;
                }
            }
        }
    }
}

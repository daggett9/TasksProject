using System;

namespace Task
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Task 1");
            Task1.Array();
            Console.WriteLine();

            Console.WriteLine("Task 2");
            Task2.Stepen();
            Console.WriteLine();

            Console.WriteLine("Task 3");
            bool flag3 = true;

            while (flag3)
            {
                Console.WriteLine("Введите значение L:");
                string input3 = Console.ReadLine();
                if (Int32.TryParse(input3, out int L))
                {
                    L = int.Parse(input3);
                    flag3 = false;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    continue;
                }

                Console.WriteLine("Is value even? - " + Task3.LogicMethod(L));
                Console.WriteLine();

                Console.WriteLine("Task 4");
                Task4.Days();
            }
        }
    }
}

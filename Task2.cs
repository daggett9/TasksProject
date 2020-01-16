using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task2
    {
        public static void Stepen()
        {
            bool flag1 = true;
            while (flag1)
            {
                Console.WriteLine("Введите число A для возведения в степень:");
                string input1 = Console.ReadLine();
                if (Int32.TryParse(input1, out int A))
                {
                    A = int.Parse(input1);
                    flag1 = false;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    continue;
                }
                TestMethod(ref A, out double B);
            }
            static void TestMethod(ref int A, out double B)
            {
                B = Math.Pow(A, 5);
                Console.WriteLine("B = A^5 = " + B);
            }
        }
    }
}

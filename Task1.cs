using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task1
    {
        public static void Array()
        {
            int[,] array = new int[5, 5]; // объявляем двумерный массив 5х5
            Random rand = new Random();

            Console.WriteLine("Все элементы массива:");
            for (int i = 0; i < 5; i++) // объявляем 2 циклf для перебора всех элементов массива. i - строки, j - столбцы
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(100); // заполняем массив случайными значениями, промежутка от 0 до 100
                    Console.Write("{0}\t", array[i, j]); // выводим массив в виде матрицы
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Элементы массива из нечётных столбцов:");
            for (int i = 0; i < 5; i++) // объявлем новый цикл, для вывода нечётных столбцов
            {
                for (int j = 0; j < 5; j += 2) // пробегаем по столбцам 1, 3 и 5
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

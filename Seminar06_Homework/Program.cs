using System;

namespace Homework06 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintArray(int[] Array)
            {
                int Length = Array.Length;
                for (int i = 0; i < Length; i++) Console.Write(Array[i] + " ");
                Console.WriteLine();
            }

            // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

            void Zadacha41()
            {
                int Counter = 0;
                Console.Write("Enter number M (> 0): ");
                int M = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[M];
                Console.WriteLine("Enter M numbers:");
                for (int i = 0; i < M; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (numbers[i] > 0) Counter++;
                }
                Console.WriteLine("Вы ввели массив:");
                PrintArray(numbers);
                Console.WriteLine($"В массиве есть {Counter} чисел больше 0");
                Console.WriteLine();
            }

            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

            void Zadacha43()
            {
                int x1 = 0;
                int y1 = 0;
                Console.WriteLine("Определите прямую y = k1 * x + b1 Введите коэффиценты");
                Console.Write("k1 = ");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("b1 = ");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Определите прямую y = k2 * x + b2 Введите коэффиценты");
                Console.Write("k2 = ");
                int k2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("b2 = ");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вы ввели прямые:");
                Console.WriteLine($"y = {k1} * x + {b1}");
                Console.WriteLine($"y = {k2} * x + {b2}");
                if (k1 == k2 && b1 == b2) Console.WriteLine("Вы ввели совпадающие прямые. Точек пересечения бесконечно много.");
                else if (k1 == k2 && b1 != b2) Console.WriteLine("Вы ввели паралельные прямые. Точек пересечения нет.");
                else
                {
                    x1 = (b2 - b1) / (k1 - k2);
                    y1 = k1 * x1 + b1;
                    Console.WriteLine($"Точкa пересечения двух прямых точка с координатами {x1}, {y1}");
                }
            }

            Console.WriteLine("Задача 41");
            Zadacha41();
            Console.WriteLine();
            Console.WriteLine("Задача 43");
            Zadacha43();
            Console.WriteLine();
        }
    }
}
using System;

namespace Homework05 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void FillArray(int[] Array, int Min_Value = 0, int Max_Value = 100)
            {
                int Length = Array.Length;
                Random rnd = new Random();
                for (int i = 0; i < Length; i++) Array[i] = rnd.Next(Min_Value, Max_Value);
            }

            void PrintArray(int[] Array)
            {
                int Length = Array.Length;
                for (int i = 0; i < Length; i++) Console.Write(Array[i] + " ");
                Console.WriteLine();
            }

            int MaxArray(int[] Array)
            {
                int Max = Array[0];
                int Length = Array.Length;
                for (int i = 1; i < Length; i++)
                {
                    if (Array[i] > Max) Max = Array[i];
                }
                //Console.WriteLine("Max =  " + Max);
                return Max;
            }

            int MinArray(int[] Array)
            {
                int Min = Array[0];
                int Length = Array.Length;
                for (int i = 1; i < Length; i++)
                {
                    if (Array[i] < Min) Min = Array[i];
                }
                //Console.WriteLine("Min =  " + Min);
                return Min;
            }

            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

            void Zadacha34()
            {
                int Count = 0;
                int Size = 20;
                int[] numbers = new int[Size];
                FillArray(numbers, 100, 1000);
                PrintArray(numbers);
                for (int i = 0; i < Size; i++)
                {
                    if (numbers[i] % 2 == 0) Count++;
                }
                Console.WriteLine();
                Console.WriteLine($"В массиве {Count} чётных чисел");
            }

            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

            void Zadacha36()
            {
                int Sum_Odd = 0;
                int Size = 10;
                int[] numbers = new int[Size];
                FillArray(numbers);
                PrintArray(numbers);
                for (int i = 1; i < Size; i += 2) Sum_Odd += numbers[i];
                Console.WriteLine();
                Console.WriteLine($"Сумма элементов с нечётным индексом = {Sum_Odd}");
            }


            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

            void Zadacha38()
            {
                int Delta_Min_Max = 0;
                int Size = 10;
                int[] numbers = new int[Size];
                FillArray(numbers, -100, 100);
                PrintArray(numbers);
                int Max = MaxArray(numbers);
                int Min = MinArray(numbers);
                Delta_Min_Max = Max - Min;
                Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + Delta_Min_Max);
            }

            Console.WriteLine("Задача 34");
            Zadacha34();
            Console.WriteLine();
            Console.WriteLine("Задача 36");
            Zadacha36();
            Console.WriteLine();
            Console.WriteLine("Задача 38");
            Zadacha38();
        }
    }
}

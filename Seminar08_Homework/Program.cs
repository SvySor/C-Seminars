using System;

namespace Homework06 // Двумерные массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DescendingLines(Double[,] Array)
            {
                int rows = Array.GetLength(0);
                int columns = Array.GetLength(1);
                double min = Array[0, 0];
                for (int i = 0; i < rows; i++)
                {
                    min = Array[i, 0];
                    for (int j = 0; j < columns; j++)
                    {
                        for (int k = 0; k < columns - j - 1; k++)
                        {
                            if (Array[i, k] < Array[i, k + 1])
                            {
                                min = Array[i, k];
                                Array[i, k] = Array[i, k + 1];
                                Array[i, k + 1] = min;
                            }
                        }
                    }
                }
            }

            //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

            void Zadacha54()
            {
                int rows = 4;
                int columns = 5;
                int digits = 2;
                double[,] numbers = new double[rows, columns];
                FillArray(numbers, 0, 10);
                RoundDigits(numbers, digits);
                PrintArray(numbers);
                DescendingLines(numbers);
                Console.WriteLine();
                PrintArray(numbers);
            }

            //Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            void Zadacha56()
            {
                int rows = 6;
                int columns = 8;
                int digits = 2;
                double[,] numbers = new double[rows, columns];
                double[] summColumns = new double[columns];
                FillArray(numbers, 0, 10);
                RoundDigits(numbers, digits);
                PrintArray(numbers);
                Console.WriteLine();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        summColumns[i] = summColumns[i] + numbers[i, j];

                    }
                    summColumns[i] = Math.Round(summColumns[i], digits);
                    Console.WriteLine(summColumns[i]);
                }
                int numMinRow = 0;
                double minSumRow = summColumns[numMinRow];
                for (int i = 0; i < rows; i++)
                {
                    if (minSumRow > summColumns[i])
                    {
                        numMinRow = i;
                        minSumRow = summColumns[i];
                    }
                }
                Console.WriteLine($"Минимальная сумма чисел {minSumRow} находится в {numMinRow + 1} ряду");
            }

            // Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
            // 01 02 03 04
            // 12 13 14 05
            // 11 16 15 06
            // 10 09 08 07

            void Zadacha58()
            {
                int rows = 4;
                int columns = 4;
                int[,] numbers = new int[rows, columns];
                int size = rows * columns;
                int k = 1;
                int begI = 0;
                int begJ = 0;
                int endI = rows;
                int endJ = columns;
                int i = 0, j = 0;
                while (k <= size)
                {
                    numbers[i, j] = k;
                    if (i == begI && j < endJ - 1)
                        j++;
                    else if (j == endJ - 1 && i < endI - 1)
                        i++;
                    else if (i == endI - 1 && j > begJ)
                        j--;
                    else
                        i--;
                    if ((i == begI + 1) && (j == begJ) && (begJ != endJ - 1))
                    {
                        begI++;
                        endI--;
                        begJ++;
                        endJ--;
                    }
                    k++;
                }
                PrintArray(numbers);
            }

            Console.WriteLine();
            Console.WriteLine("Задача 54");
            Zadacha54();
            Console.WriteLine();
            Console.WriteLine("Задача 56");
            Zadacha56();
            Console.WriteLine();
            Console.WriteLine("Задача 58");
            Zadacha58();
            Console.WriteLine();
        }

        static void FillArray(int[,] Array, int minValue = 0, int maxValue = 99)
        {
            maxValue++;
            Random rnd = new Random();
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array[i, j] = rnd.Next(minValue, maxValue);
                }
            }
        }

        static void FillArray(double[,] Array, double minValue = 0, double maxValue = 1)
        {
            Random rnd = new Random();
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array[i, j] = minValue + rnd.NextDouble() * (maxValue - minValue);
                }
            }
        }

        static void PrintArray(int[,] Array)
        {
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray(double[,] Array)
        {
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void RoundDigits(double[,] Array, int digits)
        {
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array[i, j] = Math.Round(Array[i, j], digits);
                }
            }
        }


    }
}
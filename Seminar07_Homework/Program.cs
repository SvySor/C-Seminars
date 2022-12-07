using System;

namespace Homework06 // Двумерные массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FillArrayInt(int[,] Array, int minValue = 0, int maxValue = 99)
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

            void PrintArrayInt(int[,] Array)
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

            void FillArrayDouble(double[,] Array, double minValue = 0, double maxValue = 1)
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

            void RoundDigits(double[,] Array, int digits)
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

            void PrintArrayDouble(double[,] Array)
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

            // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

            void Zadacha47()
            {
                int rows = 3;
                int columns = 4;
                int digits = 1;
                double[,] numbers = new double[rows, columns];

                FillArrayDouble(numbers, 0, 10);
                PrintArrayDouble(numbers);
                Console.WriteLine("Можно сделать всё в один проход в одном методе (так будет быстрее), но 2-мя методами лучше видно, как происходит округление:");
                RoundDigits(numbers, digits);
                PrintArrayDouble(numbers);
            }

            // Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указание, что такого элемента нет.

            void Zadacha50()
            {
                int rows = 5;
                int columns = 10;
                int digits = 2;
                int indexI = 3;
                int indexJ = 7;
                double[,] numbers = new double[rows, columns];
                FillArrayDouble(numbers, 0, 10);
                RoundDigits(numbers, digits);
                PrintArrayDouble(numbers);
                Console.WriteLine();if (indexI < rows && indexJ < columns)
                {
                    Console.WriteLine($"Элемент с индексами [{indexI}, {indexJ}] = {Math.Round(numbers[indexI, indexJ], digits)}");
                }
                else
                {
                    Console.WriteLine($"Элемент с индексами [{indexI}, {indexJ}] не существует");
                }
            }

            //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            void Zadacha52()
            {
                int rows = 3;
                int columns = 5;
                int[,] numbers = new int[rows, columns];
                FillArrayInt(numbers, 0, 9);
                PrintArrayInt(numbers);
                double[] average = new double[columns];
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("____\t");
                }
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        average[j] = average[j] + numbers[i, j];
                    }
                    average[j] = average[j] / rows;
                    Console.Write($"{Math.Round(average[j], 2)}\t");
                }
            }

            Console.WriteLine("Задача 47");
            Zadacha47();
            Console.WriteLine();
            Console.WriteLine("Задача 50");
            Zadacha50();
            Console.WriteLine();
            Console.WriteLine("Задача 52");
            Zadacha52(); Console.WriteLine();
            Console.WriteLine();
        }
    }
}
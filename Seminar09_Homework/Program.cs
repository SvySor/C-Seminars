using System;

namespace Homework09 // Рекурсия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void MultiplesOfThree(int M, int N)
            {
                if (M > N) return;
                if (M % 3 == 0) Console.Write($"{M} ");
                M++;
                MultiplesOfThree(M, N);
            }

            int SumBetween(int M, int N)
            {
                if (M > N) return 0;
                return M + SumBetween(M + 1, N);
            }

            int FuncAckerman(int M, int N)
            {
                if (M == 0) return N + 1;
                if (N == 0) return FuncAckerman(M - 1, 1);
                return FuncAckerman(M - 1, FuncAckerman(M, N - 1));
            }



            //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            void Zadacha64()
            {
                int M = 13;
                int N = 20;
                MultiplesOfThree(M, N);
            }

            //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
            void Zadacha66()
            {
                int M = 1;
                int N = 15;
                Console.Write(SumBetween(M, N));
            }

            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            void Zadacha68()
            {
                int m = 3;
                int n = 2;
                Console.Write(FuncAckerman(m, n));
            }

            Console.WriteLine("Задача 64");
                        Zadacha64();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача 66");
            Zadacha66();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача 68");
            Zadacha68();
            Console.WriteLine();
            Console.WriteLine();            
        }
    }
}
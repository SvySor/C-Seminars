using System;

namespace Seminar02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha17()
            {
                // Напишите программу, которая принимает на вход координаты точки (X,Y), такие что X, Y <> 0, и возвращает квадрант расположения точки
                Random rand = new Random();
                int x = rand.Next(-10, 11);
                int y = rand.Next(-10, 11);
                Console.WriteLine($"A {x}, {y}");
                if (x == 0 | y == 0) Console.WriteLine($"Your point is on coordinate line");
                else if (x > 0 && y > 0) Console.WriteLine($"Your point is in quadrant 1");
                else if (x > 0 && y < 0) Console.WriteLine($"Your point is in quadrant 2");
                else if (x < 0 && y < 0) Console.WriteLine($"Your point is in quadrant 3");
                else if (x < 0 && y > 0) Console.WriteLine($"Your point is in quadrant 4");
            }

            void Zadacha18()
            {
                // Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек
                Console.Write("Enter number of quarter between 1 and 4: ");
                int QuarterNumber = Convert.ToInt32(Console.ReadLine());
                int x = 1;
                int y = 1;
                if (QuarterNumber < 1 | QuarterNumber > 4) Console.WriteLine($"You enter wrong number");
                else
                {
                    if (QuarterNumber == 4) y = -1;
                    else if (QuarterNumber == 3)
                    {
                        y = -1;
                        x = -1;
                    }
                    else if (QuarterNumber == 2) x = -1;
                    Console.WriteLine($"Signs of the ponts are: x = {x}, y = {y}");
                    Random rand = new Random();
                    int Ax = rand.Next(1, 100);
                    int Ay = rand.Next(1, 100);
                    Console.WriteLine($"For example point A({x * Ax}, {y * Ay})");
                }
            }

            void Zadacha21()
            {
                // Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 2D
                Console.WriteLine("Enter coordinates of point A: ");
                Console.Write("X: ");
                int Xa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y: ");
                int Ya = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinates of point B: ");
                Console.Write("X: ");
                int Xb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y: ");
                int Yb = Convert.ToInt32(Console.ReadLine());
                int LegX = Xa - Xb;
                int LegY = Ya - Yb;
                double Hypotenuse = Math.Sqrt((Math.Pow(LegX, 2) + Math.Pow(LegY, 2)));
                Console.Write("The distance between points A and B is {0:0.###}", Hypotenuse);
                Console.WriteLine();
            }

            void Zadacha22()
            {
                // Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов от 1 до N
                Console.Write("Enter number N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int count = 1;
                Console.WriteLine();
                while (count <= Math.Abs(N))
                {
                    double count_2 = Math.Pow(count, 2);
                    Console.WriteLine($"{Math.Abs(N)/N*count} ^ 2 = {count_2}");
                    count++;
                }
                Console.WriteLine();
                }

            Zadacha17();
            Zadacha18();
            Zadacha21();
            Zadacha22();
        }
    }
}
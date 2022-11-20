using System;

namespace Seminar02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha19()
            {
                // Напишите программу, которая принимает на вход 5-ти значное число и проверяет, является ли оно полиэндром
                Console.Write("Enter 5 digit number: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number < 10000 | Number > 99999) Console.WriteLine($"You enter wrong number");
                else
                {
                    int div10000 = Number / 10000;
                    int div1000 = (Number - div10000 * 10000) / 1000;
                    int div100 = (Number - div10000 * 10000 - div1000 * 1000) / 100;
                    int div10 = (Number - div10000 * 10000 - div1000 * 1000 - div100 * 100) / 10;
                    int div1 = Number % 10;
                    /*
                    Console.WriteLine(div10000);
                    Console.WriteLine(div1000);
                    Console.WriteLine(div100);
                    Console.WriteLine(div10);
                    Console.WriteLine(div1);
                    */
                    if (div10000 == div1 && div1000 == div10) Console.WriteLine("The number is palindrome.");
                    else Console.WriteLine("The number is not a palindrome.");
                }
            }

            void Zadacha21()
            // Найдите расстояние между двумя точками в пространстве 3D
            {
                Console.WriteLine("Enter coordinates of point A: ");
                Console.Write("X: ");
                int Xa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y: ");
                int Ya = Convert.ToInt32(Console.ReadLine());
                Console.Write("Z: ");
                int Za = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinates of point B: ");
                Console.Write("X: ");
                int Xb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Y: ");
                int Yb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Z: ");
                int Zb = Convert.ToInt32(Console.ReadLine());
                int LegX = Xa - Xb;
                int LegY = Ya - Yb;
                int LegZ = Za - Zb;
                double Distance3D = Math.Sqrt((Math.Pow(LegX, 2) + Math.Pow(LegY, 2) + Math.Pow(LegZ, 2)));
                Console.WriteLine("The distance between points A and B in 3D space is: {0:0.###}", Distance3D);
                Console.WriteLine();
            }

            void Zadacha23()
            // Таблица кубов чисел от 1 до N
            {
                Console.Write("Enter number N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the degree: ");
                int Deg = Convert.ToInt32(Console.ReadLine());
                int count = 1;
                Console.WriteLine();
                while (count <= Math.Abs(N))
                {
                    double count_3 = Math.Pow(Math.Abs(N) / N * count, Deg);
                    Console.WriteLine($"{Math.Abs(N) / N * count} ^ {Deg} = {count_3}");
                    count++;
                }
                Console.WriteLine();               
            }

                // Zadacha19();
                // Zadacha21();
                Zadacha23();

            }
        }
    }
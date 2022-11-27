using System;

namespace Homework04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

            int Exponentation(int A, int B)
            {
                int Exp = 1;
                int Sign = 1;
                if (B != 0) Sign = Math.Abs(B) / B;
                B = Math.Abs(B);
                for (int i = 1; i <= B; i++)
                {
                    Exp = Exp * A;
                }
                Exp = Exp * Sign;
                return Exp;
            }

            void Zadacha25()
            {

                Console.Write("Enter 1st number: ");
                int NumberA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2d number: ");
                int NumberB = Convert.ToInt32(Console.ReadLine());
                int Exp = Exponentation(NumberA, NumberB);
                Console.WriteLine("A ^ B = " + Exp);
            }

            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            void Zadacha27()
            {
                Console.Write("Enter number: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                Number = Math.Abs(Number);
                int Digit = 0;
                int Sum_Digit = 0;
                while (Number > 0)
                {
                    Digit = Number % 10;
                    Number = Number / 10;
                    Sum_Digit = Sum_Digit + Digit;
                    // Console.Write(Digit);
                    // Console.WriteLine("    " + Sum_Digit);
                }
                Console.WriteLine("Сумма цифр в числе = " + Sum_Digit);
            }


            // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

            void Zadacha29()
            {
                int[] array = new int[8];
                Random rnd = new Random();
                for (int i = 0; i < 8; i++)
                {
                    array[i] = rnd.Next(-1000, 1000);
                    Console.WriteLine(array[i]);
                }
                int max = array[0];
                for (int j = 7; j > 1; j--)
                {
                    for (int i = 1; i < j; i++)
                    {
                        if (Math.Abs(array[i]) > Math.Abs(array[i + 1]))
                        {
                            max = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = max;
                        }
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            Zadacha25();
            Zadacha27();
            Zadacha29();
        }
    }
}

/*


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

        // Zadacha21();
        // Zadacha23();
*/
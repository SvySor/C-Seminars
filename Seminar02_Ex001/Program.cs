void Zadacha9 ()
{
    // Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
    Random rand = new Random();
    int number = rand.Next(10,100);
    int div10 = number / 10;
    int div1 = number % 10;
    Console.WriteLine($"Random number between 10 and 99 is: {number}");
    if (div10 > div1) Console.WriteLine($"Maximum digit os this number is {div10}");
    if (div10 <= div1) Console.WriteLine($"Maximum digit os this number is {div1}");
}


void Zadacha11 ()
{
    // Напишите программу, которая выводит случайное трёхзначное число и удаляет число десятков
    Random rand = new Random();
    int number = rand.Next(100,1000);
    int div100 = number / 100;
    int div10 = (number - div100*100) / 10;
    int div1 = number % 10;
    Console.WriteLine($"Random number between 10 and 99 is: {number}");
    int NewNumber = div100 * 10 + div1; 
    if (div10 > div1) Console.WriteLine($"New special number is {NewNumber}");
}

void Zadacha12 ()
{
    // Напишите программу, которая проверяет делимость чисел
    Console.Write("Enter 1st number: ");
    int N1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter 2d number: ");
    int N2 = Convert.ToInt32(Console.ReadLine());
    int div = N1 % N2;
    if (div == 0) Console.WriteLine($"{N1} is multiples of {N2}");
    else Console.WriteLine($"{N1} is not multiples of {N2}. The division is {div}");
 }

void Zadacha14 ()
{
    // Напишите программу, которая проверяет делимость числа на 7 и 23
    Console.Write("Enter number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int div7 = N % 7;
    int div23 = N % 23;
    if (div7 == 0 && div23 == 0) Console.WriteLine($"{N} is multiples of 7 and 23");
    else Console.WriteLine($"{N} is not multiples of 7 and 23");
 }

 void Zadacha16 ()
{
    // Напишите программу, которая проверяет является ли второе квадратом первого
    Console.Write("Enter number 1: ");
    int N1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number 2: ");
    int N2 = Convert.ToInt32(Console.ReadLine());
    int quad1 = N1 * N1;
    int quad2 = N2 * N2;
    if (quad1 == N2) Console.WriteLine($"{N2} is the square of {N1}");
    else
    {
        if (quad2 == N1) Console.WriteLine($"{N1} is the square of {N2}");
        else Console.WriteLine($"{N2} isn't the square of {N1} and {N1} isn't the square of {N2}");
    }
 }

//Zadacha9();
//Zadacha11();
//Zadacha12();
//Zadacha14();
Zadacha16();

void Zadacha17 ()
{
    // Напишите программу, которая принимает на вход координаты точки (X,Y), такие что X, Y <> 0, и возвращает квадрант расположения точки
    Random rand = new Random();
    int x = rand.Next(-10,11);
    int y = rand.Next(-10,11);
    Console.WriteLine($"A {x}, {y}");
    if (x == 0 | y == 0) Console.WriteLine($"Your point is on coordinate line");
    else if (x > 0 && y > 0) Console.WriteLine($"Your point is in quadrant 1");
    else if (x > 0 && y < 0) Console.WriteLine($"Your point is in quadrant 2");
    else if (x < 0 && y < 0) Console.WriteLine($"Your point is in quadrant 3");
    else if (x < 0 && y > 0) Console.WriteLine($"Your point is in quadrant 4");
}

void Zadacha18 ()
{
    // Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек
    Random rand = new Random();
    int x = rand.Next(-10,11);
    int y = rand.Next(-10,11);
    Console.WriteLine($"A {x}, {y}");
    if (x == 0 | y == 0) Console.WriteLine($"Your point is on coordinate line");
    else if (x > 0 && y > 0) Console.WriteLine($"Your point is in quadrant 1");
    else if (x > 0 && y < 0) Console.WriteLine($"Your point is in quadrant 2");
    else if (x < 0 && y < 0) Console.WriteLine($"Your point is in quadrant 3");
    else if (x < 0 && y > 0) Console.WriteLine($"Your point is in quadrant 4");
}


//Zadacha17();
Zadacha18();
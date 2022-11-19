void Zadacha10 ()
{
    // Напишите программу, которая выводит случайное трёхзначное число и на выходе показывает цифру десятков
    Console.Write("Enter a three-digit number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int div100 = number / 100;
    int div10 = (number - div100*100) / 10;
    Console.WriteLine($"The second digit of the number is {div10}");
}

void Zadacha13 ()
{
    // Напишите программу, которая выводит третью цифру заданного числа или сообщает о её отсутствии
    Console.Write("Enter any number: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    int NumberSmall = Number;
    int count = 0;
    while (NumberSmall > 10)
    {
        NumberSmall = NumberSmall / 10;
        count++;
//        Console.WriteLine(count);
    }
    count = count + 1;
//    Console.WriteLine(count);
    if (count < 3) Console.WriteLine($"There are no 3d digit in this number");
    else
    {
        int Divider = Convert.ToInt32(Math.Pow(10,count-3));
//        Console.WriteLine(Divider);
        int NumberFirst_3_Dig = Number / Divider;
//        Console.WriteLine(NumberFirst_3_Dig);
        int Dig3 = NumberFirst_3_Dig % 10;
        Console.WriteLine($"The 3d digit of the number is {Dig3}");
    }

}

void Zadacha15 ()
{
    // Напишите программу, которая проверяет день недели и определяет выходной
    Console.Write("Enter a number between 1 and 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <= 7)
    {
    Console.WriteLine($"The {number} day of the week is {WeekDay(number)}");
    if (number > 5) Console.WriteLine($"The {WeekDay(number)} is day off");
    if (number <= 5) Console.WriteLine($"The {WeekDay(number)} is working day");
    }
    else Console.WriteLine($"{number} is not a number of the Week day");
}

string WeekDay(int Day_Of_Week)
{
// Метод определения дня недели
string Day = "Monday";
if (Day_Of_Week == 1) Day = "Monday";
else if (Day_Of_Week == 2) Day = "Tuesday";
else if (Day_Of_Week == 3) Day = "Wenesday";
else if (Day_Of_Week == 4) Day = "Thursday";
else if (Day_Of_Week == 5) Day = "Friday";
else if (Day_Of_Week == 6) Day = "Saturday";
else if (Day_Of_Week == 7) Day = "Sunday";
else Day = "Something is wrong";
return Day;
}

//Zadacha10();
//Zadacha13();
Zadacha15();
// Enter data

Console.Write("Number of the weekday: ");
int WeekDayNumber = Convert.ToInt32(Console.ReadLine());

// Calculation
if (WeekDayNumber < 7 && WeekDayNumber >1)
{
    if (WeekDayNumber == 1) Console.WriteLine($"Day number {WeekDayNumber} is Monday");
    else if (WeekDayNumber == 2) Console.WriteLine($"Day number {WeekDayNumber} is Tuesday");
    else if (WeekDayNumber == 3) Console.WriteLine($"Day number {WeekDayNumber} is Wensday");
    else if (WeekDayNumber == 4) Console.WriteLine($"Day number {WeekDayNumber} is Thursday");
    else if (WeekDayNumber == 5) Console.WriteLine($"Day number {WeekDayNumber} is Friday");
    else if (WeekDayNumber == 6) Console.WriteLine($"Day number {WeekDayNumber} is Saturday");
    else if (WeekDayNumber == 7) Console.WriteLine($"Day number {WeekDayNumber} is Sunday");
}
else Console.WriteLine($"You are wrong. Week Day Number is the number between 1 and 7. Enter correct number");
Console.WriteLine();
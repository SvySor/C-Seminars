// Enter data
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
// Calculation
if (a == b)
{
    Console.Write($"Both numbers are equal {a} == {b}");
}
else
{
    if (a > b)
    {
    Console.Write($"First number {a} is bigger than the second number {b}");
    }
    else
    {
    Console.Write($"First number {a} is less than the second number {b}");
    }
}
Console.WriteLine();

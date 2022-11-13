// Enter data
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
// Calculation
int res = a * a;
if (b == res)
{
    Console.Write($"You are right. Square of the number {a} is {b}");
}
else
{
    Console.Write($"You are wrong. {b} is not the square of the number {a}. Correct answer is ");
    Console.WriteLine(res);
}

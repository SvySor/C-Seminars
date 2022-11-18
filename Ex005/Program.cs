// Enter data
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

// Calculation
int result = PrintQuad(a);
Console.Write($"Square of your number is {result}");

int PrintQuad (int number)
{
return number * number;
}

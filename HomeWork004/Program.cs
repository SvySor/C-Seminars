// Enter data
Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

// Calculation
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write($"Max is {max}");
Console.WriteLine();

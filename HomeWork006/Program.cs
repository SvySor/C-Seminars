// Enter data
Console.Write("Enter any number: ");
int a = Convert.ToInt32(Console.ReadLine());
int div = 2;

// Calculation
int remainder = a%div;
if (remainder == 0) Console.Write("Your number is an even number");
else Console.Write("Your number is an odd number");
Console.WriteLine();

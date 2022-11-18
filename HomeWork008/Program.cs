// Enter data

Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

// Calculation
int remainder = 0;
int count = 1;
int div = 2;
while (count <= N)
{
    remainder = count%div;
    if (remainder == 0) Console.Write($"{count} ");
    count++;
 }
Console.WriteLine();
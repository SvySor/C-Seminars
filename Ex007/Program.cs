// Enter data

Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

// Calculation
int count = -N;
while (count <= N)
{
    Console.Write($" {count},");
    count++;
 }
Console.WriteLine("\b \b");
Console.WriteLine();
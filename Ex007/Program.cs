// Enter data

Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

// Calculation
int count = -N;
Console.Write(count);
while (count <= N)
{
    Console.Write($", {count}");
    count++;
 }
Console.WriteLine();
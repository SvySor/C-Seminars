// Enter data

Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

// Calculation
int result = 0; //result of div
int count = 1; //counter
int div = 2; // divider
while (count <= N/div)
{
    result = count/div;
    Console.Write($"{count*div} ");
    count++;
 }
Console.WriteLine();
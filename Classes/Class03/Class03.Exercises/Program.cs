


#region Exercise 1

Console.WriteLine("Enter a number Exercise 1");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();


for (int i = n; i >= 1; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine();


for (int i = 2; i <= n; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();


for (int i = 1; i <= n; i += 2)
{
    Console.Write(i + " ");
}

#endregion

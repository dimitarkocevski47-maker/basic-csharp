using Class07.Enums.Enums;
using Class07.MtahLibrary;

Console.WriteLine(DaysOfWeek.Monday);
Console.WriteLine(Convert.ToInt32(DaysOfWeek.Monday));

Console.WriteLine("Please eneter day of week: ");
string input = Console.ReadLine();

// Bad way! Error prone!
//if(input == "Satrday" || input == "Sunday")
//{
//    Console.WriteLine("Yeey! It is a weekend!");
//}

// Better way!
if (input == DaysOfWeek.Saturday.ToString() || input == DaysOfWeek.Sunday.ToString()) 
{
    Console.WriteLine("Yeey! It is a weekend!");
}

MathOperations.Sum(10, 20);
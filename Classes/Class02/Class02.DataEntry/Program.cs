
#region Data entries


using System.Diagnostics;

Console.WriteLine("Please enter something: ");
string userInput =  Console.ReadLine();
Console.WriteLine("[USER INPUT] " + userInput);

Console.WriteLine("Please insert number 1:");
// int number1 = int.Parse(Console.ReadLine());
// int number1 = Convert.ToInt32(Console.ReadLine());
bool isParsedNum1 = int.TryParse(Console.ReadLine(), out int number1);

Console.WriteLine("Please insert number 2:");
// int number2 = int.Parse(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
bool isParsedNum2 = int.TryParse(Console.ReadLine(), out int number2);

#endregion

#region Branching if/else switch

if (!isParsedNum1 || !isParsedNum2)
{
    Console.WriteLine("You try to sum values that are not numbers");
}
else
{
    Console.WriteLine(number1 + number2);
}


Console.WriteLine("Enter a day of the week, and i will know if you have classes");
string dayOfTheWeek = Console.ReadLine();

switch (dayOfTheWeek.ToLower())
{
    case "monday":
        Console.WriteLine("You have classes on this day!");
        break;
    case "tuesday":
        Console.WriteLine("You don't have classes on this day");
        break;
    case "wednesday":
        Console.WriteLine("You have classes on this day!");
        break;
    case "thrusday":
    case "friday":
    case "sturday":
    case "sunday":
        Console.WriteLine("You don't have classes on this day");
        break;
    default:
        Console.WriteLine("No such day of the week! Try again");
        break;
}


#endregion
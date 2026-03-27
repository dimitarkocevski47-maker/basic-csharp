
static double GetUserInput()
{
    Console.WriteLine("Enter a number:");
    double userInput = double.Parse(Console.ReadLine());
    return userInput;
}

static void PosOrNeg(double num)
{
    Console.WriteLine($"Stats for number: {num}");
    if (num > 0)
        Console.WriteLine("Positive");
    else if (num < 0)
        Console.WriteLine("Negative");
    else
        Console.WriteLine("Zero");
}

static void OddOrEven(double num)
{
    bool isInteger = num % 1 == 0;

    if (isInteger)
        Console.WriteLine("Integer");
    else
        Console.WriteLine("Decimal");

    if (isInteger)
    {
        if ((double)num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
    else
    {
        Console.WriteLine("Neither odd or even");
    }
}


bool UserInterface()
{
    Console.WriteLine("Enter a number:");
    bool isNumber = double.TryParse(Console.ReadLine(), out double userInput);
    if (!isNumber)
    {
        Console.WriteLine("That was not a number! Please try again!");
        return false;
    }
    PosOrNeg(userInput);
    OddOrEven(userInput);
    Console.WriteLine("Press any key to try again or X to exit!");
    if (Console.ReadLine().ToUpper() == "X")
        return true;
    return false;
}

while (!UserInterface()) ;
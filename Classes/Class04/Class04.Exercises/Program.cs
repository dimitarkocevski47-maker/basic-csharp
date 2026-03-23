#region Exercise 1

using System.ComponentModel.Design;

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    return a / b;
}

Console.WriteLine("Enter a operation: * or /");
string operation = Console.ReadLine();

Console.WriteLine("Enter a first number: ");
bool isParsedNum1 = double.TryParse(Console.ReadLine(), out double num1);

Console.WriteLine("Enter a second number: ");
bool isParsedNum2 = double.TryParse(Console.ReadLine(), out double num2);

if (!isParsedNum1 || !isParsedNum2)
{
    Console.WriteLine("Please enter only number values!");
}
else
{
    if (operation == "*")
    {
        double result = Multiply(num1, num2);
        Console.WriteLine("The result is: " + result);
    }
    else if(operation == "/") {
        if(num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero, please try again!");
        }
        else
        {
            double result = Divide(num1, num2);
            Console.WriteLine("The result is: " + result);
        }
    }
    else
    {
        Console.WriteLine("Please insert valid operation!");
    }
}





#endregion
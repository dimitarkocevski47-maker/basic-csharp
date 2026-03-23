#region Methods declaration and usage

// Method that print in console
// Dosen't return value or it returns void
// Dosen't accept input parametars
static void SaySomething()
{
    Console.WriteLine("Hello there i am learning C# Methods!");
    Console.ReadLine();
}

SaySomething();


// Method that print in console
// Dosen't return value or it returns void
// Accept input parametars of type string
static void SayHelloToSomeone(string person)
{
    Console.WriteLine("Hello there " + person + " I have something to teel you");
   
    Console.ReadLine();
}
SayHelloToSomeone("Dimitar");

static void SendEmail(bool isSenderValid, string message)
{
    if (isSenderValid)
    {
        Console.WriteLine("The message was sent! Message: " + message);
    }
    else
    {
        Console.WriteLine("The message was not sent! Message: " + message);
    }
    Console.ReadLine();
}
SendEmail(true, "Hi Martin here is my C# homework");
SendEmail(false, "Hi Martin here is my JS homework");


// Method that returns a value
// Returns value of 'int'
//Accept input parameters a and b also of type 'int'
static int Sum(int a, int b)
{
    return a + b;
}
Console.WriteLine(Sum(10, 22));
Console.WriteLine(Sum(100, 222334));

static int Subtract(int a, int b)
{
    return a - b;
}
Console.WriteLine(Subtract(100, 40)); 
Console.WriteLine(Subtract(2, 10)); 

static void PrintSomething()
{
    Console.WriteLine("Hello here");
}


#endregion
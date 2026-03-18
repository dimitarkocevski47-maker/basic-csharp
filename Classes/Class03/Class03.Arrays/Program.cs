
#region Arrays

// Declaration of an array 

int[] emptyNumbersArray = new int[3];

// Intialization of array elements
emptyNumbersArray[0] = 1;
emptyNumbersArray[1] = 10;
emptyNumbersArray[2] = 20;

// Cannot add new element on existing index
//emptyNumbersArray[3] = 50;

for (int i = 0; i < emptyNumbersArray.Length; i++)
{
    Console.WriteLine(emptyNumbersArray[i]);
}

string[] names = new string[]
{
    "Martin",
    "Mario",
    "Dimitar",
    "Ognen",
    "Damjan"
};

double[] decimalNumbers= [10.5, 20.4, 100.12];

foreach (var name in names)
{
    Console.WriteLine(name);
}

foreach (var number in decimalNumbers)
{
    Console.WriteLine(number);
}
#endregion

#region Array Methods

int[] evenNumbers = new int[] { 2, 4, 6, 8, 10, 2, 4 };

// Reverse the array element
Array.Reverse(evenNumbers);

Console.WriteLine("Array of even numbers after Reverse()");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

int indexFound = Array.IndexOf(evenNumbers, 2);
Console.WriteLine("The index of number 6 is " + indexFound);


#endregion

#region Array Resize method using example use case

string[] usernames = new string[0];

do
{
    Console.Clear();
    Console.WriteLine("Please enter a username:");
    string userInput = Console.ReadLine();

    Array.Resize(ref usernames, usernames.Length + 1);
    usernames[usernames.Length - 1] = userInput;

    Console.WriteLine("Do you want to insert new username? Y/N");
    userInput = Console.ReadLine();

    if (userInput == "n" || userInput == "N")
        break;
}
while (true);

foreach (var username in usernames)
{
    Console.WriteLine(username);
}




#endregion
using Class09.Exceptions.Models;

#region Exceptions
// Handling .net exception

Console.WriteLine("----------- Example 1 -----------");
try
{
	Console.WriteLine("Enter a number: ");
	int number = Int32.Parse(Console.ReadLine());
	Console.WriteLine($"The number you entered is: {number}");
}
catch (Exception ex)
{
    Console.WriteLine("Oooops, something went wrong! Please try again later");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine($"Info for developer: {ex.Message}");
    Console.WriteLine($"{ex.StackTrace}");
}
finally
{
    Console.WriteLine("----------- Press any key to continue -----------");
    Console.ReadLine();
}

// Custom Exception (Exception with our own logic

Console.WriteLine("----------- Example 2 -----------");
Console.WriteLine("Handling exception with custom message");
try
{
    Console.WriteLine("Enter letter a or letter b: ");
    string letter = Console.ReadLine().Trim().ToLower();
    if (letter == "a" || letter == "b")
    {
        Console.WriteLine("Congratulations, you have entered a or b!");
    }
    else
    {
        throw new Exception("That is not a or b! Sorry!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("More info: " + ex.InnerException);
}
finally
{
    Console.WriteLine("----------- Press any key to continue -----------");
    Console.ReadLine();
}



#endregion

#region Handling specific exceptions

Console.WriteLine("----------- Example 3 -----------");
try
{
    Console.WriteLine("Enter some charachter:");
    char char1 = char.Parse(Console.ReadLine());
    Console.WriteLine($"The charchter you enterd is {char1}");

    Console.WriteLine("Please eneter a number:");
    int number1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"The number you entered is: {number1}");

    Person p = new Person() { Name = "Dimitar" };
    foreach (var skill in p.Skills)
    {
        Console.WriteLine(skill);
    }
}
catch (FormatException frmEx)
{
    Console.WriteLine("You have entered something other than a charachter!");
}
catch (OverflowException ovEx)
{
    Console.WriteLine("You have entered either too large or too small number.");
}
catch (Exception ex)
{
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("----------- Press any key to continue -----------");
    Console.ReadLine();
}

#endregion

#region Handling exceptions within method

static void PersonSkill (Person person)
{
    foreach (var skill in person.Skills)
    {
        Console.WriteLine(skill);
    }
}

static void PersonSkill2(Person person)
{
    try
    {
        foreach (var skill in person.Skills)
        {
            Console.WriteLine(skill);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch inside the function: {ex.Message}");
    }
}

try
{
    PersonSkill(new Person() { Name = "Jhon Doe" });
    PersonSkill2(new Person() { Name = "Martin" });

}
catch (NullReferenceException ex) 
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("----------- Press any key to continue -----------");
    Console.ReadLine();
}



#endregion
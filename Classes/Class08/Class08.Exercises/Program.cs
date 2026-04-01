#region Exercise - PhoneBook

Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    { "Martin", "070-987-654" },
    { "Dimitar", "076-543-210" },
    { "Bob", "077-865-213" },
    { "Jill", "078-999-888" },
    { "Jhon", "070-222-333" }
};

Console.WriteLine("Please eneter a name");
string name = Console.ReadLine();

var userSearch = phoneBook.TryGetValue(name, out string phoneValue);
if (userSearch)
{
    Console.WriteLine($"{name} your phone number {phoneValue}");
}
else
{
    Console.WriteLine("No such name found");
}
#endregion
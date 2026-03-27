using Class06.Exercise2.Models;

User[] users = new User[]
{
    new User(1, "Dimitar", "Dimi1608", new string[] {"Kaj Ucis", "Avenga"}),
    new User(2, "Mario", "Maki1012", new string[] {"Kaj rabotese", "RL Datix"}),
    new User(3, "Ognen", "Ogi1514", new string[] {"Sto rabotis", "Front-End Developer"})
};

bool UserUI()
{
    Console.WriteLine("1) Login \n2) Register new \n3) Exit");
    bool IsChoiceValid = int.TryParse(Console.ReadLine(), out int choice);
    if (!IsChoiceValid || choice > 3)
    {
        Console.WriteLine("Please eneter valid number from 1-3");
        return false;
    }
    switch(choice)
    {
        case 1:
            //Call method to handle Login flow
            Login();
            return false;
            break;
        case 2:
            //Call method to handle register flow
            Register();
            return false;
            break;
        case 3:
            return true;
            break;
        default:
            break;
    }
    return false;
}

void Login()
{
    Console.Write("Username: ");
    string userName = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();
    User user = FindUser(userName, password);
    if(user != null)
    {
        Console.WriteLine("-----------");
        Console.WriteLine($"Welcome {user.Username}");
        Console.WriteLine("-----------");
        Console.WriteLine("Your messages: ");
        foreach (string msg in user.Messages)
        {
            Console.WriteLine(msg); 
        }
        Console.WriteLine("-------------");
    }
}

void Register()
{
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password");
    string password = Console.ReadLine();
    User user = FindUser(username, password);

    if(user != null)
    {
        Console.WriteLine("User alredy registered!");
        return;
    }
    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = new User(users.Length + 1, username, password, new string[0]);
    Console.WriteLine("Successfully registered!");
    Console.WriteLine("-----------");
    Console.WriteLine("Users registered so far:");
    Console.WriteLine("-----------");
    foreach (User existingUser in users) 
    {
        Console.WriteLine($"{existingUser.Id} {existingUser.Username}");
    }
    Console.WriteLine("-----------");
}

User FindUser(string username, string password)
{
    foreach (User user in users)
    {
        if (user.Username.ToLower() == username.ToLower() && user.Password == password)
            return user;
    }
    return null;
}

while (!UserUI()) ;
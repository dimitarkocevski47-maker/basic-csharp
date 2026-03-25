using Class05.Exercises.Models;
#region Exercise 1

Console.WriteLine("Please enter your name:");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age = int.Parse(Console.ReadLine());

Human person = new Human(firstName, lastName, age);

person.GetPersonStats();




#endregion
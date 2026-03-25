using Class05.Classes.Models;

#region Classes definiton and creating instance objects

//Create a Person object using the parametereless constructor and set properties manually
Person dimitar = new Person();
dimitar.FirstName = "Dimitar";
dimitar.LastName = "Kocevski";
dimitar.Age = 19;
dimitar.Hobbies = ["Reading books", "Running"];
dimitar.IsStudent = true;

Console.WriteLine($"{dimitar.FirstName} {dimitar.LastName} - {dimitar.GetSSNValue()}");
Console.ReadLine();

// Create a Person object using the objcet initializer syntax
Person bob = new Person()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 25,
    PhoneNum = "070/222-333",
    Hobbies = ["Running", "Listening to music"],
    IsStudent = false
};

Console.WriteLine($"{bob.FirstName} {bob.LastName} - {bob.GetSSNValue()} is {bob.Age} years old. ");
Console.ReadLine();

Person gill = new Person("Gill", "Wayne", "070/123-456", 28, [], true);

Console.WriteLine($"{gill.FirstName} {gill.LastName} - {gill.GetSSNValue()} is {gill.Age} years old");
Console.ReadLine();

gill.Talk("Hello there nice to meet you!");


#endregion



#region Working with clasess

Group g1 = new Group("G1", 12, "Basic C#");
Group g2 = new Group("G2", 18, "Web developments using NodeJS");

Student mario = new Student("Mario Simonovski", 34, g1);
Student martin = new Student("Martin Panovski", 19, g1);

Student tomi = new Student("Tomi Tomski", 36, g2);
Student ivo = new Student("Ivo Kostovski", 36, new Group("G3", 10, "HTML/CSS"));
Student cvetko = new Student("Cvetko Cvetkovski", 35, new Group()
{
    GroupName = "G3",
    CurrentSubjectName = "HTML/CSS",
    NumberOfStudents = 10
});

mario.DisplayStudentInfo();
martin.DisplayStudentInfo();
tomi.DisplayStudentInfo();
ivo.DisplayStudentInfo();
cvetko.DisplayStudentInfo();

Student filip = new Student("Filip Mihajlovski", 27, null);
filip.DisplayStudentInfo();


#endregion
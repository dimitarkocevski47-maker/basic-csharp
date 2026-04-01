using Class08.LINQ.Models;

var students = new List<Student>
            {
                new Student(1, "Alice", "Smith", 20, "G1", Academy.WebDev, new List<string>{"BasicCSharp","AdvancedCSharp"}),
                new Student(2, "Bob", "Johnson", 22, "G2", Academy.WebDev, new List<string>{"BasicJS","JS"}),
                new Student(3, "Carol", "Williams", 19, "G3", Academy.FrontEnd, new List<string>{"HTML/CSS","JS"}),
                new Student(4, "David", "Brown", 23, "G4", Academy.FrontEnd, new List<string>{"Figma","HTML/CSS"}),
                new Student(5, "Eve", "Jones", 21, "G1", Academy.Design, new List<string>{"Figma","Photoshop"}),
                new Student(6, "Frank", "Garcia", 24, "G2", Academy.Design, new List<string>{"Basic HTML/CSS","Figma"}),
                new Student(7, "Grace", "Miller", 20, "G3", Academy.WebDev, new List<string>{"BasicCSharp","BasicJS"}),
                new Student(8, "Hank", "Davis", 22, "G4", Academy.FrontEnd, new List<string>{"JS","HTML/CSS"}),
                new Student(9, "Ivy", "Martinez", 18, "G2", Academy.WebDev, new List<string>{"AdvancedCSharp","JS"}),
                new Student(10, "Jack", "Lopez", 25, "G1", Academy.Design, new List<string>{"Photoshop","Basic HTML/CSS"})
            };

// First();
Student eve = students.Where(X => X.FirstName == "Eve").First();
Console.WriteLine($"{eve.FirstName} {eve.LastName} - {eve.Academy.ToString()}");

// Where()
var allWebDevStudentsFromG1 = students.Where(X => X.Academy == Academy.WebDev && X.Group == "G1").ToList();
foreach (var std in allWebDevStudentsFromG1)
{
    Console.WriteLine($"{std.FirstName} {std.LastName} - Academy: {std.Academy.ToString()} Group: {std.Group}");
}

// Last()
var lastStudent = students.Last();
Console.WriteLine($"{lastStudent.FirstName} {lastStudent.LastName}");


// Select()
var ivySubjects = students.Where(x => x.FirstName == "Ivy").Select(x => x.Subjects).First();

foreach (var sub in ivySubjects)
{
    Console.WriteLine(sub);
}

var customSelection = students.Where(x => x.FirstName == "Hank").Select(x => new
{
    FullName = $"{x.FirstName} {x.LastName}",
    x.Subjects
}).First();

Console.WriteLine(customSelection.FullName);

foreach (var sub in customSelection.Subjects)
{
    Console.WriteLine(sub);
}
namespace Class05.Classes.Models
{
    // Default constructor and it is parameterless
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }
        public int Age { get; set; }
        public string[] Hobbies { get; set; }
        public bool IsStudent { get; set; }
        private long SSN { get; set; }

        public Person()
        {
            SSN = GenerateSSN();
        }

        //Constructor with parameters
        public Person(string fName, string lName, string phoneNumber, int age, string[] hobbies, bool isStudent) 
        {
            FirstName = fName;
            LastName = lName;
            PhoneNum = phoneNumber;
            Age = age;
            Hobbies = hobbies;
            IsStudent = isStudent;
            SSN = GenerateSSN();
        }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999); // gets a random between the values
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The human named {FirstName} (SSN:{SSN}) is saying {text}");
        }

        public long GetSSNValue()
        {
            return SSN;
        }
    }
}

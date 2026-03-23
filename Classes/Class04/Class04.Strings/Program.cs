#region String concatenation and escaping

string fName = "Dimitar";
string lName = "Kocevski";

// String Concatenation
string hello1 = "Hello " + fName;

string hello2 = string.Format("Hello there {0} {1}", fName, lName);
Console.WriteLine(hello2);

// String interpolation
string hello3 = $"Hello there again {fName} {lName}";
Console.WriteLine(hello3);

// Escaping charachters in a string using backslash \
string message = "Check your c:\\drive";
Console.WriteLine(message);

string fairElectionsMessage = "We will have a \"fair\" elections";
Console.WriteLine(fairElectionsMessage);

string newLineMessage = "The \\n sign means new line in c#";
Console.WriteLine(newLineMessage);

string folderPath = "C:\\Users\\Dimitar\\AvengaAcademy\\C#Basic";
Console.WriteLine(folderPath);

string folderPathNew = @"C:\Users\Dimitar\AvengaAcademy\C#Basic";
Console.WriteLine(folderPathNew);

string avengaFolderName = "Avenga Projects";
string userName = "dimitarkocevski";

string pathToFolder = $@"C:\Users\{userName}\{avengaFolderName}";
Console.WriteLine(pathToFolder);



#endregion

#region String Formating

string myPrecentageString = string.Format("This is {0:P}", 0.5);
Console.WriteLine(myPrecentageString);

string myCurrencyValue = string.Format("It will cost me {0:C}", 125.45);
Console.WriteLine(myCurrencyValue);

string myStringNum = string.Format("{0:N}", 190);
Console.WriteLine(myStringNum);

string cardNum = string.Format("{0:####-####-####-####}", 1234554477882233);
Console.WriteLine(cardNum);

string phoneNum = string.Format("{0:0##/###-###}", 071974305);
Console.WriteLine(phoneNum);

string myCustomAllinedString1 = string.Format("| {0,5} | {1,18} |", "Id", "Order");

string myCustomAllinedString2 = string.Format("| {0,5} | {1,5} |", 25, "Samsung Galaxy S25");

Console.WriteLine(myCustomAllinedString1);
Console.WriteLine(myCustomAllinedString2);
#endregion

#region String Methods

string msg = "     We are learning C# and it is FUN and EASY. Okay maybe just FUN.   ";
Console.WriteLine(msg);

Console.WriteLine(msg.Trim());

string lower = msg.ToLower();
string upper = msg.ToUpper();

Console.WriteLine(lower);
Console.WriteLine(upper);

string[] splittedString = msg.Split('.');
Console.WriteLine(splittedString[0]);
Console.WriteLine(splittedString[1]);
Console.WriteLine(splittedString[2]);

bool doesStringStartsWith = msg.Trim().StartsWith("W");
Console.WriteLine(doesStringStartsWith);

int indexOfString = msg.IndexOf("FUN");
Console.WriteLine(indexOfString);

int nonExistingString = msg.IndexOf("not");
Console.WriteLine(nonExistingString);

string substring = msg.Substring(0, 15);
Console.WriteLine(substring);

char[] toChars = msg.ToCharArray();
Console.WriteLine(toChars.Length);

Console.WriteLine(string.Join("-", toChars));



#endregion
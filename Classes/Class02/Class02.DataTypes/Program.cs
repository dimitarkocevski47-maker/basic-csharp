#region DataTypes


// Declaration and initialazation of variables
//usin different data types 
short number = 154;
int otherNumber = 10500;

long bigNumber = 6324846249;

double decimalNumber1 = 10.44;
float decimalNumber2 = 155.45F;
decimal decimalNumber3 = 15545.32345M;

string fullName = "Dimitar Kocevski";
char character = 'D';
bool isRaining = false;

Console.WriteLine(number);
Console.WriteLine(otherNumber);
Console.WriteLine(bigNumber);
Console.WriteLine(decimalNumber1);
Console.WriteLine(decimalNumber2);
Console.WriteLine(decimalNumber3);
Console.WriteLine(fullName);
Console.WriteLine(character);
Console.WriteLine(isRaining);


#endregion


#region Implicit data types

var academyName = "Avenga Academy";

//this will not work. The application won't run until is fixed
//academyName = 10;

var numberOfstudents = 20;
// numberOfstudents = 20.10; // Will not work

var isSunny = true;
isSunny = false;

#endregion



#region Check data type

Console.WriteLine(isRaining.GetType());


#endregion

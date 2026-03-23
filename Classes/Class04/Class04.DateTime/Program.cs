#region Working with Dates

// Creating an empty DateTime
DateTime date = new DateTime();
Console.WriteLine(date);

//Creating a custom date YEAR MONTH DAY

DateTime customDate = new DateTime(2006, 08, 16, 11, 20, 35);
Console.WriteLine(customDate);

// Converting from string to DateTime
// Variations

string stringDateFirst = "15.12.2012";
string stringDateSecond = "15/12/2015";
string stringDateThird = "15/12/15";
string stringDateFourth = "dec.15.15";
string stringDateFifth = "15-12-15";

DateTime stringDate = DateTime.Parse(stringDateFourth);
Console.WriteLine(stringDate);

DateTime today = DateTime.Now;
Console.WriteLine(today);

Console.WriteLine(today.AddDays(2));
Console.WriteLine(today.AddDays(-2));

Console.WriteLine(today.Day);
Console.WriteLine(today.Date);
Console.WriteLine(today.DayOfWeek);

string dateFormat1 = today.ToString("MM/dd/yyyy");
string dateFormat2 = today.ToString("dddd, dd MMMM yyyy");
Console.WriteLine(dateFormat1);
Console.WriteLine(dateFormat2);

string dateFormat3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", today);
Console.WriteLine(dateFormat3);


#endregion
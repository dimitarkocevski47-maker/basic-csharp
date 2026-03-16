double a = 10;
double b = 202;

var sum = a + b;
var diff = a - b;
var multiply = a * b;
var division = a / b;

var complexExpression = ((sum) / (diff)) * multiply;

Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(division);
Console.WriteLine(complexExpression);

var reminder = a % 2;
Console.WriteLine(reminder);

Console.WriteLine(++b);
Console.WriteLine(b++);
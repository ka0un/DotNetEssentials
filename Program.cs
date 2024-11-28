// Reference Type
//class Person
//{
//    public string name;
//}

////.NET Value Type (Premitives and Strucs) and refernce Type (Classes and Objects)

//// Value Type
//struct Point
//{
//    public int x;
//    public int y;
//}

//Point p1 = new Point();

//p1.x = 7;
//p1.y = 9;

//Point p2 = p1;
//p2.x = 10;
//p2.y = 11;

//Console.WriteLine($"p1.x = {p1.x}, p1.y = {p1.y}");
//Console.WriteLine($"p2.x = {p2.x}, p2.y = {p2.y}");

//// Reference Type
//Person p = new Person();
//p.name = "John";

//Person p2 = p;
//p2.name = "Jane";

//Console.WriteLine(p.name);
//Console.WriteLine(p2.name);

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//// Theres no main method in C# 9.0

//// C# BASICS

//// Variables
//int age = 30; // This is an Integer Variable
//double price = 19.95; // This is a Double Variable
//char initial = 'A'; // This is a Character Variable
//bool isWorking = true; // This is a Boolean Variable
//string name = "John"; // This is a String Variable

//// Constants
//const double PI = 3.14159; // This is a Constant Variable

//// Arrays
//int[] numbers = { 1, 2, 3, 4, 5 }; // This is an Array Variable

////Array List
//List<int> numbers1 = new List<int>(); // This is an Array List Variable

////loops
//for (int ik = 0; ik < 5; ik++)
//{
//    Console.WriteLine(ik);
//}

//// While Loop
//int i = 0;

//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//// Do While Loop

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 5);

//// advanced for loop
//int[] numbers3 = { 1, 2, 3, 4, 5 };

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//// If Statement

//int x = 20;

//if (x > 10)
//{
//    Console.WriteLine("x is greater than 10");
//}
//else
//{
//    Console.WriteLine("x is less than 10");
//}

//string responce; // THis Is a String Variables

//// Console inputs and outputs
//Console.WriteLine("What is your name?");
//responce = Console.ReadLine();
//Console.WriteLine($"Hello, {responce}");

//// OS

//OperatingSystem thisOs = Environment.OSVersion;
//Console.WriteLine(thisOs);

// Strings


// String Interpolation

int age = 30;

Console.WriteLine($"I am {age} years old");

// by adding the $ sign before the string, we can add variables inside the string by adding the variable name inside the curly braces

// old way to do it

Console.WriteLine("I am {0} years old", age);

// String Formatting

double price = 19.95;
int quantity = 2;

Console.WriteLine("{0, -15} {1, -15}", "Price", "Quantity");
Console.WriteLine($"{price, -15} {quantity, -15}");
// {variable, alignment}

// String Manupulation

string stringtwo = "Hello, World!";

Console.WriteLine(stringtwo.ToUpper());
Console.WriteLine(stringtwo.ToLower());
Console.WriteLine(stringtwo.Length);
Console.WriteLine(stringtwo.Substring(7));
Console.WriteLine(stringtwo.Substring(7, 5));
Console.WriteLine(stringtwo.IndexOf("World"));
Console.WriteLine(stringtwo.IndexOf("world"));
Console.WriteLine(stringtwo.Contains("World"));
Console.WriteLine(stringtwo.StartsWith("Hello"));
Console.WriteLine(stringtwo.EndsWith("World"));
Console.WriteLine(stringtwo.Replace("World", "Universe"));
Console.WriteLine(stringtwo.Remove(7));
Console.WriteLine(stringtwo.Insert(7, "Universe"));


// Concatenation and Joining

string string1 = "Hello";
string string2 = "World";

string string3 = String.Concat(string1, string2);
string string4 = string1 + string2;

Console.WriteLine(string3);

string[] names = { "John", "Jane", "Jack" };

string joined = String.Join(", ", names);

Console.WriteLine(joined);

// Prasing

string number = "1234";

int num = int.Parse(number);

Console.WriteLine(num);

// Exception Handling

try
{
    int num1 = int.Parse("1234");
    int num2 = int.Parse("ABCD");
}
catch (FormatException e)
{
    Console.WriteLine("Format Exception");
}
catch (Exception e)
{
    Console.WriteLine("Exception");
}


// Formatting Numerical Data

// $"{variable, [alignment]:[format specifier][precision]}"

// alignment is a positive or negative number that represents the width of the output

// format specifier is a character that represents the format of the output
// C - Currency
// D - Decimal
// E - Scientific
// F - Fixed Point
// G - General
// N - Number
// P - Percent
// X - Hexadecimal

// precision is a number that represents the number of decimal places


double number1 = 1234.5678;

Console.WriteLine($"{number1,15:C1} {number1,15:E2} {number1,15:F3} {number1,15:G4} {number1,15:N5}");

// Date and Time

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateTime today = DateTime.Today;
Console.WriteLine(today);


DateOnly dateOnly = new DateOnly(2021, 12, 25);
TimeOnly timeOnly = new TimeOnly(12, 30, 45);

Console.WriteLine(dateOnly);
Console.WriteLine(timeOnly);

// TimeSpan

TimeSpan timeSpan = new TimeSpan(1, 2, 3, 4, 5);
Console.WriteLine(timeSpan);

// DateTime format with Strings

Console.WriteLine("========== Date Time =============");

DateTime now1 = DateTime.Now;

Console.WriteLine(now1.ToString("yyyy-MM-dd"));
Console.WriteLine(now1.ToString("yyyy-MM-dd HH:mm:ss"));

Console.WriteLine($"{now1:d}");
Console.WriteLine($"{now1:D}");
Console.WriteLine($"{now1:f}");
Console.WriteLine($"{now1:F}");
Console.WriteLine($"{now1:g}");
Console.WriteLine($"{now1:G}");

// File IO

Console.WriteLine("========== File IO =============");

// Create Basic Text File

string text = "Hello, World!";
using(StreamWriter writer = new StreamWriter("file.txt"))
{
    writer.WriteLine(text);
}

// Read Basic Text File

string readText = File.ReadAllText("file.txt");
Console.WriteLine(readText);




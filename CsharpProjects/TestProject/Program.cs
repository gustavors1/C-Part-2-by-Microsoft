// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// diferentes tipos de métodos en la biblioteca de clases .NET

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Métodos sobrecargados

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Random dice2 = new Random();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
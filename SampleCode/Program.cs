// See https://aka.ms/new-console-template for more information
using SampleCode;

Console.WriteLine("Hello, World!");
Calculator calculator = new Calculator();
Console.WriteLine("Enter First Number");
calculator.a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
calculator.b = Convert.ToInt32(Console.ReadLine());
calculator.AddTwoNumber();
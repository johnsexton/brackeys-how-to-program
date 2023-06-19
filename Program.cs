// See https://aka.ms/new-console-template for more information

// Changing the appearance
/*
Console.Title = "Skynet";
Console.ForegroundColor = ConsoleColor.Green;
Console.WindowHeight = 40;
*/

// Episode 1 Tutorial
/* 
Console.WriteLine("Hello, what's you're name?");
Console.ReadLine();
Console.WriteLine("My name is RX-9000.\nI am an AI sent form the future to destroy mankind.\nWhat is your favorite color?");
Console.ReadLine();
Console.WriteLine("Cool! Mine is destruction.");
*/

// Episode 1 Challenge
/*
Console.WriteLine("A proud knight named...");
Console.ReadLine();
Console.WriteLine("...walked into a bar. At the counter he met a...");
Console.ReadLine();
Console.WriteLine("...who asked, 'what do you want to drink?'");
Console.ReadLine();
Console.WriteLine("...shouted the knight! The bartender shushed him quickly.");
*/

// Episode 2 Tutorial
/*
double num01;
double num02;
Console.Write("Input a number: ");
num01 = Convert.ToDouble( Console.ReadLine() );
Console.Write("Input a second number: ");
num02 = Convert.ToDouble( Console.ReadLine() );
double result = num01 * num02;
Console.Write("The result is " + result + ".");
*/

// Episode 2 Challenge
Console.Write("Find the average of three numbers.\n");
double num01;
double num02;
double num03;
Console.Write("First number: ");
num01 = Convert.ToDouble( Console.ReadLine() );
Console.Write("Second number: ");
num02 = Convert.ToDouble( Console.ReadLine() );
Console.Write("Third number: ");
num03 = Convert.ToDouble( Console.ReadLine() );
double result = (num01 + num02 + num03) / 3;
Console.Write("The average is " + result + ".");


// Quit
Console.ReadKey();
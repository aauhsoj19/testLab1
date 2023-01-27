using static System.Console;

//January 28, 2023
/*
 * Task 2 is completed by Joshua Roasa
 */
WriteLine("Hello, World!");
WriteLine("Joshua Roasa");
WriteLine("Version: {0}", Environment.Version.ToString());
string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);
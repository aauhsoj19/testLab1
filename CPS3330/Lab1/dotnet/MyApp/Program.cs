using static System.Console;

// See https://aka.ms/new-console-template for more information
//January 28, 2023
/*
 * Task 2 is completed by Joshua Roasa
 */
WriteLine("Hello, World!");
WriteLine("Joshua Roasa");
WriteLine("Version: {0}", Environment.Version.ToString());

int Num = 20;
WriteLine("Num was:" + Num);
Num = 10;
WriteLine("Num is" + Num);

string[] sections = { "CPS*3330*01", "CPS*3330*03", "TECH*4982*01" };

//print length
WriteLine("Number of sections: " + sections.Length);

//reverse 
Array.Reverse(sections);
Write("\nReverse: ");

//print using foreach loop
foreach (var e in sections)
{
    Write(e.ToString() + " ");
}

WriteLine("\nUsing foreach method:");
sections.ToList().ForEach(e => Write(e.ToString() + " "));

WriteLine("\nArray class and its method:");
Array.ForEach(sections, WriteLine);

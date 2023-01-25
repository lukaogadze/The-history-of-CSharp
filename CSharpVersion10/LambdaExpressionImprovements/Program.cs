// See https://aka.ms/new-console-template for more information

var getUserInput = Console.ReadLine;
var tellUser = (string s) => Console.WriteLine(s);
var waitForEnter = Console.ReadLine;
 
tellUser("Please enter name");
var name = getUserInput();
tellUser($"Your name is {name}");
waitForEnter();

Console.WriteLine("Hello, World!");
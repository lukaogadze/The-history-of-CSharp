// Creating binary literals 
// by prefixing with 0b
var num1 = 0b1001;
var num2 = 0b01000011;
  
Console.WriteLine("Value of Num1 is: " + num1);
Console.WriteLine("Value of Num2 is: " + num2);
Console.WriteLine("Char value of Num2 is: {0}", Convert.ToChar(num2));

var digits = 100_0;
Console.WriteLine(digits);
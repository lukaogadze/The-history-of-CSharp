// See https://aka.ms/new-console-template for more information

var x = 1;
var y = 2;

ref readonly var x1 = ref x;
ref readonly var y1 = ref y;

var z = x1 == 1 ? x1 : y1;


Console.WriteLine("Hello, World!");
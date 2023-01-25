// See https://aka.ms/new-console-template for more information


int[] fibonacci = { 1, 2, 3, 5, 8 };

bool result = false;

// result is false, last number is not matching
result = fibonacci is [1, 2, 3, 5, 9];

// result is false, elements are not at same positions
result = fibonacci is [8, 1, 2, 3, 5];

// result is false, length is not matching
result = fibonacci is [1, 2, 3, 5];

// result is true, elements, positions and length is matching
result = fibonacci is [1, 2, 3, 5, 8];


// int[] fibonacci = { 1, 2, 3, 5, 8 };
// bool result = false;
//
// // result is false, length not matching
// result = fibonacci is [_, _, 3, _];
//
// // result is false, 3 is not at same position
// result = fibonacci is [_, _, _, 3, _];
//
// // result is false, length is matching but 2 and 3 not at same positions
// result = fibonacci is [2, _, 3, _, _];
//
// // result is true, single element and its position and length is matching
// result = fibonacci is [1, _, _, _, _];
//
// // result is true, multiple elements and their positions and length is matching
// result = fibonacci is [1, _, 3, _, _];


Console.WriteLine("Hello, World!");
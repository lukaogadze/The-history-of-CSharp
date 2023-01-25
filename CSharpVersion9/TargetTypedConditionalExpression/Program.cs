// See https://aka.ms/new-console-template for more information

var isTrue = false;

Pet pet = isTrue ? new Cat() : new Dog();

Console.WriteLine("Hello, World!");

public abstract class Pet {
}
public class Cat:Pet {
}

public class Dog:Pet {
}
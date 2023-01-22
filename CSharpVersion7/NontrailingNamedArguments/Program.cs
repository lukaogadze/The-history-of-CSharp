// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static void PrintEmployeeInfo(string name, int age, string address, bool isActive = default, bool isManager = default)
{
    Console.WriteLine("Name: {0}, Age: {1}, Address: {2}, Is Active: {3}, Is Manager: {4}", name, age, address, isActive, isManager);
}

static void Example()
{
    PrintEmployeeInfo("Mark", 24, "22 Ashdown close");
    PrintEmployeeInfo("John", 31, "9 Ashdown close", true, false);
    PrintEmployeeInfo(name:"Stella", age:29, address:"32 burak town", isActive:true, isManager:true);
    PrintEmployeeInfo(age:27, address:"81 wall street", name: "Andy", isManager: true, isActive: true);
}
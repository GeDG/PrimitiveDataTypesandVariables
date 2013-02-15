using System;

class HelloWorld
{
    static void Main()
    {
        string a = "Hello";
        string b = "World!";
        object ab = a + " " + b;
        string greeting = ab.ToString();
        Console.WriteLine(greeting);
    }
}


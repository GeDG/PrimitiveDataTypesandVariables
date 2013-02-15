using System;

class nullVal
{
    static void Main()
    {
        int? a = null; 
        double? b = null;
        a += 1;
        b += 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}


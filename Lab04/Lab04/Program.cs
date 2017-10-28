using System;
public class GotoTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Line 1");
    line4:
        Console.WriteLine("Line 2");
    line9:
        Console.WriteLine("Line 3");
    
        Console.WriteLine("Line 4");
        Console.WriteLine("Line 5");
    line2:
        Console.WriteLine("Line 6");
        goto line10;
        Console.WriteLine("Line 7");
        Console.WriteLine("Line 8");
        Console.WriteLine("Line 9");
    line10:
        Console.WriteLine("Line 10");
    }
}

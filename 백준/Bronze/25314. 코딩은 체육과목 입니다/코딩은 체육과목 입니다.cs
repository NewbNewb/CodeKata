using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);
        string s = "";

        for (int i = 0; i < count / 4; i++)
        {
            s += "long ";
        }
        Console.WriteLine($"{s}int");
    }
}
using System;

public class Example
{
    public static void Main()
    {
        int vel = 0;
        int.TryParse(Console.ReadLine(), out int count);
        string s = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            vel += int.Parse(s[i].ToString());
        }
        Console.WriteLine(vel);
    }
}
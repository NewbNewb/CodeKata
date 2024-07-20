using System;

public class Example
{
    public static void Main()
    {
        string s = Console.ReadLine();
        char[] chars = new char[s.Length];
        chars = s.ToCharArray();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(chars[n - 1]);
    }
}
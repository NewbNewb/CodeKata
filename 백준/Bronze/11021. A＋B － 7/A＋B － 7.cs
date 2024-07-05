using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);
        string s = "";

        for (int i = 1; i <= count; i++)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);

            s += "Case #" + i + ": " + (n1 + n2) + "\n";
        }
        Console.Write(s);
    }
}
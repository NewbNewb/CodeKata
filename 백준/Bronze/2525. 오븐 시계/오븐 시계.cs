using System;

public class Example
{
    public static void Main()
    {
        string[] ss = Console.ReadLine().Split(' ');
        int.TryParse(ss[0], out int n1);
        int.TryParse(ss[1], out int n2);
        int.TryParse(Console.ReadLine(), out int n3);

        n2 += n3;
        n1 += n2 / 60;
        n2 %= 60;
        n1 %= 24;

        Console.WriteLine(n1 + " " + n2);
    }
}
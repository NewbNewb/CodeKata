using System;

public class Example
{
    public static void Main()
    {
        int n1 = 0;
        int n2 = 0;

        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        int.TryParse(ss[0], out n1);
        int.TryParse(ss[1], out n2);

        n2 -= 45;

        if (n2 < 0)
        {
            n1--;
            n2 += 60;
        }
        if (n2 > 59)
        {
            n1++;
            n2 -= 60;
        }
        if (n1 >= 24)
        {
            n1 -= 24;
        }
        if (n1 < 0)
        {
            n1 += 24;
        }
        Console.WriteLine(n1 + " " + n2);
    }
}
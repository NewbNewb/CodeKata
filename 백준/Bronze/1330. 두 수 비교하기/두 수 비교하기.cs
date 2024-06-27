using System;

public class Example
{
    public static void Main()
    {
        string vel = "";
        int n1 = 0;
        int n2 = 0;

        string s = Console.ReadLine();
        string[] ss = s.Split(' ');
        int.TryParse(ss[0], out n1);
        int.TryParse(ss[1], out n2);

        if (n1 > n2)
        {
            vel = ">";
        }
        else if (n1 < n2)
        {
            vel = "<";
        }
        else
        {
            vel = "==";
        }

        Console.WriteLine(vel);
    }
}
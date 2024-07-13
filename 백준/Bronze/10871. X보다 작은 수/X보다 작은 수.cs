using System;

public class Example
{
    public static void Main()
    {
        string vel = "";
        string[] s1 = Console.ReadLine().Split(' ');
        int.TryParse(s1[0], out int count);
        int.TryParse(s1[1], out int targetNunber);

        string[] ss = new string[count];
        ss = Console.ReadLine().Split(' ');

        for (int i = 0; i < ss.Length; i++)
        {
            int.TryParse(ss[i], out int n);
            if (targetNunber > n)
            {
                vel += ss[i] + " ";
            }
        }
        Console.WriteLine(vel);
    }
}
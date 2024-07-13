using System;

public class Example
{
    public static void Main()
    {
        int vel = 0;
        int.TryParse(Console.ReadLine(), out int count);
        string[] ss = new string[count];
        ss = Console.ReadLine().Split(' ');
        int.TryParse(Console.ReadLine(), out int tn);

        for (int i = 0; i < ss.Length; i++)
        {
            int.TryParse(ss[i], out int n);
            if (tn == n)
            {
                vel++;
            }
        }
        Console.WriteLine(vel);
    }
}
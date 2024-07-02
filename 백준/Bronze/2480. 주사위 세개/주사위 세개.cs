using System;

public class Example
{
    public static void Main()
    {
        int reward;
        string[] ss = Console.ReadLine().Split(' ');
        int.TryParse(ss[0], out int n1);
        int.TryParse(ss[1], out int n2);
        int.TryParse(ss[2], out int n3);

        if (n1 == n2 && n2 == n3)
        {
            reward = n2 * 1000 + 10000;
        }
        else if(n1 == n2 || n2 == n3 )
        {
            reward = n2 * 100 + 1000;
        }
        else if(n1 == n3)
        {
            reward = n1 * 100 + 1000;
        }
        else
        {
            int[] n = {n1, n2, n3};
            Array.Sort(n);
            reward = n[2] * 100;
        }
        Console.WriteLine(reward);
    }
}
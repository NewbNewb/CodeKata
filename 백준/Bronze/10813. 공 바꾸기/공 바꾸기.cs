using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int.TryParse(s[0], out int n);
        int.TryParse(s[1], out int m);
        int[] num = new int[n];

        for (int i = 0; i < n; i++)
        {
            num[i] = i + 1;
        }

        for (int i = 0; i < m; i++)
        {
            s = Console.ReadLine().Split(' ');
            int.TryParse(s[0], out int n1);
            int.TryParse(s[1], out int n2);
            int n3 = 0;
            n1--; n2--;

            n3 = num[n1];
            num[n1] = num[n2];
            num[n2] = n3;
        }
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    }
}
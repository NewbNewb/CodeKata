using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int.TryParse(s[0], out int n);
        int.TryParse(s[1], out int m);
        int[] num = new int[n];

        for (int i = 0; i < m; i++)
        {
            s = Console.ReadLine().Split(' ');
            int.TryParse(s[0], out int n1);
            int.TryParse(s[1], out int n2);
            int.TryParse(s[2], out int n3);

            for (int j = n1 - 1; j < n2; j++)
            {

                if (num[j] != n3)
                {
                    num[j] = n3;
                }
            }
        }
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    }
}
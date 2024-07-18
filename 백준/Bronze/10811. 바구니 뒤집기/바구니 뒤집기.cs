using System;

public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        int.TryParse(s[0], out int n);
        int.TryParse(s[1], out int m);

        int[] vel = new int[n];

        for (int i = 0; i < vel.Length; i++)
        {
            vel[i] = i + 1;
        }
        for (int i = 0; i < m; i++)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int.TryParse(s1[0], out int n1);
            int.TryParse(s1[1], out int n2);
            n1--; n2--;

            int[] ints = new int[n2 - n1 + 1];
            int count = 0;

            for (int j = n1; j <= n2; j++)
            {
                ints[count] = vel[j];
                count++;
            }
            for (int j = n1; j <= n2; j++)
            {
                count--;
                vel[j] = ints[count];
            }
        }
        for (int i = 0; i < vel.Length; i++)
        {
            Console.Write(vel[i] + " ");
        }
    }
}
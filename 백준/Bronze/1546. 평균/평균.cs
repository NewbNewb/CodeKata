using System;

public class Example
{
    public static void Main()
    {
        float vel = 0;
        int count = int.Parse(Console.ReadLine());
        int[] ints = new int[count];
        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < count; i++)
        {
            int.TryParse(s[i], out int n);
            ints[i] = n;
        }
        Array.Sort(ints);
        Array.Reverse(ints);
        for (int i = 0; i < count; i++)
        {
            vel += ints[i] / (float)ints[0] * 100;
        }
        vel /= count;
        Console.WriteLine(vel);
    }
}
using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);
        string[] s1 = Console.ReadLine().Split(' ');
        int[] n = new int[s1.Length];
        for (int i = 0; i < s1.Length; i++)
        {
            n[i] += int.Parse(s1[i]);
        }
        Array.Sort(n);
        Console.WriteLine(n.Min() + " " + n.Max());
    }
}
using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        int[] ns = new int[9];
        int n1 = 0;
        int n3 = 0;
        for (int i = 0; i < ns.Length; i++)
        {
            int.TryParse(Console.ReadLine(), out int n2);
            ns[i] = n2;
            if (n1 < n2)
            {
                n1 = n2;
                n3 = i + 1;
            }
        }
        Console.WriteLine(ns.Max());
        Console.WriteLine(n3);
    }
}
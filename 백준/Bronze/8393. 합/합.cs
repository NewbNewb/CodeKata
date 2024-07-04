using System;

public class Example
{
    public static void Main()
    {
        int sum = 0;
        int.TryParse(Console.ReadLine(), out int n);

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}
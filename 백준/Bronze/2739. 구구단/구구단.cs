using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n1);

        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{n1} * {i} = {n1 * i}");
        }
    }
}
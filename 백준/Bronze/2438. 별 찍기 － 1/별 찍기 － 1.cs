using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);

        for (int i = 1; i <= count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);

        for (int i = 1; i <= count; i++)
        {
            for (int j = count; j > 0; j--)
            {
                if (i < j)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
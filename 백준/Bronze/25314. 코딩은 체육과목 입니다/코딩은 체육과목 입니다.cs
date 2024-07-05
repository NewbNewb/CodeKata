using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);

        for (int i = 0; i < count / 4; i++)
        {
            Console.Write("long ");
        }
        Console.Write("int");
    }
}
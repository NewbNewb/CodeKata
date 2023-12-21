using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        
        for (int i = 0; i < b; i++)
        {
            for (int j = 0; j < a; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();    
        }
    }
}
using System;

public class Example
{
    public static void Main()
    {
        bool[] check = new bool[42];
        int vel = 0;

        for (int i = 0; i < 10; i++)
        {
            int.TryParse(Console.ReadLine(), out int count);
            if (check[count % 42] == false)
            {
                check[count % 42] = true;
                vel++;
            }
        }
        Console.WriteLine(vel);
    }
}
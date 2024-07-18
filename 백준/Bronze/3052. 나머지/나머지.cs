using System;

public class Example
{
    public static void Main()
    {
        int[] num = new int[10];
        int vel = 1;

        for (int i = 0; i < num.Length; i++)
        {
            int.TryParse(Console.ReadLine(), out int count);
            num[i] = count % 42;
        }

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i + 1 ; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    break;
                }
                if (j == num.Length - 1)
                {
                    vel++;
                }
            }
        }
        Console.WriteLine(vel);
    }
}
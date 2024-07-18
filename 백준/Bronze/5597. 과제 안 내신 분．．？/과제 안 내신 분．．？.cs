using System;

public class Example
{
    public static void Main()
    {
        int[] num = new int[30];

        for (int i = 0; i < 28; i++)
        {
            int.TryParse(Console.ReadLine(), out int count);
            num[count - 1] = count;
        }

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == 0)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
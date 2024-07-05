using System;

public class Example
{
    public static void Main()
    {
        long.TryParse(Console.ReadLine(), out long sum);
        int.TryParse(Console.ReadLine(), out int count);
        int[] type = new int[count];
        long total = 0;

        for (int i = 0; i < type.Length; i++)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);

            total += n1 * n2;
        }

        if (sum == total)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
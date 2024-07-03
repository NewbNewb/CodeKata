using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);
            numbers[i] = n1 + n2;
        }
        for (int i = 0;i < numbers.Length;i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
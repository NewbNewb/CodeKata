using System;

public class Example
{
    public static void Main()
    {
        int n = 0;
        string s = Console.ReadLine();
        int.TryParse(s, out n);

        if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
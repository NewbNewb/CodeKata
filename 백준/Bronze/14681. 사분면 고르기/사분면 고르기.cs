using System;

public class Example
{
    public static void Main()
    {
        int n1 = 0;
        int n2 = 0;

        string s = Console.ReadLine();
        string s1 = Console.ReadLine();
        int.TryParse(s, out n1);
        int.TryParse(s1, out n2);

        if (n1 > 0 && n2 > 0)
        {
            Console.WriteLine("1");
        }
        else if (n1 < 0 && n2 > 0)
        {
            Console.WriteLine("2");
        }
        else if (n1 < 0 && n2 < 0)
        {
            Console.WriteLine("3");
        }
        else if (n1 > 0 && n2 < 0)
        {
            Console.WriteLine("4");
        }
    }
}
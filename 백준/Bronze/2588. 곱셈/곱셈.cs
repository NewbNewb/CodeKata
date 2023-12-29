using System;
public class Example
{
    public static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        char[] chars = s2.ToCharArray();

        int a = int.Parse(s1);

        int n1 = int.Parse(chars[2].ToString());
        int n2 = int.Parse(chars[1].ToString());
        int n3 = int.Parse(chars[0].ToString());

        Console.WriteLine(a * n1);
        Console.WriteLine(a * n2);
        Console.WriteLine(a * n3);
        Console.WriteLine((a * n1) + (a * n2 * 10) + (a * n3 * 100));
    }
}
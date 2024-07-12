using System;

public class Example
{
    public static void Main()
    {        
        while (true)
        {
            string s = Console.ReadLine();
            if (s == null)
            {
                break;
            }
            string[] ss = s.Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);
            Console.WriteLine(n1 + n2);
        }
    }
}
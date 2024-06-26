using System;

public class Example
{
    public static void Main()
    {
        long vel = 0; 
        string s = Console.ReadLine();
        string[] ss = s.Split(' ');

        for (int i = 0; i < ss.Length; i++)
        {
            long n = 0;
            long.TryParse(ss[i], out n);
            vel += n;
        }
         
        Console.WriteLine(vel);
    }
}
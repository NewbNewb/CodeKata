using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int count);
        StringBuilder s = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);

            s.Append((n1 + n2).ToString() + "\n");
        }
        Console.WriteLine(s.ToString());
    }
}
using System;

public class Example
{
    public static void Main()
    {
        string s = "";

        while (true)
        {
            string[] ss = Console.ReadLine().Split(' ');
            int.TryParse(ss[0], out int n1);
            int.TryParse(ss[1], out int n2);

            if (n1 == 0 && n2 == 0)
            {
                Console.WriteLine(s);
                break;
            }
            s += n1 + n2 + "\n";          
        }
    }
}
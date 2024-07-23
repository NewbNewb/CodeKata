using System;

public class Example
{
    public static void Main()
    {
        string vel = "";
        int.TryParse(Console.ReadLine(), out int count);

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            vel += input[0].ToString() + input.Substring(input.Length - 1, 1) + "\n";
        }
        Console.WriteLine(vel);
    }
}
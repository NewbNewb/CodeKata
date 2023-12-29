public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');

        double a = int.Parse(s[0]);
        double b = int.Parse(s[1]);

        Console.WriteLine(a / b);
    }
}
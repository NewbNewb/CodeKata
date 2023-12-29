public class Example
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');

        Double a = int.Parse(s[0]);
        Double b = int.Parse(s[1]);

        Console.WriteLine(a / b);
    }
}
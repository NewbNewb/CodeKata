using System;

public class Example
{
    public static void Main()
    {
        int n = 0;
        string s = Console.ReadLine();
        int.TryParse(s, out n);

        if (n <= 100 && n >= 0)
        {
            switch (n / 10)
            {
                case 10:
                    Console.WriteLine("A");
                    break;
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
        else
        {
            Console.WriteLine("올바른 점수를 입력해주세요.");
        }
    }
}
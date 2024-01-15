using System;

public class Solution {
    public string solution(string s, int n)
    {
        string answer = "";
        int n1 = 0;
        foreach (char c1 in s)
        {
            if (c1 == ' ')
            {
                answer += c1;
                continue;
            }
            n1 = (int)c1;
            if (n1 >= 97 && n1 <= 122)
            {
                n1 += n;
                if (n1 > 122)
                {
                    n1 -= 26;
                }
            }
            if (n1 >= 65 && n1 <= 90)
            {
                n1 += n;
                if (n1 > 90)
                {
                    n1 -= 26;
                }
            }
            char c2 = (char)n1;
            answer += c2;
        }
        return answer;
    }
}
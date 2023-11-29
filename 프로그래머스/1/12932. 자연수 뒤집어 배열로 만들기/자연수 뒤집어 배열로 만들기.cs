using System;
using System.Linq;

public class Solution {
    public int[] solution(long n)
        {
            char[] str = n.ToString().ToCharArray();
            int[] answer = new int[str.Length];

            for (int i = 0; str.Length > i; i++)
            {
                answer[i] = int.Parse(str[i].ToString());
            }
            Array.Reverse(answer);
            return answer;
        }
}
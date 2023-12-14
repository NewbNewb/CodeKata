using System;

public class Solution {
    public int solution(int left, int right)
    {
        int answer = 0;
        int count = 0;

        for (int i = 0; left + i <= right; i++)
        {
            for (int j = 1; j <= left + i; j++)
            {
                if ((left + i) % j == 0)
                {
                    count++;
                }
            }
            if (count % 2 == 0)
            {
                answer += left + i;
            }
            else
            {
                answer -= left + i;
            }
            count = 0;
        }
        return answer;
    }
}
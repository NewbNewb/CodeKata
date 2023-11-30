public class Solution {
    public long solution(int a, int b)
        {
            long answer = 0;
            if (a < b)
            {
                for (int i = 0; b >= a + i; i++)
                {
                    answer += a + i;
                }
            }
            else
            {
                for (int i = 0; a >= b + i; i++)
                {
                    answer += b + i;
                }
            }
            return answer;
        }
}
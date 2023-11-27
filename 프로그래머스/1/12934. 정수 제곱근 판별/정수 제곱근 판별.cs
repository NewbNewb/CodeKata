public class Solution {
    public long solution(long n)
    {
        long answer = 0;
        long n1 = 1;
        while (n1 * n1 < n)
        {
            n1++;
        }

        if (n1 * n1 == n)
        {
            n1 += 1;
            answer = n1 * n1;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}
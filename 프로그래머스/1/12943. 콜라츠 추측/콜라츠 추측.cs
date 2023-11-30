public class Solution {
    public int solution(long num)
    {
        int count = 0;

        for (; count < 500; count++)
        {
            if (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
            }
            else
                break;
        }
        if (count == 500)
        {
            count = -1;
        }
        return count;
    }
}
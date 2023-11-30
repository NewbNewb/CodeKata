using System;

public class Solution {
    public int solution(int num)
    {
        int count = 0;
        long num1 = num;

        for (; count < 500; count++)
        {
            if (num1 != 1)
            {
                if (num1 % 2 == 0)
                {
                    num1 /= 2;
                }
                else
                {
                    num1 = num1 * 3 + 1;
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
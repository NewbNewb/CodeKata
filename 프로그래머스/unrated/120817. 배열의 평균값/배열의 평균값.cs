using System;

public class Solution {
    public double solution(int[] numbers) {
        int x = 0;
        int y = 0;
        foreach (int i in numbers)
        {
            x += i;
            y++;
        }
    double answer = (double)x / y ;
    return answer;
    }
}
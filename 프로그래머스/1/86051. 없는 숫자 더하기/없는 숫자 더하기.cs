using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        for (int i = 0; i < 10; i++)
        {
            answer += i;
        }
        answer -= sum;
        return answer;
    }
}
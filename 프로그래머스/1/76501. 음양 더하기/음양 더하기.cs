using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs)
    {
        int vel = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i] == true)
            {
                vel += absolutes[i];
            }
            else
            {
                vel -= absolutes[i];
            }
        }
        return vel;
    }
}
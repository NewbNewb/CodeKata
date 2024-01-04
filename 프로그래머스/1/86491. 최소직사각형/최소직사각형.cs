using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int n1 = 0;
        int n2 = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            if(sizes[i,0] < sizes[i,1])
            {
                int temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;
            }
            if(n1 < sizes[i,0])
            {
                n1 = sizes[i,0];
            }
            if(n2 < sizes[i,1])
            {
                n2 = sizes[i,1];
            }
        }
        return answer = n1 * n2;
    }
}

using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) 
    {
        List<int> answerList = new List<int>();
        for(int i = 0; i < commands.GetLength(0); i++) 
        {
            int startIdx = commands[i, 0] - 1;
            int endIdx = commands[i, 1] - 1;
            int idx = commands[i, 2] - 1;

            int[] subArray = new int[endIdx - startIdx + 1];
            Array.Copy(array, startIdx, subArray, 0, subArray.Length);
            Array.Sort(subArray);
            answerList.Add(subArray[idx]);
        }
        return answerList.ToArray();
    }
}

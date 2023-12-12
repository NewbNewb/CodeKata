using System;
using System.Collections.Generic;

public class Solution{
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }

        int x = arr[0];
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < x)
            {
                x = arr[i];
            }
        }
        List<int> list = new List<int>(arr);
        list.Remove(x);
        answer = list.ToArray();
        
        return answer;
    }
}
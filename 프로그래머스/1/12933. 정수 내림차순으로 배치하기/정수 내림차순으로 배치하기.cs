using System;
using System.Linq;

public class Solution {
    public long solution(long n)
    {
        char[] n1 = n.ToString().ToArray();
        Array.Sort(n1);
        Array.Reverse(n1);
        long answer = long.Parse(n1);
        return answer;
    }
}
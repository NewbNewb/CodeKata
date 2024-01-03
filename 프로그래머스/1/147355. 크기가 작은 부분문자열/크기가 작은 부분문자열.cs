using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        float n1 = float.Parse(p);
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            string s = t.Substring(i, p.Length);
            float n2 = float.Parse(s);
            if (n2 <= n1) { answer++; }
        }
        return answer;
    }
}
public class Solution {
    public long[] solution(long x, int n) {
        long[] answer = new long[n];
        for (int i = 0; i < n; i++)
        {
            long res = (i + 1) * x;
            answer[i] = res;
        }
        return answer;
    }
}
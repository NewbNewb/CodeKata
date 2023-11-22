public class Solution {
    public double solution(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
           sum += num;
        }
        double answer = (double)sum/arr.Length;
        return answer;
    }
}
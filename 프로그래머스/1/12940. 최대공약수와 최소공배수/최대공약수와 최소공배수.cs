public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[] {0,0};
        int num1 = n;
        int num2 = m;
        int num3 = 0;
        
        while(true)
        {
            if( num1 % num2 == 0)
            {
                answer[0] = num2;
                answer[1] = n * m / num2;
                break;
            }
            else
            {
                num3 = num2;
                num2 = num1 % num2;
                num1 = num3;
            }
        }
        return answer;
    }
}
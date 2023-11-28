public class Solution {
    public bool solution(int x) {
        int n1 = 0;
        int n2 = x;

        for ( ; n2 > 0; n2 = n2 / 10 ) 
        {
            n1 += (n2 % 10);
        }
        if (x % n1 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
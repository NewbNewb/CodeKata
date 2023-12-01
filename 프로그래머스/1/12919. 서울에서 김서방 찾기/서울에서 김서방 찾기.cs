public class Solution {
    public string solution(string[] seoul)
    {
        string answer = "";
        int count = 0;

        foreach (string s in seoul)
        {
            if (s == "Kim")
            {
                break;
            }
            count++;
        }
        return answer = "김서방은 " + count.ToString() + "에 있다";
    }
}
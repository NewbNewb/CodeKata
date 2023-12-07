public class Solution {
    public string solution(string phone_number)
    {
        string answer = "";
        int num = phone_number.Length - 4;
        for (int i = 0; i < num; i++)
        {
            answer += '*';
        }
        phone_number = phone_number.Substring(num);
        answer += phone_number;
        return answer;
    }
}
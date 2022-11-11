/*
The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
countAndSay(1) = "1"
countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1), which is then converted into a different digit string.
To determine how you "say" a digit string, split it into the minimal number of substrings such that each substring contains exactly one unique digit. 
Then for each substring, say the number of digits, then say the digit. 
Finally, concatenate every said digit.
*/
public class Solution {
    public string CountAndSay(int n) {
        if(n == 1) return "1";
        string s = CountAndSay(n-1);
        StringBuilder sb = new StringBuilder();
        int count = 1;
        for(int i = 0; i < s.Length; i++){
            if(i == s.Length - 1 || s[i] != s[i+1]){
                sb.Append(count);
                sb.Append(s[i]);
                count = 1;
            }
            else{
                count++;
            }
        }
        return sb.ToString();
    }
}
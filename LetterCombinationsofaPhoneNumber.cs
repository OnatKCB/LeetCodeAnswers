/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
*/
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var dict = new Dictionary<int, string>();
        dict.Add(2, "abc");
        dict.Add(3, "def");
        dict.Add(4, "ghi");
        dict.Add(5, "jkl");
        dict.Add(6, "mno");
        dict.Add(7, "pqrs");
        dict.Add(8, "tuv");
        dict.Add(9, "wxyz");
        var result = new List<string>();
        if(string.IsNullOrEmpty(digits)) return result;
        var sb = new StringBuilder();
        BackTrack(digits, 0, sb, dict, result);
        return result;
    }
    
    private void BackTrack(string digits, int index, StringBuilder sb, Dictionary<int, string> dict, List<string> result){
        if(index == digits.Length){
            result.Add(sb.ToString());
            return;
        }
        
        var digit = digits[index] - '0';
        var letters = dict[digit];
        for(int i = 0; i < letters.Length; i++){
            sb.Append(letters[i]);
            BackTrack(digits, index + 1, sb, dict, result);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}
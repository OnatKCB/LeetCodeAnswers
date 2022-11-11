/*Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.*/
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        if(n == 0) return result;
        var sb = new StringBuilder();
        BackTrack(n, 0, 0, sb, result);
        return result;
    }
    
    private void BackTrack(int n, int open, int close, StringBuilder sb, List<string> result){
        if(sb.Length == 2 * n){
            result.Add(sb.ToString());
            return;
        }
        
        if(open < n){
            sb.Append("(");
            BackTrack(n, open + 1, close, sb, result);
            sb.Remove(sb.Length - 1, 1);
        }
        
        if(close < open){
            sb.Append(")");
            BackTrack(n, open, close + 1, sb, result);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}
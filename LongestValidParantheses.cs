/*
Given a string containing just the characters '(' and ')', return the length of the longest valid (well-formed) parentheses substring.
*/
public class Solution {
    public int LongestValidParentheses(string s) {
        var stack = new Stack<int>();
        var result = 0;
        var start = -1;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '('){
                stack.Push(i);
            }else{
                if(stack.Count == 0){
                    start = i;
                }else{
                    stack.Pop();
                    if(stack.Count == 0){
                        result = Math.Max(result, i - start);
                    }else{
                        result = Math.Max(result, i - stack.Peek());
                    }
                }
            }
        }
        return result;
    }
}
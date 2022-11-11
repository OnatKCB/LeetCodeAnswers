/*
Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
'?' Matches any single character.
'*' Matches any sequence of characters (including the empty sequence).
The matching should cover the entire input string (not partial).
*/
public class Solution {
    public bool IsMatch(string s, string p) {
        int m = s.Length;
        int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for(int i = 1; i <= n; i++){
            dp[0, i] = dp[0, i - 1] && p[i - 1] == '*';
        }
        for(int i = 1; i <= m; i++){
            for(int j = 1; j <= n; j++){
                if(s[i - 1] == p[j - 1] || p[j - 1] == '?'){
                    dp[i, j] = dp[i - 1, j - 1];
                } else if(p[j - 1] == '*'){
                    dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                }
            }
        }
        return dp[m, n];
    }
}
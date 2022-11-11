/*
Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
The matching should cover the entire input string (not partial).
*/
public class Solution {
    public bool IsMatch(string s, string p) 
    {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;
        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2];
                    if (Matches(s, p, i, j - 1))
                    {
                        dp[i, j] = dp[i, j] || dp[i - 1, j];
                    }
                }
                else
                {
                    if (Matches(s, p, i, j))
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                }
            }
        }
        return dp[s.Length, p.Length];
    }
    private bool Matches(string s, string p, int i, int j)
    {
        if (i == 0) return false;
        if (p[j - 1] == '.') return true;
        return s[i - 1] == p[j - 1];
    }
}

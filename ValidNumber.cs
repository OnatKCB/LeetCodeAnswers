/*
A valid number can be split up into these components (in order):
A decimal number or an integer.
(Optional) An 'e' or 'E', followed by an integer.
A decimal number can be split up into these components (in order):
(Optional) A sign character (either '+' or '-').
One of the following formats:
One or more digits, followed by a dot '.'.
One or more digits, followed by a dot '.', followed by one or more digits.
A dot '.', followed by one or more digits.
An integer can be split up into these components (in order):
(Optional) A sign character (either '+' or '-').
One or more digits.
For example, all the following are valid numbers: ["2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789"], while the following are not valid numbers: ["abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53"].
Given a string s, return true if s is a valid number.
*/
public class Solution {
    public bool IsNumber(string s) 
    {
        int i = 0;
        int n = s.Length;
        while(i < n && s[i] == ' ')
        {
            i++;
        }
        if(i < n && (s[i] == '+' || s[i] == '-'))
        {
            i++;
        }
        bool isNumber = false;
        while(i < n && char.IsDigit(s[i]))
        {
            i++;
            isNumber = true;
        }
        if(i < n && s[i] == '.')
        {
            i++;
            while(i < n && char.IsDigit(s[i]))
            {
                i++;
                isNumber = true;
            }
        }
        if(i < n && isNumber && (s[i] == 'e' || s[i] == 'E'))
        {
            i++;
            isNumber = false;
            if(i < n && (s[i] == '+' || s[i] == '-'))
            {
                i++;
            }
            while(i < n && char.IsDigit(s[i]))
            {
                i++;
                isNumber = true;
            }
        }
        while(i < n && s[i] == ' ')
        {
            i++;
        }
        return isNumber && i == n;
    }
}
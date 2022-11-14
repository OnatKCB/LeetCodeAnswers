/*
Given two binary strings a and b, return their sum as a binary string.
*/
public class Solution {
    public string AddBinary(string a, string b) 
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        StringBuilder sb = new StringBuilder();
        while(i >= 0 || j >= 0)
        {
            int sum = carry;
            if(i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }
            if(j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }
            sb.Append(sum % 2);
            carry = sum / 2;
        }
        if(carry != 0)
        {
            sb.Append(carry);
        }
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}
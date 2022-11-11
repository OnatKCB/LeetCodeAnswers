/*
Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.
*/
public class Solution {
    public string Multiply(string num1, string num2) {
        int m = num1.Length;
        int n = num2.Length;
        int[] result = new int[m + n];
        for(int i = m - 1; i >= 0; i--){
            for(int j = n - 1; j >= 0; j--){
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int sum = mul + result[i + j + 1];
                result[i + j] += sum / 10;
                result[i + j + 1] = sum % 10;
            }
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < m + n; i++){
            if(sb.Length == 0 && result[i] == 0){
                continue;
            }
            sb.Append(result[i]);
        }
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
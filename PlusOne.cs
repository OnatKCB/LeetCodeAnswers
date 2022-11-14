/*
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. 
The large integer does not contain any leading 0's.
Increment the large integer by one and return the resulting array of digits.
*/
public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int n = digits.Length;
        int[] result = new int[n];
        int carry = 1;
        for(int i = n - 1; i >= 0; i--)
        {
            int sum = digits[i] + carry;
            result[i] = sum % 10;
            carry = sum / 10;
        }
        if(carry == 1)
        {
            int[] newResult = new int[n + 1];
            newResult[0] = 1;
            for(int i = 0; i < n; i++)
            {
                newResult[i + 1] = result[i];
            }
            return newResult;
        }
        return result;
    }
}
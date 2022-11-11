/*
Given a signed 32-bit integer x, return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
*/
public class Solution {
    public int Reverse(int x) {
        int result = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && pop > 7)) return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && pop < -8)) return 0;
            result = result * 10 + pop;
        }
        return result;
    }
}
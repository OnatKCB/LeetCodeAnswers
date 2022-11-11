/*
Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
The integer division should truncate toward zero, which means losing its fractional part. 
For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
Return the quotient after dividing dividend by divisor.
Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231, 231 − 1]. For this problem, if the quotient is strictly greater than 231 - 1, then return 231 - 1, and if the quotient is strictly less than -231, then return -231.
*/
public class Solution {
    public int Divide(int dividend, int divisor) {
        if(dividend == 0) return 0;
        if(divisor == 1) return dividend;
        if(divisor == -1){
            if(dividend > int.MinValue) return -dividend;
            return int.MaxValue;
        }
        long a = Math.Abs((long)dividend);
        long b = Math.Abs((long)divisor);
        var result = 0;
        while(a - b >= 0){
            var x = 0;
            while(a - (b << 1 << x) >= 0){
                x++;
            }
            result += 1 << x;
            a -= b << x;
        }
        if((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0)) return result;
        return -result;
    }
}
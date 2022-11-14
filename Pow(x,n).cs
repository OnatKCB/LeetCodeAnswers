/*
Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
*/
public class Solution {
    public double MyPow(double x, int n) 
    {
        if(n == 0)
        {
            return 1;
        }
        if(n < 0)
        {
            return 1 / MyPow(x, -n);
        }
        if(n % 2 == 0)
        {
            return MyPow(x * x, n / 2);
        }
        else
        {
            return x * MyPow(x * x, n / 2);
        }        
    }
}
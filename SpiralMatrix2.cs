/*
Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.
*/
public class Solution 
{
    public int[][] GenerateMatrix(int n) 
    {
        int[][] result = new int[n][];
        for(int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        int top = 0;
        int bottom = n - 1;
        int left = 0;
        int right = n - 1;
        int count = 1;
        while(top <= bottom && left <= right)
        {
            for(int i = left; i <= right; i++)
            {
                result[top][i] = count++;
            }
            top++;
            for(int i = top; i <= bottom; i++)
            {
                result[i][right] = count++;
            }
            right--;
            if(top <= bottom)
            {
                for(int i = right; i >= left; i--)
                {
                    result[bottom][i] = count++;
                }
                bottom--;
            }
            if(left <= right)
            {
                for(int i = bottom; i >= top; i--)
                {
                    result[i][left] = count++;
                }
                left++;
            }
        }
        return result;    
    }
}
/*
Given an m x n matrix, return all elements of the matrix in spiral order.
*/
public class Solution 
{
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        IList<int> result = new List<int>();
        if(matrix.Length == 0)
        {
            return result;
        }
        int m = matrix.Length;
        int n = matrix[0].Length;
        int top = 0;
        int bottom = m - 1;
        int left = 0;
        int right = n - 1;
        while(top <= bottom && left <= right)
        {
            for(int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++;
            for(int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;
            if(top <= bottom)
            {
                for(int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            if(left <= right)
            {
                for(int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;    
    }
}
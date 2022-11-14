/*
Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.
Note: You can only move either down or right at any point in time. 
*/
public class Solution 
{
    public int MinPathSum(int[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] result = new int[m][];
        for(int i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }
        result[0][0] = grid[0][0];
        for(int i = 1; i < m; i++)
        {
            result[i][0] = result[i - 1][0] + grid[i][0];
        }
        for(int i = 1; i < n; i++)
        {
            result[0][i] = result[0][i - 1] + grid[0][i];
        }
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                result[i][j] = Math.Min(result[i - 1][j], result[i][j - 1]) + grid[i][j];
            }
        }
        return result[m - 1][n - 1];
    }
}
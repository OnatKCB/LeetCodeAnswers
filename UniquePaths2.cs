/*
You are given an m x n integer array grid. There is a robot initially located at the top-left corner (i.e., grid[0][0]). 
The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.
An obstacle and space are marked as 1 or 0 respectively in grid. A path that the robot takes cannot include any square that is an obstacle.
Return the number of possible unique paths that the robot can take to reach the bottom-right corner.
The testcases are generated so that the answer will be less than or equal to 2 * 109.
*/
public class Solution 
{
    public int UniquePathsWithObstacles(int[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[][] result = new int[m][];
        for(int i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }
        for(int i = 0; i < m; i++)
        {
            if(grid[i][0] == 1)
            {
                break;
            }
            result[i][0] = 1;
        }
        for(int i = 0; i < n; i++)
        {
            if(grid[0][i] == 1)
            {
                break;
            }
            result[0][i] = 1;
        }
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                if(grid[i][j] == 1)
                {
                    result[i][j] = 0;
                }
                else
                {
                    result[i][j] = result[i - 1][j] + result[i][j - 1];
                }
            }
        }
        return result[m - 1][n - 1];
    }
}
/*
There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). 
The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.
Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
The test cases are generated so that the answer will be less than or equal to 2 * 109.
*/
public class Solution 
{
    public int UniquePaths(int m, int n) 
    {
        int[][] result = new int[m][];
        for(int i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }
        for(int i = 0; i < m; i++)
        {
            result[i][0] = 1;
        }
        for(int i = 0; i < n; i++)
        {
            result[0][i] = 1;
        }
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                result[i][j] = result[i - 1][j] + result[i][j - 1];
            }
        }
        return result[m - 1][n - 1];
    }
}
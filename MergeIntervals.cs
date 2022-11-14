/*
Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, 
and return an array of the non-overlapping intervals that cover all the intervals in the input.
*/
public class Solution 
{
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals.Length == 0)
        {
            return intervals;
        }
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        List<int[]> result = new List<int[]>();
        int[] current = intervals[0];
        for(int i = 1; i < intervals.Length; i++)
        {
            if(intervals[i][0] <= current[1])
            {
                current[1] = Math.Max(current[1], intervals[i][1]);
            }
            else
            {
                result.Add(current);
                current = intervals[i];
            }
        }
        result.Add(current);
        return result.ToArray();
    }
}
/*
You are given a string s and an integer array indices of the same length. The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
Return the shuffled string.
*/
public class Solution {
    public string RestoreString(string s, int[] indices) {
        var result = new char[s.Length];
        for(int i = 0; i < s.Length; i++){
            result[indices[i]] = s[i];
        }
        return new string(result);
    }
}
/*
On a 2D plane, there are n points with integer coordinates points[i] = [xi, yi]. Return the minimum time in seconds to visit all the points in the order given by points.

You can move according to these rules:

In 1 second, you can either:
move vertically by one unit,
move horizontally by one unit, or
move diagonally sqrt(2) units (in other words, move one unit vertically then one unit horizontally in 1 second).
You have to visit the points in the same order as they appear in the array.
You are allowed to pass through points that appear later in the order, but these do not count as visits.
*/
public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        var result = 0;
        for(int i = 0; i < points.Length - 1; i++){
            var x = Math.Abs(points[i][0] - points[i + 1][0]);
            var y = Math.Abs(points[i][1] - points[i + 1][1]);
            result += Math.Max(x, y);
        }
        return result;
    }
}
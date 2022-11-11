/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
*/
public class Solution {
    public string Convert(string s, int numRows) 
    {
        if (numRows == 1) return s;
        List<StringBuilder> rows = new List<StringBuilder>();
        for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            rows.Add(new StringBuilder());
        int curRow = 0;
        bool goingDown = false;
        foreach (char c in s.ToCharArray())
        {
            rows[curRow].Append(c);
            if (curRow == 0 || curRow == numRows - 1) goingDown = !goingDown;
            curRow += goingDown ? 1 : -1;
        }
        StringBuilder ret = new StringBuilder();
        foreach (StringBuilder row in rows) ret.Append(row);
        return ret.ToString();
    }
}
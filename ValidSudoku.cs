/*
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:
A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
*/
public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var rows = new bool[9, 9];
        var cols = new bool[9, 9];
        var boxes = new bool[9, 9];
        for(var i = 0; i < 9; i++)
        {
            for(var j = 0; j < 9; j++)
            {
                if(board[i][j] == '.') continue;
                var num = board[i][j] - '1';
                var boxIndex = (i / 3) * 3 + j / 3;
                if(rows[i, num] || cols[j, num] || boxes[boxIndex, num]) return false;
                rows[i, num] = cols[j, num] = boxes[boxIndex, num] = true;
            }
        }
        return true;
    }
}
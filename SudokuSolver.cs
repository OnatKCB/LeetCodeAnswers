/*
Write a program to solve a Sudoku puzzle by filling the empty cells.
A sudoku solution must satisfy all of the following rules:
Each of the digits 1-9 must occur exactly once in each row.
Each of the digits 1-9 must occur exactly once in each column.
Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.
The '.' character indicates empty cells.
*/
public class Solution {
    public void SolveSudoku(char[][] board) 
    {
        Solve(board);
    }
    
    bool Solve(char[][] board)
    {
        for(var i = 0; i < 9; i++)
        {
            for(var j = 0; j < 9; j++)
            {
                if(board[i][j] != '.') continue;
                for(var k = 1; k <= 9; k++)
                {
                    board[i][j] = (char)(k + '0');
                    if(IsValid(board, i, j) && Solve(board)) return true;
                    board[i][j] = '.';
                }
                return false;
            }
        }
        return true;
    }
    
    bool IsValid(char[][] board, int row, int col)
    {
        for(var i = 0; i < 9; i++)
        {
            if(i != col && board[row][i] == board[row][col]) return false;
            if(i != row && board[i][col] == board[row][col]) return false;
            var rowIndex = 3 * (row / 3) + i / 3;
            var colIndex = 3 * (col / 3) + i % 3;
            if(rowIndex != row && colIndex != col && board[rowIndex][colIndex] == board[row][col]) return false;
        }
        return true;
    }
}
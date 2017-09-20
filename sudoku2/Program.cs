using System;
using System.Collections.Generic;

namespace sudoku2
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new char[][]{
                new char[]{'.','4','.','.','.','.','.','.','.'},
                new char[]{'.','.','4','.','.','.','.','.','.'},
                new char[]{'.','.','.','1','.','.','7','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','3','.','.','.','6','.'},
                new char[]{'.','.','.','.','.','6','.','9','.'},
                new char[]{'.','.','.','.','1','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','2','.','.'},
                new char[]{'.','.','.','8','.','.','.','.','.'}
            };
            Console.WriteLine(sudoku2(grid));
        }
        
        public static bool sudoku2(char[][] grid)
        {
            int rows = 9;
            int cols = 9;
            Dictionary<char, int> rowsMap = new Dictionary<char, int>();
            Dictionary<char, int> colsMap = new Dictionary<char, int>();
            Dictionary<char, int> gridMap = new Dictionary<char, int>();

            for(int i = 0 ; i < rows; i++)
            {
                for(int j = 0 ; j < cols; j++)
                {
                    if(grid[i][j] == '.')
                    {
                        continue;
                    }
                    if(rowsMap.ContainsKey(grid[i][j]) && rowsMap[grid[i][j]] == i)
                    {
                        return false;
                    }
                    if(colsMap.ContainsKey(grid[i][j]) && colsMap[grid[i][j]] == j)
                    {
                        return false;
                    }
                    int gridNumber  = (2 * (i/3)) + (i/3) + (j/3);
                    if(gridMap.ContainsKey(grid[i][j]) && gridMap[grid[i][j]] == gridNumber)
                    {
                        return false;
                    }
                    rowsMap[grid[i][j]] = i;
                    colsMap[grid[i][j]] = j;
                    gridMap[grid[i][j]] = gridNumber;
                }
            }
            return true;
        }
    }
}

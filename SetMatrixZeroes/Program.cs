using System;

namespace SetMatrixZeroes
{
    //https://leetcode.com/problems/set-matrix-zeroes/description/
    class Program
    {
        static void Main(string[] args)
        {
           SetZeroes(new int[,]{{0, 0, 0, 5}, {4, 3, 1, 4}, {0, 1, 1, 4}, {1, 2, 1, 3}, {0, 0, 1, 1}});
        }
        
         public static void SetZeroes(int[,] matrix) {
          int rows = matrix.GetLength(0);
          int cols = matrix.GetLength(1);
          int col_last = 1;
          for(int i = rows - 1; i >= 0 ; i--)
          {
              if(matrix[i, cols-1] == 0)
              {
                  col_last = 0;
              }
              for(int j = cols - 2 ; j >= 0 ; j--)
              {
                 if(matrix[i, j] == 0)
                 {
                     matrix[i, cols -1] = 0;
                     matrix[rows -1 , j] = 0;
                 }

              }
          }
              
        for(int k = 0 ; k < rows; k++)
        {
            for(int l = 0 ; l < cols - 1; l++)
            {
                if(matrix[k, cols -1] == 0 || matrix[rows -1, l] == 0)
                {
                    matrix[k, l] = 0;
                }
            }
            if(col_last == 0)
            matrix[k, cols -1] = 0;
        }
    
      
         }
    }
}


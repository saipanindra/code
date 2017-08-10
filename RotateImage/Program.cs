using System;

namespace RotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
          var a = new int[,]
          {
              {1, 2, 3},
              {4, 5, 6},
              {7, 8, 9}
          };
          Rotate(a);
        }

        public static void Rotate(int[,] matrix) {
           int n = matrix.GetLength(0);
           
           for(int i =0 ; i < n / 2; i++)
           {
               for(int j = 0 ; j  < n ; j++)
               {
                   int t = matrix[i,j];
                   matrix[i,j] = matrix[n - i - 1, j];
                   matrix[n - i - 1, j] = t;
               }
           }
           
           for(int i = 0 ; i < n; i++)
           {
               for(int j = i+1 ; j < n; j++)
               {
                   int t = matrix[i, j];
                   matrix[i, j] = matrix[j, i];
                   matrix[j, i] = t;
               }
           }
        
        }
    }
}

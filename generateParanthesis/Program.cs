using System;
using System.Collections.Generic;

//https://leetcode.com/problems/generate-parentheses/description/
namespace generateParanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
         var r = GenerateParanthesis(3);
        }
        

        public static IList<string> GenerateParanthesis(int n)
        {
           var result = new List<string>();
           var temp = "";
           back_track(0, 0, n, n, result, temp);
           return result;
        }
        
        private static void back_track(int open_so_far, int close_so_far, int total_open, int total_close, List<string> result, string temp)
        {
          if(open_so_far == total_open && close_so_far == total_close)
          {
              result.Add(temp);
              return;
          }
          if(open_so_far < total_open)
          {
              string temp1 = temp + "(";
              back_track(open_so_far + 1, close_so_far, total_open, total_close, result, temp1);
          }
          if(close_so_far < open_so_far)
          {
              string temp2 = temp + ")";
              back_track(open_so_far, close_so_far + 1, total_open, total_close, result, temp2);
          }
        }
          
          
         
          

        }
    }


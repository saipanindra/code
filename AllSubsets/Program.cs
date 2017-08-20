using System;
using System.Collections.Generic;

namespace AllSubsets
{
    //https://leetcode.com/problems/subsets/description/
    class Program
    {
        static void Main(string[] args)
        {
           var r = Subsets(new int[]{1,2 ,3});
        }
        
        public static IList<IList<int>> Subsets(int[] nums) {
         int totalSubsets = (int)Math.Pow(2, nums.Length);
         IList<IList<int>> resultList = new List<IList<int>>();
         for(int i = 0 ; i < totalSubsets; i++)
         {
            List<int> subSet = new List<int>(); 
            for(int j = 0 ; j < nums.Length; j++)
            {
                if((i & (1 << j))!=0)
                {
                  subSet.Add(nums[j]);
                }
            }
            resultList.Add(subSet);
         }
         return resultList;
        }
    }
}

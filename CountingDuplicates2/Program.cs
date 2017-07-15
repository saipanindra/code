using System;
using System.Collections.Generic;

namespace CountingDuplicates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsNearbyDuplicate(new int[]{99, 99}, 2));
        }

//[99, 99], 2
        public static bool ContainsNearbyDuplicate(int[] nums, int k) {
            // [0] 
            if(nums.Length <=1)
            {
                return false;
            }
            HashSet<int> s = new HashSet<int>();
            for(int i = 0 ; i <= k ; i++)
            {
                if(s.Contains(nums[i]))
                {
                    return true;
                }
                s.Add(nums[i]);
            }
             //0 1 2 3 , 2
            int j = 1;
            while(j <= nums.Length - k - 1)
            {
                    s.Remove(nums[j-1]);
                    if(s.Contains(nums[j + k]))
                    {
                        return true;
                    }
                    s.Add(nums[j + k]);
                    j++;
            }
            return false;
            }
        }
    }
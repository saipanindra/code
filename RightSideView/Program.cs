using System;
using System.Collections.Generic;

namespace RightSideView
{
    //https://leetcode.com/problems/binary-tree-right-side-view/description/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IList<int> RightSideView(TreeNode root)
        {
           var result = new List<int>();
           if(root == null) return result; 
           _RightSideView(root, 0, result);
           return result;
        }

        private static void _RightSideView(TreeNode root, int depth, IList<int> result)
        {
            if(root == null) return;
            if(depth == result.Count)
            {
                result.Add(root.val);
            }
            _RightSideView(root.right, depth + 1, result);
            _RightSideView(root.left, depth + 1, result);
        }

    }
     public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }

    }
}

using System;

namespace MaxDepth
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
    
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

}

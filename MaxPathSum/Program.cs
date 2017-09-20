using System;

namespace MaxPathSum
{
    //https://leetcode.com/problems/binary-tree-maximum-path-sum/discuss/
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode(-3);
            Console.WriteLine(MaxPathSum(t));
        }
    

        public static int MaxPathSum(TreeNode root)
        {
            ResultMax r = new ResultMax();
            _MaxPathSum(root, r);
            return r.Max;
        }

        private static int _MaxPathSum(TreeNode root, ResultMax r)
        {
            if(root == null) return 0;
            int left = Math.Max(0, _MaxPathSum(root.left, r));
            int right = Math.Max(0, _MaxPathSum(root.right, r));
            r.Max = Math.Max(r.Max, left + right + root.val);
            return Math.Max(left, right) + root.val;
        }
    }

    public class ResultMax
    {
        public int Max;
        public ResultMax()
        {
            Max = Int32.MinValue;
        }
    }

    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
 }

}

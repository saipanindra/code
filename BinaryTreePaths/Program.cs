using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreePaths
{

    class Program
    {
        public class TreeNode
        {
            public TreeNode left;
            public TreeNode right;
            public int val;
            public TreeNode(int v)
            {
                val = v;
            }
        }
        static void Main(string[] args)
        {
            TreeNode r = new TreeNode(1);
            r.left = new TreeNode(2);
            r.right = new TreeNode(3);
            r.left.right = new TreeNode(5);
            r.left.left = new TreeNode(7);
            r.left.left.right = new TreeNode(8);
            var result = BinaryTreePaths(r);
        }

        public static IList<string> BinaryTreePaths(TreeNode root) {
            IList<string> result = new List<string>();
            string pathSoFar = "";
            BinaryTreePathHelper(root, pathSoFar, result);
            return result;
        }

        private static void BinaryTreePathHelper(TreeNode root, string pathSoFar, IList<string> result)
        {
            if(root == null) return;
            if(pathSoFar == "")
            {
                pathSoFar +=  root.val.ToString();
            }
            else
            {
                pathSoFar += "->"+root.val.ToString();
            }
            if(root.left == null && root.right == null)
            {
                result.Add(pathSoFar);
                return;
            }
            BinaryTreePathHelper(root.left, pathSoFar, result);
            BinaryTreePathHelper(root.right, pathSoFar, result);
        }

  }
}


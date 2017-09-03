using System;
using System.Collections.Generic;

namespace LevelOrderTraversal
{
   //https://leetcode.com/problems/binary-tree-level-order-traversal/description/ 
    class Program
    {
        static void Main(string[] args)
        {
           TreeNode root = new TreeNode(3);
           root.left = new TreeNode(9);
           root.right = new TreeNode(20);
           root.right.left = new TreeNode(15);
           root.right.right = new TreeNode(7);
           var l = LevelOrder(root);
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
           var r = new List<IList<int>>();
           if(root == null) return r;
           Queue<TreeNode> q = new Queue<TreeNode>();
           q.Enqueue(root);
           while(q.Count  != 0)
           {
             List<int> t = new List<int>();
             var levelCount = q.Count;
             for(int i = 0 ; i < levelCount; i++)
             {
                 var current = q.Peek();
                 if(current.left != null) q.Enqueue(current.left);
                 if(current.right!= null) q.Enqueue(current.right);
                 t.Add(q.Dequeue().val);
             }
             r.Add(t);
           }
           return r;

           
           



        }
    }
}

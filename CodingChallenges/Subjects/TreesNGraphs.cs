using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructures;

namespace CodingChallenges
{
    // TODO: Comment class
    public static class TreesNGraphs
    {
        public static List<int> InOrderTraversal(TreeNode<int> root)
        {
            List<int> result = new List<int>();
            InOrderTraversalRec(root, result);
            return result;
        }

        private static void InOrderTraversalRec(TreeNode<int> root, List<int> result)
        {
            if (root == null) return;

            InOrderTraversalRec(root.Left, result);
            result.Add(root.Value);
            InOrderTraversalRec(root.Right, result);
        }

        private static void PreOrderTraversalRec(TreeNode<int> root, List<int> result)
        {
            if (root == null) return;

            result.Add(root.Value);
            PreOrderTraversalRec(root.Left, result);
            PreOrderTraversalRec(root.Right, result);
        }

        private static void PostOrderTraversalRec(TreeNode<int> root, List<int> result)
        {
            if (root == null) return;

            PostOrderTraversalRec(root.Left, result);
            PostOrderTraversalRec(root.Right, result);
            result.Add(root.Value);
        }
    }
}

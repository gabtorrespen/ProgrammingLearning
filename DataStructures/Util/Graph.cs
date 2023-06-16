using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Util
{
    // TODO: Comment class
    public static class Graph
    {
        public static DataStructures.TreeNode<T> GenerateTreeNode<T>(List<T> values)
        {
            if (values.Count == 0)
                return null;

            Queue<DataStructures.TreeNode<T>> nodesToVisit = new Queue<DataStructures.TreeNode<T>>();

            DataStructures.TreeNode<T> root = new DataStructures.TreeNode<T>(values[0]);
            DataStructures.TreeNode<T> current, left, right;
            int currentIdx = 0, leftIdx, rightIdx;

            nodesToVisit.Enqueue(root);

            while (nodesToVisit.Count > 0 || currentIdx < values.Count / 2)
            {
                current = nodesToVisit.Dequeue();

                // Create and assign children
                leftIdx = currentIdx * 2 + 1;
                rightIdx = leftIdx + 1;

                if (leftIdx < values.Count)
                {
                    left = new DataStructures.TreeNode<T> { Value = values[leftIdx] };
                    current.Left = left;
                    nodesToVisit.Enqueue(left);
                }

                if (rightIdx < values.Count)
                {
                    right = new DataStructures.TreeNode<T> { Value = values[rightIdx] };
                    current.Right = right;
                    nodesToVisit.Enqueue(right);
                }

                currentIdx++;
            }

            return root;
        }
    }
}

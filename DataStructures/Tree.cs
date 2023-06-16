using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // TODO: Comment class
    // TODO: Review non-nullable case
    public class TreeNode<T>
    {
        public T Value;
        public TreeNode<T> Left;
        public TreeNode<T> Right;

        public TreeNode(T value, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public TreeNode() { }

        public override string ToString()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(this);

            TreeNode<T> current;
            int currentLevel = 0;
            int currentLevelCount = 0;
            int currentLevelMax = 1;

            StringBuilder sb = new StringBuilder();

            while(queue.Count > 0)
            {
                current = queue.Dequeue();

                currentLevelCount++;
                sb.Append(current.Value + " - ");
                
                if(current.Left != null)
                    queue.Enqueue(current.Left);
                if(current.Right != null)
                    queue.Enqueue(current.Right);

                if (currentLevelCount == currentLevelMax)
                {
                    currentLevel++;
                    currentLevelMax = (int)Math.Pow(2, currentLevel);
                    currentLevelCount = 0;

                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }
    }
}

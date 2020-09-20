using Shared.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercises.Subjects
{
    public class LinkedLists
    {
        public Node<int> RemoveDuplicates(Node<int> head)
        {
            if (head == null)
                return null;

            Node<int> actual = head;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            dict[head.Value] = true;

            while (actual.Next != null)
            {
                if (dict.ContainsKey(actual.Next.Value))
                {
                    actual.Next = actual.Next.Next;
                }
                else
                {
                    dict[actual.Next.Value] = true;
                    actual = actual.Next;
                }
            }
            return head;
        }

    }
}

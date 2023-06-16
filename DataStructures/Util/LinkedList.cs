using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Util
{
    // TODO: Comment
    public static class LinkedList
    {
        public static DataStructures.LinkedList<T> GenerateLinkedList<T>(List<T> objects) where T : IComparable
        {
            if (objects.Count == 0)
                return null;


            DataStructures.LinkedListNode<T> head = new DataStructures.LinkedListNode<T>(objects[0]);
            DataStructures.LinkedListNode<T> actual = head;

            for (int i = 1; i < objects.Count; i++)
            {
                actual.Next = new DataStructures.LinkedListNode<T>(objects[i]);
                actual = actual.Next;
            }

            return new DataStructures.LinkedList<T>(head);
        }

        public static DataStructures.LinkedListNode<T> DeleteNode<T>(DataStructures.LinkedListNode<T> head, T value) where T : IComparable
        {
            if (head == null)
                return null;

            if (head.Value.CompareTo(value) == 0)
                return head.Next;

            DataStructures.LinkedListNode<T> actual = head;
            while (actual.Next != null)
            {
                if (actual.Next.Value.CompareTo(value) == 0)
                {
                    actual.Next = actual.Next.Next;
                    return head;
                }
                actual = actual.Next;
            }
            return head;
        }
    }
}

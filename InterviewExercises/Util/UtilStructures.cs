using InterviewExercises.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercises.Util
{
    public class UtilStructures
    {
        public static class LinkedList
        {
            public static Node<T> GenerateLinkedList<T>(List<T> objects) where T : IComparable
            {
                if (objects.Count == 0)
                    return null;


                Node<T> head = new Node<T>(objects[0]);
                Node<T> actual = head;

                for (int i = 1; i < objects.Count; i++)
                {
                    actual.Next = new Node<T>(objects[i]);
                    actual = actual.Next;
                }

                return head;
            }

            public static Node<T> DeleteNode<T>(Node<T> head, T value) where T : IComparable
            {
                if (head == null)
                    return null;

                if (head.Value.CompareTo(value) == 0)
                    return head.Next;

                Node<T> actual = head;
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
}

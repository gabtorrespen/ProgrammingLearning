using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DataStructures
{
    public class Node<T> where T:IComparable
    {
        public Node<T> Next { get; set; }
        public T Value { get; set; }

        public Node(){}

        public Node(T value)
        {
            Value = value;
        }

        public void AppendToTail(T value)
        {
            Node<T> actual = this;
            while(actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = new Node<T>(value);
        }

        public override bool Equals(object obj)
        {
            Node<T> n1 = (Node<T>)obj;
            Node<T> n2 = this;

            while (n1 != null)
            {
                if (n2 == null || n1.Value.CompareTo(n2.Value) != 0)
                    return false;

                n1 = n1.Next;
                n2 = n2.Next;
            }

            if (n2 != null)
                return false;

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Node<T> actual = this;
            while (actual != null)
            {
                sb.Append(actual.Value + " -> ");
                actual = actual.Next;
            }
            return sb.ToString();
        }
    }
}

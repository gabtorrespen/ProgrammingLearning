using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // TODO: Comment class
    public class LinkedList<T> where T : IComparable
    {
        public LinkedListNode<T> Head { get; set; }

        public LinkedList (LinkedListNode<T> head)
        {
            Head = head;
        }

        // TODO: Check nullability potential issue
        public override bool Equals(object obj)
        {
            if (obj is LinkedList<T> linkedList)
            {
                return this.Head.Equals(linkedList.Head);
            }

            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    public class LinkedListNode<T> where T : IComparable
    {
        public LinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public LinkedListNode() { }

        public LinkedListNode(T value)
        {
            Value = value;
        }

        public void AppendToTail(T value)
        {
            LinkedListNode<T> actual = this;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = new LinkedListNode<T>(value);
        }

        public override bool Equals(object obj)
        {
            LinkedListNode<T> n1 = (LinkedListNode<T>)obj;
            LinkedListNode<T> n2 = this;

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

            LinkedListNode<T> actual = this;
            while (actual != null)
            {
                sb.Append(actual.Value + " -> ");
                actual = actual.Next;
            }
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }


}

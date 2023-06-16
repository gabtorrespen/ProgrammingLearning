using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructures;


namespace CodingChallenges
{
    //TODO: Comment class
    public static class LinkedLists
    {
        public static DataStructures.LinkedList<int> RemoveDuplicates(DataStructures.LinkedList<int> linkedList)
        {
            if (linkedList.Head == null)
                return null;

            DataStructures.LinkedListNode<int> actual = linkedList.Head;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            dict[actual.Value] = true;

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
            return linkedList;
        }

    }
}

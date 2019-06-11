using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DatastructureOperations
{
    public static class DatastructureAlgorithms
    {
        public static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> linkedList)
        {
            LinkedList<T> results = new LinkedList<T>();

            // Start from the last node.
            LinkedListNode<T> start = linkedList.Last;

            for (int i = linkedList.Count; i > 0; i--)
                results.AddLast(linkedList.ElementAt(i));

            return results;
        }

        public static LinkedListNode<T> FindNode<T>(LinkedList<T> linkedList)
        {
            return linkedList.Find();
        }
    }
}

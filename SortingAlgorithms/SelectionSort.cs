using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Sorting
{
    public class SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            // move through all elements starting with the first one
            var current = list.GetFirst();
            while (current != null)
            {
                // iterate thourgh all other elements, search for the smallest and change
                var nextSmallest = getNextSmallest(current);
                if (nextSmallest != current)
                    list.SwitchNode(current, nextSmallest);
                current = current.next;
            }
            Console.WriteLine("SelectionSorted list ");
        }

        private Node getNextSmallest(Node startNode)
        {
            Node smallest = startNode;
            for (var comparer = startNode.next; comparer != null; comparer = comparer.next)
                if (comparer.data < smallest.data)
                    smallest = comparer;
            return smallest;
        }

        public override void SortDesc(IMyList list)
        {
            throw new NotImplementedException();
        }
    }

}

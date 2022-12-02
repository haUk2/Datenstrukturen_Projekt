using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data < nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }

    public class InsertionSortInverse : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data > nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Sorting
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            _BubbleSort(list, SortOrder.ascending);
        }

        
        private void _BubbleSort(IMyList list, SortOrder order)
        {
            var nextNode = list.GetFirst().next;
            var switched = true;
            while (switched)
            {
                switched = false;
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if ((order == SortOrder.ascending && cur.data > cur.next.data) || 
                        order == SortOrder.descending && cur.data < cur.next.data)
                    {
                        (cur.data, cur.next.data) = (cur.next.data, cur.data);
                        switched = true;
                    }
                }
            }
            Console.WriteLine("BubbleSorted list: " + list);
        }

        public override void SortDesc(IMyList list)
        {
            _BubbleSort(list, SortOrder.descending);
        }
    }
}

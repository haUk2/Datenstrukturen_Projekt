using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyList
    {
        void SwitchNode(int firstNode, int secondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
    }
}
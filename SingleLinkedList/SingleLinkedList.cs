using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class SingleLinkedList : IMyList
    {
        Node first = null;
        Node last = null;
        int _count = 0;
        SortStrategy sortstrategy;
        public void InsertLast(Node newNode)
        {
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.next = newNode;
                last = newNode;
            }
            _count++;
        }

        public void SwitchNode(Node argFirstNode, Node argSecondNode)
        {
            var fn = GetNode(argFirstNode);
            var sn = GetNode(argSecondNode);
            if (fn == null || sn == null)
                return;
            (fn.data, sn.data) = (sn.data, fn.data);
            return;
        }

        public Node GetNode(Node argNode)
        {
            Node current = first;
            if (current.data == argNode.data)
                return current;

            while (current.next != null)
            {
                if (current.data == argNode.data)
                    return current;
                current = current.next;
            }
            return null;
        }


        public int count()
        {
            return _count;
        } // return the number of elements in the linked list
        public override string ToString() {
            string retval = "";
            if (first == null)
                return "No elements in List";
            
            var node = first;
            while (node != null)
            {
                retval += "| " + node.data + " ";
                node = node.next;
            }
            retval += "|";
            return retval;
        }

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            sortstrategy = sortStrategy;
        }

        public Node GetFirst()
        {
            return first;
        }

        public Node GetLast()
        {
            return last;
        }

        public void RemoveLastElement()
        {
            var cur = first;
            while (cur.next != null)
            {
                if (cur.next.next == null)
                {
                    cur.next = null;
                    break;
                }; 
                cur = cur.next;
            }
        }

        public void Sort()
        {
            sortstrategy.Sort(this);
        }

        public void SortDesc()
        {
            sortstrategy.SortDesc(this);
        }
    }
}

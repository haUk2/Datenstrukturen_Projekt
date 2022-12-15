using Common;
using GenericList;

namespace MyStack
{
    public class MyStack
    {
        private SingleLinkedList internalList = new SingleLinkedList();

        public Node Push(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.InsertLast(nodeToAdd);
            return nodeToAdd; 
        }

        public Node Pop()
        {
            var retval = internalList.GetLast();
            internalList.RemoveLastElement();
            return retval;
        }

        public override string ToString()
        {   
            return internalList.ToString();
        }

    }
}
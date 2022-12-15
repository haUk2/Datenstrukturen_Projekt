using Common;
using GenericList;

namespace MyStack
{
    public class MyQueue : ISubject
    {
        private SingleLinkedList internalList = new SingleLinkedList();
        // List of subscribers. 
        private List<IObserver> _observers = new List<IObserver>();
        public Node Enqueue(int argValue)
        {
            var nodeToAdd = new Node(argValue);
            internalList.InsertLast(nodeToAdd);
            this.Notify();
            return nodeToAdd; 
        }

        public Node Dequeue()
        {
            var retval = internalList.GetFirst();
            internalList.RemoveFirstElement();
            this.Notify();
            return retval;
        }

        public override string ToString()
        {   
            return internalList.ToString();
        }

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
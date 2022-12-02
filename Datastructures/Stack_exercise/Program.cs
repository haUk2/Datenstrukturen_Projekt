using System.Collections;

namespace Stack_exercise
{
    
     public class myStack<T>
    {
        List<T> items = new List<T>();

        public void push(T item)
        {
            items.Add(item);
        }

        public T pop()
        {
            T _items = items[^1];
            items.RemoveAt(items.Count - 1);
            return _items;
        }

        public int size()
        {
            return items.Count;
        }
    }
}